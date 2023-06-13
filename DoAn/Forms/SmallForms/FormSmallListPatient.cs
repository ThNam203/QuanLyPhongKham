using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms.SmallForms
{
    public partial class FormSmallListPatient : Form
    {
        public int PatientId = -1;
        public DateTime date = DateTime.Now;
        public FormSmallListPatient(DateTime date)
        {
            InitializeComponent();
            dGVListPatient.ReadOnly = true;
            dGVListPatient.MultiSelect = false;
            this.date = date;
            InitializeData();
        }
        private void InitializeData()
        {
            DateTime selectedDate = date;
            using (var db = new DataPKEntities())
            {
                var select = from s in db.PHIEUKHAMs
                             where s.NgayKham.Value.Year == selectedDate.Year
                                && s.NgayKham.Value.Month == selectedDate.Month
                                && s.NgayKham.Value.Day == selectedDate.Day
                             select s;
                dGVListPatient.Rows.Clear();
                foreach (var person in select)
                {
                    if (person.TrieuChung == null)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dGVListPatient);
                        row.Cells[dGVListPatient.Columns["Index"].Index].Value = person.MaBenhNhan;
                        row.Cells[dGVListPatient.Columns["LastName"].Index].Value = person.BENHNHAN.HoTen;
                        row.Cells[dGVListPatient.Columns["Sex"].Index].Value = person.BENHNHAN.GioiTinh;
                        row.Cells[dGVListPatient.Columns["Birth"].Index].Value = person.BENHNHAN.NamSinh.Value.ToString("dd'/'MM'/'yyyy");
                        row.Cells[dGVListPatient.Columns["Address"].Index].Value = person.BENHNHAN.DiaChi;
                        // person.NgayKham.Value.ToString("dd'/'MM'/'yyyy");
                        dGVListPatient.Rows.Add(row);
                    }
                }

            }
        }

        private void dGVListPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGVListPatient.Rows[e.RowIndex];
                PatientId = (int)row.Cells[dGVListPatient.Columns["Index"].Index].Value;
            }
            this.Close();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (dGVListPatient.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dGVListPatient.SelectedCells[0];
                DataGridViewRow row = selectedCell.OwningRow;
                PatientId = Convert.ToInt32(row.Cells["Index"].Value);
            }
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
