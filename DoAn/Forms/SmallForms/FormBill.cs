using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms.SmallForms
{
    public partial class FormBill : Form
    {
        private int id;
        private bool isPaid;
        public FormBill()
        {
            InitializeComponent();
        }
        public FormBill(int id, bool isPaid)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
            this.id = id;
            label5.Text = "#" + id.ToString();
            this.isPaid = isPaid;
            if (isPaid)
            {
                btnPaid.Text = "Ok";
                InitializePaidData();
            }
            else
            {
                InitializeData();
            }
        }
        private void InitializeData()
        {
            using (var db = new DataPKEntities())
            {
                //Lay tien kham
                var tienkham = (from s in db.THAMSOes
                                select s.TienKham).FirstOrDefault();
                var select = (from s in db.PHIEUKHAMs
                              where s.MaPhieuKham == id
                              select s).FirstOrDefault();
                //Lay tong tien thuoc
                var total = db.CHITIETPHIEUKHAMs
                       .Where(ctpk => ctpk.MaPhieuKham == select.MaPhieuKham)
                       .Join(db.CHITIETTHUOCs, ctpk => ctpk.MaCTThuoc, ct => ct.MaCTThuoc,
                       (ctpk, ct) => new { ctpk, ct })
                       .Sum(x => x.ct.DonGia * x.ctpk.SoLuong);
                dpDate.Value = select.NgayKham.Value;
                txtDisease.Text = select.LOAIBENH.TenLoaiBenh;
                txtExamineMoney.Text = tienkham.ToString();
                txtName.Text = select.BENHNHAN.HoTen;
                txtTotal.Text = (tienkham + total).ToString();
                if (total == null)
                {
                    txtTotal.Text = tienkham.ToString();
                }

                //Lay danh sach thuoc
                var select2 = from s in db.CHITIETPHIEUKHAMs
                              join ct in db.CHITIETTHUOCs on s.MaCTThuoc equals ct.MaCTThuoc
                              join t in db.THUOCs on ct.MaThuoc equals t.MaThuoc
                              join d in db.DONVIs on ct.MaDonVi equals d.MaDonVi
                              join pk in db.PHIEUKHAMs on s.MaPhieuKham equals pk.MaPhieuKham
                              where pk.MaPhieuKham == id // Replace 1 with the desired MaPhieuKham
                              select new
                              {
                                  t.TenThuoc,
                                  d.TenDonVi,
                                  s.SoLuong,
                                  ct.DonGia,
                                  Total = s.SoLuong * ct.DonGia
                              };

                foreach (var medicine in select2)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListMedicine);
                    row.Cells[dGVListMedicine.Columns["MedicineName"].Index].Value = medicine.TenThuoc;
                    row.Cells[dGVListMedicine.Columns["Unit"].Index].Value = medicine.TenDonVi;
                    row.Cells[dGVListMedicine.Columns["Quantity"].Index].Value = medicine.SoLuong;
                    row.Cells[dGVListMedicine.Columns["Price"].Index].Value = medicine.DonGia;
                    row.Cells[dGVListMedicine.Columns["Total"].Index].Value = medicine.Total;
                    dGVListMedicine.Rows.Add(row);
                }
            }
        }

        private void InitializePaidData()
        {
            using (var db = new DataPKEntities())
            {
                var select = (from s in db.HOADONs
                              where s.MaPhieuKham == id
                              select s).FirstOrDefault();
                //Lay tong tien thuoc
                var total = select.TienThuoc;
                dpDate.Value = select.NgayKham.Value;
                txtDisease.Text = select.PHIEUKHAM.LOAIBENH.TenLoaiBenh;
                txtExamineMoney.Text = select.TienKham.ToString();
                txtName.Text = select.PHIEUKHAM.BENHNHAN.HoTen;
                txtTotal.Text = (select.TienKham + total).ToString();
                if (total == null)
                {
                    txtTotal.Text = select.TienKham.ToString();
                }

                //Lay danh sach thuoc
                var select2 = from s in db.CTHOADONs
                              where s.HOADON.MaPhieuKham == id
                              select s;

                foreach (var medicine in select2)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListMedicine);
                    row.Cells[dGVListMedicine.Columns["MedicineName"].Index].Value = medicine.TenThuoc;
                    row.Cells[dGVListMedicine.Columns["Quantity"].Index].Value = medicine.SoLuong;
                    row.Cells[dGVListMedicine.Columns["Price"].Index].Value = medicine.TongTien / medicine.SoLuong; // [TongTien] / [SoLuong]
                    row.Cells[dGVListMedicine.Columns["Unit"].Index].Value = medicine.TenDonVi;
                    row.Cells[dGVListMedicine.Columns["Total"].Index].Value = medicine.TongTien;
                    dGVListMedicine.Rows.Add(row);
                }
            }
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (isPaid)
            {
                this.Close();
                return;
            }
            using (var db = new DataPKEntities())
            {
                var hoadon = new HOADON();
                hoadon.MaPhieuKham = id;
                hoadon.NgayKham = dpDate.Value;
                hoadon.TienThuoc = int.Parse(txtTotal.Text) - int.Parse(txtExamineMoney.Text);
                hoadon.TienKham = int.Parse(txtExamineMoney.Text);
                db.HOADONs.Add(hoadon);
                foreach (DataGridViewRow row in dGVListMedicine.Rows)
                {
                    var cthd = new CTHOADON();
                    cthd.MaHoaDon = hoadon.MaHoaDon;
                    cthd.TenThuoc = row.Cells["MedicineName"].Value.ToString();
                    cthd.TenDonVi = row.Cells["Unit"].Value.ToString();
                    cthd.SoLuong = int.Parse(row.Cells["Quantity"].Value.ToString());
                    cthd.TongTien = int.Parse(row.Cells["Total"].Value.ToString());
                    db.CTHOADONs.Add(cthd);
                }
                db.SaveChanges();
            }
            //Show message box "Thanh toan thanh cong"
            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
