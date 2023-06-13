﻿using DoAn.Forms.SmallForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormListPatient : Form
    {
        public FormListPatient()
        {
            InitializeComponent();
            dGVListPatient.ReadOnly = true;

            InitializeData();
        }
        private void InitializeData()
        {
            DateTime selectedDate = dpDate.Value.Date;
            using (var db = new DataPKEntities())
            {
                var select = from s in db.PHIEUKHAMs
                             where s.NgayKham.Value.Year == selectedDate.Year
                                && s.NgayKham.Value.Month == selectedDate.Month
                                && s.NgayKham.Value.Day == selectedDate.Day
                             select s;
                dGVListPatient.Rows.Clear();
                foreach (var person in select)
                {
                    if (person.TrieuChung == null)
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
                    if (person.TrieuChung == null)
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

        private void btnAddPatient_Click(object sender, EventArgs e)
        {

            FormPatientDetail formPatientDetail = new FormPatientDetail(false);
            formPatientDetail.FormClosed += FormPatientDetail_FormClosed;
            formPatientDetail.ShowDialog();
        }
        private void FormPatientDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitializeData();
        }

        private void dGVListPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGVListPatient.Rows[e.RowIndex];
                int index = int.Parse(row.Cells[dGVListPatient.Columns["Index"].Index].Value.ToString());
                FormPatientDetail formPatientDetail = new FormPatientDetail(index);
                formPatientDetail.FormClosed += FormPatientDetail_FormClosed;
                formPatientDetail.ShowDialog();
            }
        }


    }
}
