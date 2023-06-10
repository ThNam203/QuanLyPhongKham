using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormMakeListGetMedicine : Form
    {
        public FormMakeListGetMedicine()
        {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            txtTotal.Text = "0";
            using (var db = new DataPKEntities())
            {
                var medicines = from s in db.CHITIETTHUOCs
                                select s;
                foreach (var medicine in medicines)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListMedicine);
                    row.Cells[dGVListMedicine.Columns["Index"].Index].Value = medicine.MaCTThuoc;
                    row.Cells[dGVListMedicine.Columns["MedicineName"].Index].Value = medicine.THUOC.TenThuoc;
                    row.Cells[dGVListMedicine.Columns["Price"].Index].Value = medicine.DonGia;
                    row.Cells[dGVListMedicine.Columns["Quantity"].Index].Value = 0;
                    row.Cells[dGVListMedicine.Columns["Total"].Index].Value = 0;
                    row.Cells[dGVListMedicine.Columns["Unit"].Index].Value = medicine.DONVI.TenDonVi;
                    dGVListMedicine.Rows.Add(row);

                }

            }
        }

        private void dGVListMedicine_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dGVListMedicine.Columns[e.ColumnIndex].Name == "Quantity" && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dGVListMedicine.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleRight; // Set the desired alignment
            }
        }

        private void dGVListMedicine_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dGVListMedicine.Columns["Quantity"].Index)
            {
                DataGridViewRow row = dGVListMedicine.Rows[e.RowIndex];
                DataGridViewCell quantityCell = row.Cells["Quantity"];
                DataGridViewCell priceCell = row.Cells["Price"];
                DataGridViewCell totalCell = row.Cells["Total"];

                // Validate the entered quantity
                if (int.TryParse(quantityCell.Value?.ToString(), out int quantity) && quantity >= 0)
                {
                    // Get the price
                    if (decimal.TryParse(priceCell.Value?.ToString(), out decimal price))
                    {
                        // Calculate the total
                        decimal total = quantity * price;

                        // Update the total cell
                        totalCell.Value = total;
                        CalculateTotal();
                    }
                    else
                    {
                        MessageBox.Show("Đơn giá lỗi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        quantityCell.Value = 0; // Reset the quantity to 0
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại số lượng thuốc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantityCell.Value = 0; // Reset the quantity to 0
                }
            }
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dGVListMedicine.Rows)
            {
                if (decimal.TryParse(row.Cells["Total"].Value?.ToString(), out decimal rowTotal))
                {
                    total += rowTotal;
                }
            }

            txtTotal.Text = total.ToString();
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            txtName.Clear();
            dGVListMedicine.Rows.Clear();
            InitializeData();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var db = new DataPKEntities())
            {
                if (HasPositiveQuantity() == false)
                {
                    MessageBox.Show("Vui lòng nhập số lượng thuốc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var phieuNhapThuoc = new PHIEUNHAPTHUOC();
                phieuNhapThuoc.NgayNhap = dpDate.Value;
                phieuNhapThuoc.TongTien = int.Parse(txtTotal.Text);
                phieuNhapThuoc.NhaCungCap = txtName.Text;
                db.PHIEUNHAPTHUOCs.Add(phieuNhapThuoc);
                db.SaveChanges();
                foreach (DataGridViewRow row in dGVListMedicine.Rows)
                {
                    if (row.Cells["Quantity"].Value == null || row.Cells["Quantity"].Value.ToString() == "0")
                    {
                        continue;
                    }
                    var chiTietPhieuNhapThuoc = new CHITIETPHIEUNHAPTHUOC();
                    chiTietPhieuNhapThuoc.MaPhieuNhapThuoc = phieuNhapThuoc.MaPhieuNhapThuoc;
                    chiTietPhieuNhapThuoc.MaCTThuoc = int.Parse(row.Cells["Index"].Value.ToString());
                    chiTietPhieuNhapThuoc.SoLuong = int.Parse(row.Cells["Quantity"].Value.ToString());
                    chiTietPhieuNhapThuoc.ThanhTien = int.Parse(row.Cells["Price"].Value.ToString());
                    db.CHITIETPHIEUNHAPTHUOCs.Add(chiTietPhieuNhapThuoc);
                    db.SaveChanges();
                }
            }
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtName.Clear();
            dGVListMedicine.Rows.Clear();
            InitializeData();
        }
        private bool HasPositiveQuantity()
        {
            foreach (DataGridViewRow row in dGVListMedicine.Rows)
            {
                if (row.Cells["Quantity"].Value != null && int.Parse(row.Cells["Quantity"].Value.ToString()) > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
