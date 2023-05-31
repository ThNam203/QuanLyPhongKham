using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormMakeListExamine : Form
    {

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
                    //row.Cells[dGVListMedicine.Columns["Price"].Index].Value = medicine.DonGia;

                    //Populate ComboBox column for units
                    DataGridViewComboBoxCell comboCell = new DataGridViewComboBoxCell();
                    var units = from u in db.DONVIs
                                select u;
                    foreach (var unit in units)
                    {
                        comboCell.Items.Add(unit.TenDonVi);
                    }
                    row.Cells[dGVListMedicine.Columns["Unit"].Index] = comboCell;

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
            using (var db = new DataPKEntities())
            {
                int lastMaPhieuKham = db.PHIEUKHAMs.Max(p => p.MaPhieuKham);
                foreach (DataGridViewRow row in dGVListMedicine.Rows)
                {
                    int maThuoc = Convert.ToInt32(row.Cells["Index"].Value);
                    string tenDonVi = row.Cells["Unit"].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells["Quantity"].Value);
                    string tenCachDung = row.Cells["Usage"].Value.ToString();
                    bool add = Convert.ToBoolean(row.Cells["Add"].Value);

                    if (add)
                    {
                        // Save the data into the database
                        var thuoc = db.THUOCs.Find(maThuoc);
                        var donVi = db.DONVIs.SingleOrDefault(u => u.TenDonVi == tenDonVi);
                        var cachDung = db.CACHDUNGs.SingleOrDefault(u => u.TenCachDung == tenCachDung);

                        if (thuoc != null && donVi != null && cachDung != null)
                        {
                            // Create a new CHITIETPHIEUKHAM entity
                            var chitietPhieuKham = new CHITIETPHIEUKHAM
                            {
                                MaPhieuKham = lastMaPhieuKham + 1, // Set the appropriate MaPhieuKham value
                                MaThuoc = thuoc.MaThuoc,
                                MaDonVi = donVi.MaDonVi,
                                MaCachDung = cachDung.MaCachDung,
                                SoLuong = soLuong
                            };

                            // Add the CHITIETPHIEUKHAM to the database
                            db.CHITIETPHIEUKHAMs.Add(chitietPhieuKham);
                        }
                    }
                }

                // Save the changes to the database
                db.SaveChanges();
                MessageBox.Show("Lưu thành công");
            }
        }

    }
}
