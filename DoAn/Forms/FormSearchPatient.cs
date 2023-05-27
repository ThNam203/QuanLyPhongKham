using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormSearchPatient : Form
    {
        public class Patient
        {
            public int Index { get; set; }
            public string LastName { get; set; }
            public string Sex { get; set; }
            public string Birth { get; set; }
            public string Address { get; set; }
        }
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
        List<String> typeDisease = new List<string>
        {
            "Bệnh lý tim mạch",
            "Bệnh lý hô hấp",
            "Bệnh lý tiêu hóa",
        };
        public FormSearchPatient()
        {
            InitializeComponent();


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
            cbbTypeDisease.Items.Clear();
            cbbTypeDisease.Items.AddRange(typeDisease.ToArray());
            cbbTypeDisease.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void dGVListPatient_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewCell indexCell = dGVListPatient.Rows[e.RowIndex].Cells["Index"];

            // Update the index value for the current row
            indexCell.Value = (e.RowIndex + 1).ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtName.Text;
            if (!string.IsNullOrEmpty(searchName))
            {
                // Clear existing search results
                dGVListPatient.Rows.Clear();

                // Perform the search
                List<Patient> searchResults = GetPatientsByName(searchName);

                // Display the search results in the DataGridView
                foreach (Patient person in searchResults)
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
        }

        // Helper method to search for patients by name

        private List<Patient> GetPatientsByName(string name)
        {
            List<Patient> searchResults = new List<Patient>();
            foreach (Patient person in people)
            {
                if (person.LastName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    searchResults.Add(person);
                }
            }
            return searchResults;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string searchName = txtName.Text;
            if (!string.IsNullOrEmpty(searchName))
            {
                // Clear existing search results
                dGVListPatient.Rows.Clear();

                // Perform the search
                List<Patient> searchResults = GetPatientsByName(searchName);

                // Display the search results in the DataGridView
                foreach (Patient person in searchResults)
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
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear the search TextBox
            txtName.Text = string.Empty;
            //DateTime date = DateTime.ParseExact(dpDate.Text.ToString(), "dddd, MMMM dd, yyyy", CultureInfo.InvariantCulture);

            //// Format the date to the desired format
            //string formattedDate = date.ToString("dd/MM/yyyy");

            //// The formatted date will be "24/05/2023"
            //txtName.Text = formattedDate;

            // Clear existing search results
            dGVListPatient.Rows.Clear();

            // Display all patients in the DataGridView
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

        private void ConvertDate()
        {
            DateTime date = DateTime.ParseExact(dpDate.Text.ToString(), "dddd, MMMM dd, yyyy", CultureInfo.InvariantCulture);

            // Format the date to the desired format
            string formattedDate = date.ToString("dd/MM/yyyy");

            // The formatted date will be "24/05/2023"
            txtName.Text = formattedDate;
        }

    }
}
