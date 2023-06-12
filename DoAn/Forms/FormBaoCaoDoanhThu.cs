using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormBaoCaoDoanhThu : Form
    {
        private bool isInitializing = true;
        public FormBaoCaoDoanhThu()
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
                DateTime startDate = new DateTime(selectedYear, selectedMonth, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);
                var doanhThu = db.HOADONs
                   .Where(h => h.NgayKham >= startDate && h.NgayKham <= endDate)
                   .Sum(h => h.TienKham + h.TienThuoc);

                var result = from pk in db.PHIEUKHAMs
                             join hd in db.HOADONs on pk.MaPhieuKham equals hd.MaPhieuKham
                             where pk.NgayKham.Value.Month == selectedMonth && pk.NgayKham.Value.Year == selectedYear
                             group new { pk, hd } by new
                             {
                                 Ngay = pk.NgayKham.Value.Day,
                                 Thang = pk.NgayKham.Value.Month,
                                 Nam = pk.NgayKham.Value.Year
                             } into g
                             select new
                             {
                                 Ngay = g.Key.Ngay,
                                 Thang = g.Key.Thang,
                                 Nam = g.Key.Nam,
                                 SLBN = g.Count(),
                                 DoanhThu = g.Sum(x => x.hd.TienKham + x.hd.TienThuoc)
                             };
                foreach (var item in result)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListRevenue);
                    row.Cells[dGVListRevenue.Columns["Day"].Index].Value = item.Ngay;

                    row.Cells[dGVListRevenue.Columns["Revenue"].Index].Value = item.DoanhThu;
                    row.Cells[dGVListRevenue.Columns["Percent"].Index].Value = item.DoanhThu / doanhThu;
                    DateTime date = new DateTime(item.Nam, item.Thang, item.Ngay);
                    var countBenhNhan = db.PHIEUKHAMs
                    .Where(p => p.NgayKham.Value.Year == item.Nam && p.NgayKham.Value.Month == item.Thang && p.NgayKham.Value.Day == item.Ngay)
                    .Select(p => p.MaBenhNhan)
                    .Distinct()
                    .Count();
                    row.Cells[dGVListRevenue.Columns["PatientNumber"].Index].Value = countBenhNhan;
                    dGVListRevenue.Rows.Add(row);
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

            dGVListRevenue.Rows.Clear();
            InitializeData();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (IsYearValid(txtYear.Text))
            {
                dGVListRevenue.Rows.Clear();
                InitializeData();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYear.Text = DateTime.Now.Year.ToString();
                dGVListRevenue.Rows.Clear();
                InitializeData();
                return;
            }
        }
    }
}
