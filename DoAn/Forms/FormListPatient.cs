using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormListPatient : Form
    {
        public class Patient
        {
            public int Index { get; set; }
            public string LastName { get; set; }
            public string Sex { get; set; }
            public string Birth { get; set; }
            public string Address { get; set; }
        }
        public FormListPatient()
        {
            InitializeComponent();
            dGVListPatient.ReadOnly = true;

            DateTime selectedDate = dpDate.Value.Date;
            using (var db = new DataPKEntities())
            {
                var select = from s in db.PHIEUKHAMs
                             where s.NgayKham.Value.Year == selectedDate.Year
                                && s.NgayKham.Value.Month == selectedDate.Month
                                && s.NgayKham.Value.Day == selectedDate.Day
                             select s;
                foreach (var person in select)
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
        private void dpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dpDate.Value.Date;

            using (var db = new DataPKEntities())
            {
                var select = from s in db.PHIEUKHAMs
                             where s.NgayKham.Value.Year == selectedDate.Year
                                && s.NgayKham.Value.Month == selectedDate.Month
                                && s.NgayKham.Value.Day == selectedDate.Day
                             select s;

                dGVListPatient.Rows.Clear(); // Clear the existing rows in the DataGridView

                foreach (var person in select)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListPatient);
                    row.Cells[dGVListPatient.Columns["Index"].Index].Value = person.MaBenhNhan;
                    row.Cells[dGVListPatient.Columns["LastName"].Index].Value = person.BENHNHAN.HoTen;
                    row.Cells[dGVListPatient.Columns["Sex"].Index].Value = person.BENHNHAN.GioiTinh;
                    row.Cells[dGVListPatient.Columns["Birth"].Index].Value = person.BENHNHAN.NamSinh.Value.ToString("dd'/'MM'/'yyyy");
                    row.Cells[dGVListPatient.Columns["Address"].Index].Value = person.BENHNHAN.DiaChi;
                    dGVListPatient.Rows.Add(row);
                }
            }
        }

    }
}
