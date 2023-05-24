using System;
using System.Collections.Generic;
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
            List<Patient> people = new List<Patient>
            {
                new Patient {  LastName = "John Doe", Sex = "Male", Birth = new DateTime(1990, 5, 15).ToString("MM/dd/yyyy"), Address = "123 Main St" },
                new Patient {  LastName = "Jane Smith", Sex = "Female", Birth = new DateTime(1988, 8, 22).ToString("MM/dd/yyyy"), Address = "456 Elm St" },
                new Patient { LastName = "Bob Johnson", Sex = "Male", Birth = new DateTime(1995, 3, 10).ToString("MM/dd/yyyy"), Address = "789 Oak St" },
                new Patient {  LastName = "John Doe", Sex = "Male", Birth = new DateTime(1990, 5, 15).ToString("MM/dd/yyyy"), Address = "123 Main St" },
                new Patient {  LastName = "Jane Smith", Sex = "Female", Birth = new DateTime(1988, 8, 22).ToString("MM/dd/yyyy"), Address = "456 Elm St" },
                new Patient { LastName = "Bob Johnson", Sex = "Male", Birth = new DateTime(1995, 3, 10).ToString("MM/dd/yyyy"), Address = "789 Oak St" },
                new Patient {  LastName = "John Doe", Sex = "Male", Birth = new DateTime(1990, 5, 15).ToString("MM/dd/yyyy"), Address = "123 Main St" },
                new Patient {  LastName = "Jane Smith", Sex = "Female", Birth = new DateTime(1988, 8, 22).ToString("MM/dd/yyyy"), Address = "456 Elm St" },
                new Patient { LastName = "Bob Johnson", Sex = "Male", Birth = new DateTime(1995, 3, 10).ToString("MM/dd/yyyy"), Address = "789 Oak St" },
                new Patient {  LastName = "John Doe", Sex = "Male", Birth = new DateTime(1990, 5, 15).ToString("MM/dd/yyyy"), Address = "123 Main St" },
                new Patient {  LastName = "Jane Smith", Sex = "Female", Birth = new DateTime(1988, 8, 22).ToString("MM/dd/yyyy"), Address = "456 Elm St" },
                new Patient { LastName = "Bob Johnson", Sex = "Male", Birth = new DateTime(1995, 3, 10).ToString("MM/dd/yyyy"), Address = "789 Oak St" },
                new Patient {  LastName = "John Doe", Sex = "Male", Birth = new DateTime(1990, 5, 15).ToString("MM/dd/yyyy"), Address = "123 Main St" },
                new Patient {  LastName = "Jane Smith", Sex = "Female", Birth = new DateTime(1988, 8, 22).ToString("MM/dd/yyyy"), Address = "456 Elm St" },
                new Patient { LastName = "Bob Johnson", Sex = "Male", Birth = new DateTime(1995, 3, 10).ToString("MM/dd/yyyy"), Address = "789 Oak St" },
                new Patient {  LastName = "John Doe", Sex = "Male", Birth = new DateTime(1990, 5, 15).ToString("MM/dd/yyyy"), Address = "123 Main St" },
                new Patient {  LastName = "Jane Smith", Sex = "Female", Birth = new DateTime(1988, 8, 22).ToString("MM/dd/yyyy"), Address = "456 Elm St" },
                new Patient { LastName = "Bob Johnson", Sex = "Male", Birth = new DateTime(1995, 3, 10).ToString("MM/dd/yyyy"), Address = "789 Oak St" },
                new Patient {  LastName = "John Doe", Sex = "Male", Birth = new DateTime(1990, 5, 15).ToString("MM/dd/yyyy"), Address = "123 Main St" },
                new Patient {  LastName = "Jane Smith", Sex = "Female", Birth = new DateTime(1988, 8, 22).ToString("MM/dd/yyyy"), Address = "456 Elm St" },
                new Patient { LastName = "Bob Johnson", Sex = "Male", Birth = new DateTime(1995, 3, 10).ToString("MM/dd/yyyy"), Address = "789 Oak St" },
                new Patient {  LastName = "John Doe", Sex = "Male", Birth = new DateTime(1990, 5, 15).ToString("MM/dd/yyyy"), Address = "123 Main St" },
                new Patient {  LastName = "Jane Smith", Sex = "Female", Birth = new DateTime(1988, 8, 22).ToString("MM/dd/yyyy"), Address = "456 Elm St" },
                new Patient { LastName = "Bob Johnson", Sex = "Male", Birth = new DateTime(1995, 3, 10).ToString("MM/dd/yyyy"), Address = "789 Oak St" }
            };
            dGVListPatient.ReadOnly = true;
            foreach (Patient person in people)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dGVListPatient);

                row.Cells[dGVListPatient.Columns["LastName"].Index].Value = person.LastName;
                row.Cells[dGVListPatient.Columns["Sex"].Index].Value = person.Sex;
                row.Cells[dGVListPatient.Columns["Birth"].Index].Value = person.Birth;
                row.Cells[dGVListPatient.Columns["Address"].Index].Value = person.Address;

                dGVListPatient.Rows.Add(row);
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
