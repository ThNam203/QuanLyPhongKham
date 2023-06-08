using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormListGetMedicine : Form
    {
        public FormListGetMedicine()
        {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            dGVListGetMedicine.ReadOnly = true;
            dGVListGetMedicine.Rows.Clear();
            using (var db = new DataPKEntities())
            {
                var select = from s in db.PHIEUNHAPTHUOCs
                             select s;
                foreach (var phieuNhap in select)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListGetMedicine);
                    row.Cells[dGVListGetMedicine.Columns["Index"].Index].Value = phieuNhap.MaPhieuNhapThuoc;
                    row.Cells[dGVListGetMedicine.Columns["ProviderName"].Index].Value = phieuNhap.NhaCungCap;
                    row.Cells[dGVListGetMedicine.Columns["DateGet"].Index].Value = phieuNhap.NgayNhap.Value.ToString("dd'/'MM'/'yyyy");
                    row.Cells[dGVListGetMedicine.Columns["Total"].Index].Value = phieuNhap.TongTien;
                    dGVListGetMedicine.Rows.Add(row);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string providerName = txtName.Text;
            using (var db = new DataPKEntities())
            {
                var select = from s in db.PHIEUNHAPTHUOCs
                             where s.NhaCungCap.Contains(providerName)
                             select s;
                dGVListGetMedicine.Rows.Clear(); // Clear the existing rows in the DataGridView
                foreach (var phieuNhap in select)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListGetMedicine);
                    row.Cells[dGVListGetMedicine.Columns["Index"].Index].Value = phieuNhap.MaPhieuNhapThuoc;
                    row.Cells[dGVListGetMedicine.Columns["ProviderName"].Index].Value = phieuNhap.NhaCungCap;
                    row.Cells[dGVListGetMedicine.Columns["DateGet"].Index].Value = phieuNhap.NgayNhap.Value.ToString("dd'/'MM'/'yyyy");
                    row.Cells[dGVListGetMedicine.Columns["Total"].Index].Value = phieuNhap.TongTien;
                    dGVListGetMedicine.Rows.Add(row);
                }
            }
        }

        private void dpDate_ValueChanged(object sender, EventArgs e)
        {
            txtName.Clear();
            InitializeData();
        }
    }
}
