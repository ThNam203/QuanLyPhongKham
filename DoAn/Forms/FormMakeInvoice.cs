using DoAn.Forms.SmallForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormMakeInvoice : Form
    {
        public class MedicalBill
        {
            public string Id { get; set; }
            public string PatientName { get; set; }
            public string Disease { get; set; }

            public string Total { get; set; }
            public Boolean isPaid { get; set; }
        }
        List<MedicalBill> listBill = new List<MedicalBill>
        {
            new MedicalBill {Id="1",PatientName="Nguyễn Văn A",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="2",PatientName="Nguyễn Văn B",Disease="Sốt",Total="100000",isPaid=true},
            new MedicalBill {Id="3",PatientName="Nguyễn Văn C",Disease="Sốt",Total="100000",isPaid=true},
            new MedicalBill {Id="4",PatientName="Nguyễn Văn D",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="5",PatientName="Nguyễn Văn E",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="6",PatientName="Nguyễn Văn F",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="7",PatientName="Nguyễn Văn G",Disease="Sốt",Total="100000",isPaid=true},
            new MedicalBill {Id="8",PatientName="Nguyễn Văn H",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="9",PatientName="Nguyễn Văn I",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="10",PatientName="Nguyễn Văn K",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="11",PatientName="Nguyễn Văn L",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="12",PatientName="Nguyễn Văn M",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="13",PatientName="Nguyễn Văn N",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="14",PatientName="Nguyễn Văn O",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="15",PatientName="Nguyễn Văn P",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="16",PatientName="Nguyễn Văn Q",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="17",PatientName="Nguyễn Văn R",Disease="Sốt",Total="100000",isPaid=false},
            new MedicalBill {Id="18",PatientName="Nguyễn Văn S",Disease="Sốt",Total="100000",isPaid=false},
        };
        public FormMakeInvoice()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        public void InitializeDataGridView()
        {

            foreach (MedicalBill item in listBill)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dGVListMedicalBill);
                row.Cells[dGVListMedicalBill.Columns["Index"].Index].Value = item.Id;
                row.Cells[dGVListMedicalBill.Columns["PatientName"].Index].Value = item.PatientName;
                row.Cells[dGVListMedicalBill.Columns["Disease"].Index].Value = item.Disease;
                row.Cells[dGVListMedicalBill.Columns["Total"].Index].Value = item.Total;
                row.Cells[dGVListMedicalBill.Columns["isPaid"].Index].Value = item.isPaid;

                dGVListMedicalBill.Rows.Add(row);
            }
            // Autosize the columns.
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string searchName = txtName.Text.Trim();

            // Clear the DataGridView
            dGVListMedicalBill.Rows.Clear();

            // Search for matching patients and add them to the DataGridView
            foreach (MedicalBill item in listBill)
            {
                if (item.PatientName.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListMedicalBill);
                    row.Cells[dGVListMedicalBill.Columns["Index"].Index].Value = item.Id;
                    row.Cells[dGVListMedicalBill.Columns["PatientName"].Index].Value = item.PatientName;
                    row.Cells[dGVListMedicalBill.Columns["Disease"].Index].Value = item.Disease;
                    row.Cells[dGVListMedicalBill.Columns["Total"].Index].Value = item.Total;
                    row.Cells[dGVListMedicalBill.Columns["isPaid"].Index].Value = item.isPaid;

                    dGVListMedicalBill.Rows.Add(row);
                }
            }
        }

        private void dGVListMedicalBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dGVListMedicalBill.Rows[e.RowIndex];
                if (selectedRow.Cells["Index"].Value == null)
                {
                    MessageBox.Show("Vui lòng chọn phiếu khám");
                    return;
                }
                // Get the ID value from the selected row
                string selectedId = selectedRow.Cells["Index"].Value.ToString();


                // Open a new form and pass the ID
                FormBill invoiceDetailsForm = new FormBill(selectedId);
                invoiceDetailsForm.Show();
            }
        }
    }
}
