using DoAn.Forms.SmallForms;
using DoAn.NewFolder1;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormMakeListExamine : Form
    {
        public Patient PatientData { get; private set; }
        private bool isDataGridViewInitialized = false;
        public FormMakeListExamine()
        {
            InitializeComponent();

            InitializeDataGridView();

        }
        private void InitializeDataGridView()
        {
            using (var db = new DataPKEntities())
            {
                var select = from s in db.CHITIETTHUOCs
                             select s;
                foreach (var medicine in select)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListMedicine);
                    row.Cells[dGVListMedicine.Columns["Index"].Index].Value = medicine.MaCTThuoc;
                    row.Cells[dGVListMedicine.Columns["MedicineName"].Index].Value = medicine.THUOC.TenThuoc;
                    //row.Cells[dGVListMedicine.Columns["Price"].Index].Value = medicine.DonGia;

                    //Populate textBox column for units
                    row.Cells[dGVListMedicine.Columns["Unit"].Index].Value = medicine.DONVI.TenDonVi;

                    DataGridViewTextBoxCell quantityTextBoxCell = new DataGridViewTextBoxCell();
                    quantityTextBoxCell.Value = 0;
                    row.Cells[dGVListMedicine.Columns["Quantity"].Index] = quantityTextBoxCell;


                    // Populate ComboBox column for usage
                    DataGridViewComboBoxCell usageComboBoxCell = new DataGridViewComboBoxCell();
                    var usages = db.CACHDUNGs.ToList();
                    foreach (var usage in usages)
                    {
                        usageComboBoxCell.Items.Add(usage.TenCachDung);
                    }
                    row.Cells[dGVListMedicine.Columns["Usage"].Index] = usageComboBoxCell;

                    // Add checkbox column for adding
                    DataGridViewCheckBoxCell addCheckBoxCell = new DataGridViewCheckBoxCell();
                    addCheckBoxCell.Value = false;
                    row.Cells[dGVListMedicine.Columns["Add"].Index] = addCheckBoxCell;

                    dGVListMedicine.Rows.Add(row);
                }
                var loaibenh = from s in db.LOAIBENHs
                               select s;
                foreach (var item in loaibenh)
                {
                    cbbTypeOfDisease.Items.Add(item.TenLoaiBenh);
                }
                cbbTypeOfDisease.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbTypeOfDisease.AutoCompleteSource = AutoCompleteSource.ListItems;
                dGVListMedicine.CellValueChanged += dGVListMedicine_CellValueChanged;
                isDataGridViewInitialized = true;
            }

        }
        private void btnReset_Click(object sender, System.EventArgs e)
        {
            // Clear the existing rows
            dGVListMedicine.Rows.Clear();
            // Repopulate the DataGridView with the initial data
            InitializeDataGridView();
        }

        private void dGVListMedicine_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dGVListMedicine.Columns[e.ColumnIndex].Name == "Quantity" && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dGVListMedicine.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleRight; // Set the desired alignment
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PatientData != null)
            {
                if (cbbTypeOfDisease.Items.Contains(cbbTypeOfDisease.Texts))
                {
                    if (txtTrieuChung.Text != null)
                    {
                        var benhnhan = new BENHNHAN();
                        benhnhan.HoTen = PatientData.Name;
                        benhnhan.GioiTinh = PatientData.Sex;
                        benhnhan.NamSinh = PatientData.Birth;
                        benhnhan.DiaChi = PatientData.Address;
                        using (var db = new DataPKEntities())
                        {
                            //Add benh nhan
                            db.BENHNHANs.Add(benhnhan);
                            db.SaveChanges();
                            //Add phieu kham
                            if (cbbTypeOfDisease.Texts != null)
                            {
                                var loaibenh = (from s in db.LOAIBENHs
                                                where s.TenLoaiBenh == cbbTypeOfDisease.Texts
                                                select s).FirstOrDefault();
                                var phieukham = new PHIEUKHAM();
                                phieukham.MaBenhNhan = benhnhan.MaBenhNhan;
                                phieukham.NgayKham = dpDate.Value;
                                phieukham.TrieuChung = txtTrieuChung.Text;
                                phieukham.MaLoaiBenh = loaibenh.MaLoaiBenh;
                                db.PHIEUKHAMs.Add(phieukham);
                                db.SaveChanges();
                                //Add chi tiet phieu kham
                                foreach (DataGridViewRow row in dGVListMedicine.Rows)
                                {
                                    if (Convert.ToBoolean(row.Cells["Add"].Value) == true && Convert.ToInt32(row.Cells["Quantity"].Value) > 0)
                                    {
                                        var chitietphieukham = new CHITIETPHIEUKHAM();
                                        chitietphieukham.MaPhieuKham = phieukham.MaPhieuKham;
                                        chitietphieukham.MaCTThuoc = Convert.ToInt32(row.Cells["Index"].Value);
                                        string usage = row.Cells["Usage"].Value.ToString();
                                        chitietphieukham.MaCachDung = (from s in db.CACHDUNGs
                                                                       where s.TenCachDung == usage
                                                                       select s.MaCachDung).FirstOrDefault();
                                        chitietphieukham.SoLuong = Convert.ToInt32(row.Cells["Quantity"].Value);
                                        db.CHITIETPHIEUKHAMs.Add(chitietphieukham);
                                        db.SaveChanges();
                                    }
                                }
                            }
                            MessageBox.Show("Đã lưu thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập triệu chứng");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại bệnh");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin bệnh nhân");
            }

        }
        //Pass data from FormPatientDetail to FormMakeListExamine
        private void txtName_Click(object sender, EventArgs e)
        {
            if (PatientData != null)
            {
                FormPatientDetail formPatientDetail = new FormPatientDetail(PatientData);
                formPatientDetail.FormClosed += FormPatientDetail_FormClosed;
                formPatientDetail.Show();
            }
            else
            {
                FormPatientDetail formPatientDetail = new FormPatientDetail();
                formPatientDetail.FormClosed += FormPatientDetail_FormClosed;
                formPatientDetail.Show();
            }

        }

        private void FormPatientDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPatientDetail formPatientDetail = (FormPatientDetail)sender;
            PatientData = formPatientDetail.PatientData;
            if (PatientData != null)
            {
                txtName.Text = PatientData.Name;
            }

        }

        private void dGVListMedicine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isDataGridViewInitialized && e.ColumnIndex == dGVListMedicine.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                DataGridViewCell quantityCell = dGVListMedicine.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string quantityText = quantityCell.Value?.ToString();

                // Check if the quantity is not a number or less than 0
                if (!int.TryParse(quantityText, out int quantity) || quantity < 0)
                {
                    // Perform your desired action when the quantity is not a valid number or less than 0 (e.g., display an error message)
                    MessageBox.Show("Số lượng phải là số không âm.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Reset the quantity value to 0
                    quantityCell.Value = 0;
                }
            }
        }
    }
}
