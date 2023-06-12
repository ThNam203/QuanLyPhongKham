using DoAn.Forms.SmallForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormListInvoice : Form
    {
        public FormListInvoice()
        {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            dGVListPatient.Rows.Clear();
            dGVListPatient.ReadOnly = true;

            DateTime selectedDate = dpDate.Value.Date;
            using (var db = new DataPKEntities())
            {
                var select = from s in db.HOADONs
                             where s.NgayKham.Value.Year == selectedDate.Year
                                && s.NgayKham.Value.Month == selectedDate.Month
                                && s.NgayKham.Value.Day == selectedDate.Day
                             select s;
                foreach (var s in select)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListPatient);
                    row.Cells[dGVListPatient.Columns["Index"].Index].Value = s.MaPhieuKham;
                    row.Cells[dGVListPatient.Columns["PatientName"].Index].Value = s.PHIEUKHAM.BENHNHAN.HoTen;
                    row.Cells[dGVListPatient.Columns["Disease"].Index].Value = s.PHIEUKHAM.LOAIBENH.TenLoaiBenh;
                    row.Cells[dGVListPatient.Columns["DateExamine"].Index].Value = s.NgayKham.Value.ToString("dd/MM/yyyy");
                    row.Cells[dGVListPatient.Columns["Total"].Index].Value = s.TienKham + s.TienThuoc;
                    dGVListPatient.Rows.Add(row);
                }
            }

        }

        private void dpDate_ValueChanged(object sender, EventArgs e)
        {
            txtName.Clear();
            InitializeData();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtName.Text.Trim();
            DateTime selectedDate = dpDate.Value.Date;
            // Clear previous search results
            dGVListPatient.Rows.Clear();

            using (var db = new DataPKEntities())
            {
                var select = from s in db.HOADONs
                             where s.NgayKham.Value.Year == selectedDate.Year
                                && s.NgayKham.Value.Month == selectedDate.Month
                                && s.NgayKham.Value.Day == selectedDate.Day
                                && s.PHIEUKHAM.BENHNHAN.HoTen.Contains(searchText)
                             select s;
                foreach (var s in select)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListPatient);
                    row.Cells[dGVListPatient.Columns["Index"].Index].Value = s.MaPhieuKham;
                    row.Cells[dGVListPatient.Columns["PatientName"].Index].Value = s.PHIEUKHAM.BENHNHAN.HoTen;
                    row.Cells[dGVListPatient.Columns["Disease"].Index].Value = s.PHIEUKHAM.LOAIBENH.TenLoaiBenh;
                    row.Cells[dGVListPatient.Columns["DateExamine"].Index].Value = s.NgayKham.Value.ToString("dd/MM/yyyy");
                    row.Cells[dGVListPatient.Columns["Total"].Index].Value = s.TienKham + s.TienThuoc;
                    dGVListPatient.Rows.Add(row);
                }
            }
        }

        private void dGVListPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dGVListPatient.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    int selectedId = (int)selectedRow.Cells[dGVListPatient.Columns["Index"].Index].Value;
                    FormBill formInvoice = new FormBill(selectedId, true);
                    formInvoice.ShowDialog();
                }
            }
        }
    }
}
