using DoAn.Forms.SmallForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormMakeInvoice : Form
    {

        public FormMakeInvoice()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        public void InitializeDataGridView()
        {
            dGVListMedicalBill.Rows.Clear();
            dGVListMedicalBill.ReadOnly = true;

            DateTime selectedDate = dpDate.Value.Date;
            using (var db = new DataPKEntities())
            {
                var tienkham = (from s in db.THAMSOes
                                select s.TienKham).FirstOrDefault();

                var select = from s in db.PHIEUKHAMs
                             where s.NgayKham.Value.Year == selectedDate.Year
                                && s.NgayKham.Value.Month == selectedDate.Month
                                && s.NgayKham.Value.Day == selectedDate.Day
                             select s;
                foreach (var s in select)
                {
                    var total = db.CHITIETPHIEUKHAMs
                        .Where(ctpk => ctpk.MaPhieuKham == s.MaPhieuKham)
                        .Join(db.CHITIETTHUOCs, ctpk => ctpk.MaCTThuoc, ct => ct.MaCTThuoc,
                        (ctpk, ct) => new { ctpk, ct })
                        .Sum(x => x.ct.DonGia * x.ctpk.SoLuong);
                    bool isPaid = db.HOADONs.Any(h => h.MaPhieuKham == s.MaPhieuKham);
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListMedicalBill);
                    row.Cells[dGVListMedicalBill.Columns["Index"].Index].Value = s.MaPhieuKham;
                    row.Cells[dGVListMedicalBill.Columns["PatientName"].Index].Value = s.BENHNHAN.HoTen;
                    row.Cells[dGVListMedicalBill.Columns["Disease"].Index].Value = s.TrieuChung;
                    row.Cells[dGVListMedicalBill.Columns["Total"].Index].Value = tienkham + total;

                    if (row.Cells[dGVListMedicalBill.Columns["Total"].Index].Value == null)
                    {
                        row.Cells[dGVListMedicalBill.Columns["Total"].Index].Value = tienkham;
                    }
                    row.Cells[dGVListMedicalBill.Columns["IsPaid"].Index].Value = isPaid;
                    dGVListMedicalBill.Rows.Add(row);
                }
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtName.Text.Trim();
            DateTime selectedDate = dpDate.Value.Date;
            // Clear previous search results
            dGVListMedicalBill.Rows.Clear();

            using (var db = new DataPKEntities())
            {
                var tienkham = (from s in db.THAMSOes
                                select s.TienKham).FirstOrDefault();

                var select = from s in db.PHIEUKHAMs
                             where s.BENHNHAN.HoTen.Contains(searchText)
                                && s.NgayKham.Value.Year == selectedDate.Year
                                && s.NgayKham.Value.Month == selectedDate.Month
                                && s.NgayKham.Value.Day == selectedDate.Day// Filter by patient name
                             select s;

                foreach (var s in select)
                {
                    var total = db.CHITIETPHIEUKHAMs
                        .Where(ctpk => ctpk.MaPhieuKham == s.MaPhieuKham)
                        .Join(db.CHITIETTHUOCs, ctpk => ctpk.MaCTThuoc, ct => ct.MaCTThuoc,
                        (ctpk, ct) => new { ctpk, ct })
                        .Sum(x => x.ct.DonGia * x.ctpk.SoLuong);

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListMedicalBill);
                    row.Cells[dGVListMedicalBill.Columns["Index"].Index].Value = s.MaPhieuKham;
                    row.Cells[dGVListMedicalBill.Columns["PatientName"].Index].Value = s.BENHNHAN.HoTen;
                    row.Cells[dGVListMedicalBill.Columns["Disease"].Index].Value = s.TrieuChung;
                    row.Cells[dGVListMedicalBill.Columns["Total"].Index].Value = tienkham + total;

                    if (row.Cells[dGVListMedicalBill.Columns["Total"].Index].Value == null)
                    {
                        row.Cells[dGVListMedicalBill.Columns["Total"].Index].Value = tienkham;
                    }

                    row.Cells[dGVListMedicalBill.Columns["IsPaid"].Index].Value = false;
                    dGVListMedicalBill.Rows.Add(row);
                }
            }
        }
        private void dpDate_ValueChanged(object sender, EventArgs e)
        {
            txtName.Clear();
            InitializeDataGridView();
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
                int selectedId = (int)selectedRow.Cells["Index"].Value;


                // Open a new form and pass the ID
                FormBill invoiceDetailsForm = new FormBill(selectedId, false);
                invoiceDetailsForm.FormClosed += InvoiceDetailsForm_FormClosed;
                invoiceDetailsForm.Show();
            }
            //Initialize the data again

        }

        private void InvoiceDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitializeDataGridView();
        }
    }
}
