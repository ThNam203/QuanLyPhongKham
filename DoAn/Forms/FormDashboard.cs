using LiveCharts; //Core of the library
using LiveCharts.Wpf;
using System;
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
                    Values = new ChartValues<decimal> { 15000000000, 18000000000000, 22000000000, 19000000000, 250000000000, 300000000000, 35000000000, 40000000000, 4500000000, 50000000000, 550000000, 60000000000 }
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
        }
    }
}
