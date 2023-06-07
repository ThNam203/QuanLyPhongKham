using LiveCharts; //Core of the library
using LiveCharts.Wpf;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;

namespace DoAn.Forms
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            myChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Doanh thu",
                    Values = GetMonthlyRevenueValues(DateTime.Now.Year)
                }
            };

            myChart.AxisX.Add(new Axis
            {
                Labels = new[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" },
                Separator = new Separator { Step = 1 },
                Foreground = new SolidColorBrush(Colors.Black)//This will make the label color black
            });
            myChart.AxisY.Add(new Axis
            {
                LabelFormatter = value => (value / 1000000).ToString("0.# Triệu"),
                Foreground = new SolidColorBrush(Colors.Black)//This will make the label color black
            });
            myChart.LegendLocation = LegendLocation.Right;

            using (var db = new DataPKEntities())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);
                var countPhieuKham = db.PHIEUKHAMs.Count(p => p.NgayKham >= startDate && p.NgayKham <= endDate);
                label2.Text = countPhieuKham.ToString();

                var countBenhNhan = db.PHIEUKHAMs
                    .Where(p => p.NgayKham >= startDate && p.NgayKham <= endDate)
                    .Select(p => p.MaBenhNhan)
                    .Distinct()
                    .Count();
                label3.Text = countBenhNhan.ToString();
                var doanhThu = db.HOADONs
                    .Where(h => h.NgayKham >= startDate && h.NgayKham <= endDate)
                    .Sum(h => h.TienKham + h.TienThuoc) / 1000000m; // Chia cho 1 triệu để có đơn vị triệu

                label5.Text = $"{doanhThu:F2}";
            }
        }
        private ChartValues<int> GetMonthlyRevenueValues(int year)
        {
            using (var db = new DataPKEntities())
            {
                var monthlyRevenues = new ChartValues<int>();

                for (int month = 1; month <= 12; month++)
                {
                    DateTime startDate = new DateTime(year, month, 1);
                    DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                    var monthlyRevenue = db.HOADONs
                        .Where(h => h.NgayKham >= startDate && h.NgayKham <= endDate)
                        .Sum(h => h.TienKham + h.TienThuoc);
                    if (monthlyRevenue == null)
                    {
                        monthlyRevenue = 0;
                    }
                    monthlyRevenues.Add((int)monthlyRevenue);
                }

                return monthlyRevenues;
            }
        }
    }
}
