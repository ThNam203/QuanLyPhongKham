using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormMakeListExamine : Form
    {
        public class Medicine
        {
            public string MedicineName { get; set; }
            public string Unit { get; set; }
            public string Quantity { get; set; }
            public string Use { get; set; }
        }
        List<Medicine> medicine = new List<Medicine> {
                new Medicine {MedicineName="Paracetamol",Unit="Viên",Quantity="1",Use="Uống"},
                new Medicine {MedicineName="Paracetamol",Unit="Viên",Quantity="1",Use="Uống"},
                new Medicine {MedicineName="Paracetamol",Unit="Viên",Quantity="1",Use="Uống"},
                new Medicine {MedicineName="Paracetamol",Unit="Viên",Quantity="1",Use="Uống"},
                new Medicine {MedicineName="Paracetamol",Unit="Viên",Quantity="1",Use="Uống"},
                new Medicine {MedicineName="Paracetamol",Unit="Viên",Quantity="1",Use="Uống"},
                new Medicine {MedicineName = "Paracetamol", Unit = "Viên", Quantity = "1", Use = "Uống"},
                new Medicine {MedicineName = "Paracetamol", Unit = "Viên", Quantity = "1", Use = "Uống"}
            };
        public FormMakeListExamine()
        {
            InitializeComponent();
            InitializeDataGridView();

        }
        private void InitializeDataGridView()
        {


            foreach (Medicine med in medicine)
            {
                DataGridViewComboBoxCell cell1 = new DataGridViewComboBoxCell();
                cell1.Items.AddRange("Viên", "Hộp");
                DataGridViewComboBoxCell cell2 = new DataGridViewComboBoxCell();
                cell2.Items.AddRange("Uống", "Dán");


                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dGVListMedicine);
                row.Cells[dGVListMedicine.Columns["MedicineName"].Index].Value = med.MedicineName;
                row.Cells[dGVListMedicine.Columns["Unit"].Index] = cell1;
                row.Cells[dGVListMedicine.Columns["Quantity"].Index].Value = med.Quantity;
                row.Cells[dGVListMedicine.Columns["Use"].Index] = cell2;
                dGVListMedicine.Rows.Add(row);
            }
        }

        private void dGVListMedicine_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewCell indexCell = dGVListMedicine.Rows[e.RowIndex].Cells["Index"];

            // Update the index value for the current row
            indexCell.Value = (e.RowIndex + 1).ToString();
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            // Clear the existing rows
            dGVListMedicine.Rows.Clear();

            // Repopulate the DataGridView with the initial data
            foreach (Medicine med in medicine)
            {
                DataGridViewComboBoxCell cell1 = new DataGridViewComboBoxCell();
                cell1.Items.AddRange("Viên", "Hộp");
                DataGridViewComboBoxCell cell2 = new DataGridViewComboBoxCell();
                cell2.Items.AddRange("Uống", "Dán");

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dGVListMedicine);
                row.Cells[dGVListMedicine.Columns["MedicineName"].Index].Value = med.MedicineName;
                row.Cells[dGVListMedicine.Columns["Unit"].Index] = cell1;
                row.Cells[dGVListMedicine.Columns["Quantity"].Index].Value = med.Quantity;
                row.Cells[dGVListMedicine.Columns["Use"].Index] = cell2;
                dGVListMedicine.Rows.Add(row);
            }
        }
    }
}
