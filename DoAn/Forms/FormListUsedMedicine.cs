using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormListUsedMedicine : Form
    {
        private bool isInitializing = true;
        public FormListUsedMedicine()
        {
            InitializeComponent();
            for (int i = 0; i < 12; i++)
            {
                cbbMonth.Items.Add(i + 1);
            }
            cbbMonth.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMonth.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbMonth.SelectedItem = DateTime.Now.Month;
            txtYear.Text = DateTime.Now.Year.ToString();
            InitializeData();
        }
        private void InitializeData()
        {
            int selectedMonth = (int)cbbMonth.SelectedItem;
            int selectedYear = int.Parse(txtYear.Text);

            using (var db = new DataPKEntities())
            {
                var result = from ctpk in db.CHITIETPHIEUKHAMs
                             join pk in db.PHIEUKHAMs on ctpk.MaPhieuKham equals pk.MaPhieuKham
                             where pk.NgayKham.Value.Month == selectedMonth && pk.NgayKham.Value.Year == selectedYear
                             group ctpk by new
                             {
                                 Thang = pk.NgayKham.Value.Month,
                                 Nam = pk.NgayKham.Value.Year,
                                 ctpk.MaCTThuoc
                             } into g
                             select new
                             {
                                 g.Key.Thang,
                                 g.Key.Nam,
                                 g.Key.MaCTThuoc,
                                 SoLuong = g.Sum(ctpk => ctpk.SoLuong),
                                 SoLanDung = g.Count()
                             };

                foreach (var item in result)
                {
                    var chiTietThuoc = (from s in db.CHITIETTHUOCs
                                        where s.MaCTThuoc == item.MaCTThuoc
                                        select s).FirstOrDefault();
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListUsedMedicine);
                    row.Cells[dGVListUsedMedicine.Columns["Index"].Index].Value = item.MaCTThuoc;
                    row.Cells[dGVListUsedMedicine.Columns["MedicineName"].Index].Value = chiTietThuoc.THUOC.TenThuoc;
                    row.Cells[dGVListUsedMedicine.Columns["Unit"].Index].Value = chiTietThuoc.DONVI.TenDonVi;
                    row.Cells[dGVListUsedMedicine.Columns["NumberUsed"].Index].Value = item.SoLanDung;
                    row.Cells[dGVListUsedMedicine.Columns["TotalNumber"].Index].Value = item.SoLuong;
                    dGVListUsedMedicine.Rows.Add(row);
                }
            }
        }

        private void cbbMonth_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing)
            {
                isInitializing = false;
                return;
            }

            dGVListUsedMedicine.Rows.Clear();
            InitializeData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (IsYearValid(txtYear.Text))
            {
                dGVListUsedMedicine.Rows.Clear();
                InitializeData();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYear.Text = DateTime.Now.Year.ToString();
                dGVListUsedMedicine.Rows.Clear();
                InitializeData();
                return;
            }
        }
        private bool IsYearValid(string text)
        {
            int year;
            if (int.TryParse(text, out year))
            {
                if (year >= DateTime.MinValue.Year && year <= DateTime.MaxValue.Year)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
