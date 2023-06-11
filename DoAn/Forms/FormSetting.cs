﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace DoAn.Forms
{
    public partial class FormSetting : Form
    {

        public FormSetting()
        {
            InitializeComponent();
            InitializeData();
        }
        public void InitializeData()
        {
            using (var db = new DataPKEntities())
            {
                var select = (from s in db.THAMSOes
                              select s).FirstOrDefault();
                //Lay so benh nhan toi da trong ngay
                txtNumberMax.Text = select.SoBenhNhanToiDaTrongNgay.ToString();
                //Lay tien kham
                txtExamineMoney.Text = select.TienKham.ToString();
                //Lay danh sach loai benh
                var select2 = from s in db.LOAIBENHs
                              select s;
                foreach (var s in select2)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListDisease);
                    row.Cells[dGVListDisease.Columns["DiseaseId"].Index].Value = s.MaLoaiBenh;
                    row.Cells[dGVListDisease.Columns["DiseaseName"].Index].Value = s.TenLoaiBenh;
                    dGVListDisease.Rows.Add(row);
                }
                //Lay danh sach cach dung
                var select3 = from s in db.CACHDUNGs
                              select s;
                foreach (var s in select3)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListUsage);
                    row.Cells[dGVListUsage.Columns["UsageId"].Index].Value = s.MaCachDung;
                    row.Cells[dGVListUsage.Columns["UsageName"].Index].Value = s.TenCachDung;
                    dGVListUsage.Rows.Add(row);
                }
                //Lay danh sach don vi
                var select5 = from s in db.DONVIs
                              select s;
                foreach (var s in select5)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListUnit);
                    row.Cells[dGVListUnit.Columns["UnitId"].Index].Value = s.MaDonVi;
                    row.Cells[dGVListUnit.Columns["UnitName"].Index].Value = s.TenDonVi;
                    dGVListUnit.Rows.Add(row);
                }
                //Lay danh sach thuoc
                var select4 = from s in db.CHITIETTHUOCs
                              select s;
                foreach (var s in select4)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGVListMedicine);
                    row.Cells[dGVListMedicine.Columns["MedicineId"].Index].Value = s.MaCTThuoc;
                    row.Cells[dGVListMedicine.Columns["MedicineName"].Index].Value = s.THUOC.TenThuoc;
                    row.Cells[dGVListMedicine.Columns["MedicineUnit"].Index].Value = s.DONVI.MaDonVi;
                    row.Cells[dGVListMedicine.Columns["MedicinePrice"].Index].Value = s.DonGia;
                    dGVListMedicine.Rows.Add(row);
                }

            }
        }

        private void btnAddDisease_Click(object sender, System.EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dGVListDisease);
            // Set the values for the new row
            // Add the new row to the DataGridView
            dGVListDisease.Rows.Add(row);
        }

        private void btnRemoveDisease_Click(object sender, System.EventArgs e)
        {
            if (dGVListDisease.SelectedCells.Count > 0)
            {
                // Remove the selected rows
                var rowsToRemove = new List<DataGridViewRow>();

                foreach (DataGridViewCell cell in dGVListDisease.SelectedCells)
                {
                    if (cell.RowIndex != -1 && !rowsToRemove.Contains(cell.OwningRow))
                    {
                        rowsToRemove.Add(cell.OwningRow);
                    }
                }

                foreach (DataGridViewRow row in rowsToRemove)
                {
                    if (!row.IsNewRow)
                    {
                        dGVListDisease.Rows.Remove(row);
                    }
                }
            }
        }



        private void btnAddUsage_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dGVListUsage);
            // Set the values for the new row
            // Add the new row to the DataGridView
            dGVListUsage.Rows.Add(row);

        }

        private void btnRemoveUsage_Click(object sender, EventArgs e)
        {
            if (dGVListUsage.SelectedCells.Count > 0)
            {
                // Remove the selected rows
                var rowsToRemove = new List<DataGridViewRow>();

                foreach (DataGridViewCell cell in dGVListUsage.SelectedCells)
                {
                    if (cell.RowIndex != -1 && !rowsToRemove.Contains(cell.OwningRow))
                    {
                        rowsToRemove.Add(cell.OwningRow);
                    }
                }

                foreach (DataGridViewRow row in rowsToRemove)
                {
                    if (!row.IsNewRow)
                    {
                        dGVListUsage.Rows.Remove(row);
                    }
                }
            }
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dGVListMedicine);
            // Set the values for the new row
            // Add the new row to the DataGridView
            dGVListMedicine.Rows.Add(row);
        }
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dGVListUnit);
            dGVListUnit.Rows.Add(row);
        }
        private void btnRemoveUnit_Click(object sender, EventArgs e)
        {
            if (dGVListUnit.SelectedCells.Count > 0)
            {
                // Remove the selected rows
                var rowsToRemove = new List<DataGridViewRow>();

                foreach (DataGridViewCell cell in dGVListUnit.SelectedCells)
                {
                    if (cell.RowIndex != -1 && !rowsToRemove.Contains(cell.OwningRow))
                    {
                        rowsToRemove.Add(cell.OwningRow);
                    }
                }

                foreach (DataGridViewRow row in rowsToRemove)
                {
                    if (!row.IsNewRow)
                    {
                        dGVListUnit.Rows.Remove(row);
                    }
                }
            }
        }
        private void btnRemoveMedicine_Click(object sender, EventArgs e)
        {
            if (dGVListMedicine.SelectedCells.Count > 0)
            {
                // Remove the selected rows
                var rowsToRemove = new List<DataGridViewRow>();

                foreach (DataGridViewCell cell in dGVListMedicine.SelectedCells)
                {
                    if (cell.RowIndex != -1 && !rowsToRemove.Contains(cell.OwningRow))
                    {
                        rowsToRemove.Add(cell.OwningRow);
                    }
                }

                foreach (DataGridViewRow row in rowsToRemove)
                {
                    if (!row.IsNewRow)
                    {
                        dGVListMedicine.Rows.Remove(row);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new DataPKEntities())
            {
                // Update the data in the THAMSOes table
                var thamSo = db.THAMSOes.FirstOrDefault();
                if (thamSo != null)
                {
                    thamSo.SoBenhNhanToiDaTrongNgay = int.Parse(txtNumberMax.Text);
                    thamSo.TienKham = int.Parse(txtExamineMoney.Text);
                    //Get the number of medicines equal to the number of medicines in the dGVListMedicine
                    thamSo.SoLuongLoaiThuoc = dGVListMedicine.Rows.Count;
                    //Get the number of diseases equal to the number of diseases in the dGVListDisease
                    thamSo.SoLuongLoaiBenh = dGVListDisease.Rows.Count;
                    //Get the number of usages equal to the number of usages in the dGVListUsage
                    thamSo.SoLuongCachDung = dGVListUsage.Rows.Count;
                }
                //Update the diseases in the LOAIBENHs table
                var existingDiseases = db.LOAIBENHs.ToList();
                foreach (var disease in existingDiseases)
                {
                    var existsInList = dGVListDisease.Rows.Cast<DataGridViewRow>().Any(row =>
                    {
                        var cellValue = row.Cells["DiseaseId"].Value;
                        return cellValue != null && int.Parse(cellValue.ToString()) == disease.MaLoaiBenh;
                    });

                    if (!existsInList)
                    {
                        try
                        {
                            db.LOAIBENHs.Remove(disease);
                            db.SaveChanges();
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                        {
                            MessageBox.Show("Không thể xóa dữ liệu ở bảng loại bệnh vì nó liên kết với bảng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                foreach (DataGridViewRow row in dGVListDisease.Rows)
                {
                    if (row.Cells["DiseaseId"].Value != null)
                    {
                        var maLoaiBenh = int.Parse(row.Cells["DiseaseId"].Value.ToString());
                        var tenLoaiBenh = row.Cells["DiseaseName"].Value.ToString();
                        var loaiBenh = db.LOAIBENHs.FirstOrDefault(lb => lb.MaLoaiBenh == maLoaiBenh);
                        loaiBenh.TenLoaiBenh = tenLoaiBenh;
                    }
                    else if (row.Cells["DiseaseName"].Value != null)
                    {
                        var loaiBenh = new LOAIBENH();
                        loaiBenh.TenLoaiBenh = row.Cells["DiseaseName"].Value.ToString();
                        db.LOAIBENHs.Add(loaiBenh);
                    }
                }
                //Update the units in the DONVIs table
                var existingUnit = db.DONVIs.ToList();
                foreach (var unit in existingUnit)
                {
                    var existsInList = dGVListUnit.Rows.Cast<DataGridViewRow>().Any(row =>
                    {
                        var cellValue = row.Cells["UnitId"].Value;
                        return cellValue != null && int.Parse(cellValue.ToString()) == unit.MaDonVi;
                    });
                    if (!existsInList)
                    {
                        try
                        {
                            db.DONVIs.Remove(unit);
                            db.SaveChanges();
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                        {
                            MessageBox.Show("Không thể xóa dữ liệu ở bảng đơn vị vì nó liên kết với bảng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                foreach (DataGridViewRow row in dGVListUnit.Rows)
                {
                    if (row.Cells["UnitId"].Value != null)
                    {
                        var maDonVi = int.Parse(row.Cells["UnitId"].Value.ToString());
                        var tenDonVi = row.Cells["UnitName"].Value.ToString();
                        var donVi = db.DONVIs.FirstOrDefault(dv => dv.MaDonVi == maDonVi);
                        donVi.TenDonVi = tenDonVi;
                    }
                    else if (row.Cells["UnitName"].Value != null)
                    {
                        var donVi = new DONVI();
                        donVi.TenDonVi = row.Cells["UnitName"].Value.ToString();
                        db.DONVIs.Add(donVi);
                    }
                }

                //Update the usages in the CACHDUNGs table
                var existingUsages = db.CACHDUNGs.ToList();
                foreach (var usage in existingUsages)
                {
                    var existsInList = dGVListUsage.Rows.Cast<DataGridViewRow>().Any(row =>
                    {
                        var cellValue = row.Cells["UsageId"].Value;
                        return cellValue != null && int.Parse(cellValue.ToString()) == usage.MaCachDung;
                    });
                    if (!existsInList)
                    {
                        try
                        {
                            db.CACHDUNGs.Remove(usage);
                            db.SaveChanges();
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                        {
                            MessageBox.Show("Không thể xóa dữ liệu ở bảng cách dùng vì nó liên kết với bảng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                foreach (DataGridViewRow row in dGVListUsage.Rows)
                {
                    if (row.Cells["UsageId"].Value != null)
                    {
                        var maCachDung = int.Parse(row.Cells["UsageId"].Value.ToString());
                        var tenCachDung = row.Cells["UsageName"].Value.ToString();
                        var cachDung = db.CACHDUNGs.FirstOrDefault(cd => cd.MaCachDung == maCachDung);
                        cachDung.TenCachDung = tenCachDung;
                    }
                    else if (row.Cells["UsageName"].Value != null)
                    {
                        var cachDung = new CACHDUNG();
                        cachDung.TenCachDung = row.Cells["UsageName"].Value.ToString();
                        db.CACHDUNGs.Add(cachDung);
                    }
                }
                // Update the CHITIETTHUOC table
                var existingMedicines = db.CHITIETTHUOCs.ToList();
                foreach (var medicine in existingMedicines)
                {
                    var existsInList = dGVListMedicine.Rows.Cast<DataGridViewRow>().Any(row =>
                    {
                        var cellValue = row.Cells["MedicineId"].Value;
                        return cellValue != null && int.Parse(cellValue.ToString()) == medicine.MaCTThuoc;
                    });
                    if (!existsInList)
                    {
                        try
                        {
                            db.CHITIETTHUOCs.Remove(medicine);
                            db.SaveChanges();
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                        {
                            MessageBox.Show("Không thể xóa dữ liệu ở bảng chi tiết thuốc vì nó liên kết với bảng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                foreach (DataGridViewRow row in dGVListMedicine.Rows)
                {
                    if (row.Cells["MedicineId"].Value != null)
                    {
                        var maCTThuoc = int.Parse(row.Cells["MedicineId"].Value.ToString());
                        var tenThuoc = row.Cells["MedicineName"].Value.ToString();
                        var maDonVi = int.Parse(row.Cells["MedicineUnit"].Value.ToString());
                        var donGia = Convert.ToInt32(row.Cells["MedicinePrice"].Value);

                        var medicine = db.CHITIETTHUOCs.FirstOrDefault(ct => ct.MaCTThuoc == maCTThuoc);
                        if (medicine != null)
                        {
                            medicine.THUOC.TenThuoc = tenThuoc;
                            var donVi = db.DONVIs.FirstOrDefault(dv => dv.MaDonVi == maDonVi);
                            if (donVi != null)
                            {
                                medicine.DONVI = donVi;
                            }
                            else
                            {
                                MessageBox.Show("Mã đơn vị không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            medicine.DonGia = donGia;
                        }
                    }
                    else if (row.Cells["MedicineName"].Value != null && row.Cells["MedicineUnit"].Value != null)
                    {

                        var tenThuoc = row.Cells["MedicineName"].Value.ToString();
                        var maDonVi = int.Parse(row.Cells["MedicineUnit"].Value.ToString());
                        var donGia = Convert.ToInt32(row.Cells["MedicinePrice"].Value);

                        var newMedicine = new CHITIETTHUOC();
                        var thuoc = db.THUOCs.FirstOrDefault(t => t.TenThuoc == tenThuoc);
                        if (thuoc != null)
                        {
                            newMedicine.THUOC = thuoc;
                        }
                        else
                        {
                            var newThuoc = new THUOC { TenThuoc = tenThuoc };
                            newMedicine.THUOC = newThuoc;
                        }
                        var donVi = db.DONVIs.FirstOrDefault(dv => dv.MaDonVi == maDonVi);
                        if (donVi != null)
                        {
                            newMedicine.DONVI = donVi;
                        }
                        else
                        {

                            MessageBox.Show("Mã đơn vị không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        newMedicine.DonGia = donGia;
                        db.CHITIETTHUOCs.Add(newMedicine);
                    }
                }

                // Save the changes to the database
                db.SaveChanges();

                MessageBox.Show("Lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Clear data from all the dGV
                dGVListMedicine.Rows.Clear();
                dGVListUsage.Rows.Clear();
                dGVListDisease.Rows.Clear();
                dGVListUnit.Rows.Clear();
                //Reload data from database
                InitializeData();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clear data from all the dGV
            dGVListMedicine.Rows.Clear();
            dGVListUsage.Rows.Clear();
            dGVListDisease.Rows.Clear();
            dGVListUnit.Rows.Clear();
            //Reload data from database
            InitializeData();
        }


    }
}
