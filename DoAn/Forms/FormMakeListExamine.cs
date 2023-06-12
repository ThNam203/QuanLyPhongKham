using DoAn.Forms.SmallForms;
using DoAn.NewFolder1;
using System;
using System.Data.Entity;
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
                var select = from s in db.THUOCs
                             select s;
                foreach (var medicine in select)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListMedicine);
                    row.Cells[dGVListMedicine.Columns["Index"].Index].Value = medicine.MaThuoc;
                    row.Cells[dGVListMedicine.Columns["MedicineName"].Index].Value = medicine.TenThuoc;
                    medicine.CHITIETTHUOCs.ToList();
                    DataGridViewComboBoxCell unitCell = new DataGridViewComboBoxCell();
                    foreach (var item in medicine.CHITIETTHUOCs)
                    {
                        unitCell.Items.Add(item.DONVI.TenDonVi);
                    }
                    row.Cells[dGVListMedicine.Columns["Unit"].Index] = unitCell;
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

            cbbTypeOfDisease.Items.Clear();
            PatientData = null;
            // Clear the existing rows
            dGVListMedicine.Rows.Clear();
            // Repopulate the DataGridView with the initial data
            InitializeDataGridView();
            txtName.Clear();
            txtTrieuChung.Clear();
            cbbTypeOfDisease.Texts = null;
            dpDateExam.Value = DateTime.Now;
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

                        using (var db = new DataPKEntities())
                        {
                            string name = PatientData.Name;
                            string sex = PatientData.Sex;
                            DateTime birth = PatientData.Birth;
                            string address = PatientData.Address;

                            // Kiểm tra xem bệnh nhân đã tồn tại trong danh sách hay chưa
                            var existingPatient = db.BENHNHANs.FirstOrDefault(b =>
                                 b.HoTen == name &&
                                 b.GioiTinh == sex &&
                                 DbFunctions.TruncateTime(b.NamSinh) == birth.Date &&
                                 b.DiaChi == address);
                            int id = -1;
                            if (existingPatient != null)
                            {
                                id = existingPatient.MaBenhNhan;
                            }
                            else
                            {
                                var benhnhan = new BENHNHAN();
                                benhnhan.HoTen = PatientData.Name;
                                benhnhan.GioiTinh = PatientData.Sex;
                                benhnhan.NamSinh = PatientData.Birth;
                                benhnhan.DiaChi = PatientData.Address;
                                //Add benh nhan
                                db.BENHNHANs.Add(benhnhan);
                                db.SaveChanges();
                                id = benhnhan.MaBenhNhan;
                            }

                            //Add phieu kham
                            if (cbbTypeOfDisease.Texts != null)
                            {
                                var loaibenh = (from s in db.LOAIBENHs
                                                where s.TenLoaiBenh == cbbTypeOfDisease.Texts
                                                select s).FirstOrDefault();
                                var phieukham = new PHIEUKHAM();
                                phieukham.MaBenhNhan = id;
                                phieukham.NgayKham = dpDateExam.Value;
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
                                        string tenThuoc = row.Cells["MedicineName"].Value.ToString();

                                        string donVi = row.Cells["Unit"].Value?.ToString();
                                        if (donVi == null)
                                        {
                                            continue;
                                        }
                                        var maCTThuoc = (from s in db.CHITIETTHUOCs
                                                         where s.THUOC.TenThuoc == tenThuoc && s.DONVI.TenDonVi == donVi
                                                         select s.MaCTThuoc).FirstOrDefault();

                                        chitietphieukham.MaCTThuoc = maCTThuoc;
                                        string usage = row.Cells["Usage"].Value?.ToString();
                                        if (usage == null)
                                        {
                                            continue;
                                        }
                                        chitietphieukham.MaCachDung = (from s in db.CACHDUNGs
                                                                       where s.TenCachDung == usage
                                                                       select s.MaCachDung).FirstOrDefault();
                                        chitietphieukham.SoLuong = Convert.ToInt32(row.Cells["Quantity"].Value);
                                        db.CHITIETPHIEUKHAMs.Add(chitietphieukham);
                                        db.SaveChanges();
                                    }
                                }
                            }
                            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dGVListMedicine.Rows.Clear();
                            txtName.Clear();
                            txtTrieuChung.Clear();
                            cbbTypeOfDisease.Items.Clear();
                            cbbTypeOfDisease.Texts = null;
                            dpDateExam.Value = DateTime.Now;
                            InitializeDataGridView();
                            PatientData = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập triệu chứng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại bệnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin bệnh nhân", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Vui lòng nhập lại số lượng.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Reset the quantity value to 0
                    quantityCell.Value = 0;
                }
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {

        }

    }
}
