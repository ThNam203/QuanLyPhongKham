using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms.SmallForms
{
    public partial class FormBill : Form
    {
        private int id;

        public FormBill()
        {
            InitializeComponent();
        }
        public FormBill(int id)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
            this.id = id;
            label5.Text = "#" + id.ToString();
            InitializeData();
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
                txtDisease.Text = select.TrieuChung;
                txtExamineMoney.Text = tienkham.ToString();
                txtName.Text = select.BENHNHAN.HoTen;
                txtTotal.Text = (tienkham + total).ToString();
                if (txtTotal.Text == null)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaid_Click(object sender, EventArgs e)
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
