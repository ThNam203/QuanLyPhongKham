﻿using DoAn.NewFolder1;
using System;
using System.Windows.Forms;

namespace DoAn.Forms.SmallForms
{
    public partial class FormPatientDetail : Form
    {
        public Patient PatientData { get; private set; }
        public FormPatientDetail()
        {
            InitializeComponent();
        }
        public FormPatientDetail(Patient patient)
        {
            InitializeComponent();
            PatientData = patient;
            if (PatientData != null)
            {
                txtName.Text = PatientData.Name;
                txtSex.Text = PatientData.Sex;
                txtAddress.Text = PatientData.Address;
                dpDate.Value = PatientData.Birth;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Patient patientData = new Patient();
            patientData.Name = txtName.Text;
            patientData.Sex = txtSex.Text;
            patientData.Birth = dpDate.Value;
            patientData.Address = txtAddress.Text;
            PatientData = patientData;
            this.Close();

        }
    }
}
