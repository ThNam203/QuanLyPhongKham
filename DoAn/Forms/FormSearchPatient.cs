using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormSearchPatient : Form
    {
        private bool isDateChange = false;

        public FormSearchPatient()
        {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            dGVListPatient.ReadOnly = true;
            dGVListPatient.Rows.Clear();
            using (var db = new DataPKEntities())
            {
                //var select = (from s in db.PHIEUKHAMs
                //              group s by s.MaBenhNhan into g
                //              select g.FirstOrDefault()).ToList();
                var select = (from s in db.PHIEUKHAMs select s).ToList();

                int stt = 0;
                foreach (var person in select)
                {
                    stt++;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListPatient);
                    row.Cells[dGVListPatient.Columns["Index"].Index].Value = stt;
                    row.Cells[dGVListPatient.Columns["LastName"].Index].Value = person.BENHNHAN.HoTen;
                    row.Cells[dGVListPatient.Columns["Disease"].Index].Value = person.LOAIBENH.TenLoaiBenh;
                    row.Cells[dGVListPatient.Columns["Symptom"].Index].Value = person.TrieuChung;
                    row.Cells[dGVListPatient.Columns["DateExamine"].Index].Value = person.NgayKham.Value.ToString("dd'/'MM'/'yyyy");
                    // person.NgayKham.Value.ToString("dd'/'MM'/'yyyy");
                    dGVListPatient.Rows.Add(row);
                }

                var loaibenh = from s in db.LOAIBENHs
                               select s;
                foreach (var item in loaibenh)
                {
                    cbbLBenh.Items.Add(item.TenLoaiBenh);
                }
                cbbLBenh.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbLBenh.AutoCompleteSource = AutoCompleteSource.ListItems;
            }


        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        private void anyChanged()
        {
            string lastName = txtName.Text;
            string trieuchung = txtTrieuChung.Text;
            DateTime selectedDate = dpDate.Value.Date;
            string loaibenh = cbbLBenh.SelectedItem.ToString();
            using (var db = new DataPKEntities())
            {
                var select = (from s in db.PHIEUKHAMs
                              where s.BENHNHAN.HoTen.Contains(lastName)
                              && s.TrieuChung.Contains(trieuchung)
                              && s.LOAIBENH.TenLoaiBenh.Contains(loaibenh)
                              select s).ToList();

                dGVListPatient.Rows.Clear(); // Clear the existing rows in the DataGridView

                int stt = 0;
                foreach (var person in select)
                {
                    if (isDateChange)
                    {
                        if (!(person.NgayKham.Value.Year == selectedDate.Year
                              && person.NgayKham.Value.Month == selectedDate.Month
                              && person.NgayKham.Value.Day == selectedDate.Day))
                            continue;
                    }
                    stt++;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListPatient);
                    row.Cells[dGVListPatient.Columns["Index"].Index].Value = stt;
                    row.Cells[dGVListPatient.Columns["LastName"].Index].Value = person.BENHNHAN.HoTen;
                    row.Cells[dGVListPatient.Columns["Disease"].Index].Value = person.LOAIBENH.TenLoaiBenh;
                    row.Cells[dGVListPatient.Columns["Symptom"].Index].Value = person.TrieuChung;
                    row.Cells[dGVListPatient.Columns["DateExamine"].Index].Value = person.NgayKham.Value.ToString("dd'/'MM'/'yyyy");
                    // person.NgayKham.Value.ToString("dd'/'MM'/'yyyy");
                    dGVListPatient.Rows.Add(row);
                }
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            anyChanged();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {

            InitializeData();
        }

        private void dpDate_ValueChanged(object sender, EventArgs e)
        {
            isDateChange = true;
            anyChanged();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtName.Text = null;
            isDateChange = false;
            dpDate.Value = DateTime.Now;
            cbbLBenh.Items.Clear();
            cbbLBenh.Texts = null;
            InitializeData();
        }

        private void txtTrieuChung_TextChanged(object sender, EventArgs e)
        {
            anyChanged();
        }

        private void cbbLBenh_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            anyChanged();
        }
    }
}

