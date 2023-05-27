using System;
using System.Windows.Forms;

namespace DoAn.Forms.SmallForms
{
    public partial class FormBill : Form
    {
        private string id;
        public FormBill()
        {
            InitializeComponent();
        }
        public FormBill(string id)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
            this.id = id;
            txtName.Text = id;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
