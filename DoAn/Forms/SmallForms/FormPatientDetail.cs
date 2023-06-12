using DoAn.NewFolder1;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms.SmallForms
{
    public partial class FormPatientDetail : Form
    {
        public Patient PatientData { get; private set; }
        public bool isAdd = false;
        public int id;
        public FormPatientDetail()
        {
            InitializeComponent();
        }
        public FormPatientDetail(int id)
        {
            InitializeComponent();
            using (var db = new DataPKEntities())
            {
                var select = (from s in db.BENHNHANs
                              where s.MaBenhNhan == id
                              select s).FirstOrDefault();
                if (select != null)
                {
                    txtName.Text = select.HoTen;
                    txtAddress.Text = select.DiaChi;
                    txtSex.Text = select.GioiTinh;
                    dpDate.Value = select.NamSinh.Value;
                }
            }
            this.id = id;
        }
        public FormPatientDetail(bool abc)
        {
            InitializeComponent();
            isAdd = true;
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
            if (isAdd)
            {
                if (txtName.Text == null || txtName.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên bệnh nhân", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtAddress.Text == null || txtAddress.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtSex.Text == null || txtSex.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập giới tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (dpDate.Value == null)
                {
                    MessageBox.Show("Vui lòng nhập ngày sinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var db = new DataPKEntities())
                {
                    var patient = new BENHNHAN()
                    {
                        HoTen = txtName.Text,
                        DiaChi = txtAddress.Text,
                        GioiTinh = txtSex.Text,
                        NamSinh = dpDate.Value
                    };
                    //search benh nhan co ten trung
                    var select = (from s in db.BENHNHANs
                                  where s.HoTen == patient.HoTen
                                  && s.GioiTinh == patient.GioiTinh
                                  && s.NamSinh.Value.Day == patient.NamSinh.Value.Day
                                    && s.NamSinh.Value.Month == patient.NamSinh.Value.Month
                                    && s.NamSinh.Value.Year == patient.NamSinh.Value.Year
                                  && s.DiaChi == patient.DiaChi
                                  select s).FirstOrDefault();
                    if (select != null)
                    {
                        MessageBox.Show("Bệnh nhân đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    db.BENHNHANs.Add(patient);
                    db.SaveChanges();
                    var phieukham = new PHIEUKHAM()
                    {
                        MaBenhNhan = patient.MaBenhNhan,
                        NgayKham = DateTime.Now,
                    };
                    db.PHIEUKHAMs.Add(phieukham);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();
                }
            }
            else
            {
                using (var db = new DataPKEntities())
                {
                    var select = (from s in db.BENHNHANs
                                  where s.MaBenhNhan == id
                                  select s).FirstOrDefault();
                    //select.NamSinh.Value = dpDate.Value;
                    select.HoTen = txtName.Text;
                    select.DiaChi = txtAddress.Text;
                    select.GioiTinh = txtSex.Text;
                    db.SaveChanges();
                }

            }
            this.Close();
        }
    }
}
