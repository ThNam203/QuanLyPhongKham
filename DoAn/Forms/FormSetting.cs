using System.Linq;
using System.Windows.Forms;
namespace DoAn.Forms
{
    public partial class FormSetting : Form
    {

        public FormSetting()
        {
            InitializeComponent();
            InitializeData();
        }
        public void InitializeData()
        {
            using (var db = new DataPKEntities())
            {
                var select = (from s in db.THAMSOes
                              select s).FirstOrDefault();
                txtNumberMax.Text = select.SoBenhNhanToiDaTrongNgay.ToString();
                txtExamineMoney.Text = select.TienKham.ToString();

                var select2 = from s in db.LOAIBENHs
                              select s;
                foreach (var s in select2)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListDisease);
                    row.Cells[dGVListDisease.Columns["DiseaseId"].Index].Value = s.MaLoaiBenh;
                    row.Cells[dGVListDisease.Columns["DiseaseName"].Index].Value = s.TenLoaiBenh;
                    dGVListDisease.Rows.Add(row);
                }
                var select3 = from s in db.CACHDUNGs
                              select s;
            }
        }

    }
}
