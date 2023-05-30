using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

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

            using (var db = new DataPKEntities())
            {
                var select = from s in db.BENHNHANs select s;
                foreach (var person in select)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListPatient);
                    row.Cells[dGVListPatient.Columns["LastName"].Index].Value = person.HoTen;
                    row.Cells[dGVListPatient.Columns["Sex"].Index].Value = person.GioiTinh;
                    row.Cells[dGVListPatient.Columns["Birth"].Index].Value = person.NamSinh.Value.ToString();
                    row.Cells[dGVListPatient.Columns["Address"].Index].Value = person.DiaChi;

                    dGVListPatient.Rows.Add(row);
                }

            }
        }

        private void dGVListPatient_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewCell indexCell = dGVListPatient.Rows[e.RowIndex].Cells["Index"];

            // Update the index value for the current row
            indexCell.Value = (e.RowIndex + 1).ToString();
        }
    }
}
