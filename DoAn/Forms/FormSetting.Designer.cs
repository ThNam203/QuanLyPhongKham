﻿namespace DoAn.Forms
{
    partial class FormSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumberMax = new MaterialSkin.Controls.MaterialTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVListDisease = new System.Windows.Forms.DataGridView();
            this.DiseaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveDisease = new RJCodeAdvance.RJControls.RJButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MedicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.UnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.UseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddDisease = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton4 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton5 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton6 = new RJCodeAdvance.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExamineMoney = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.btnReset = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListDisease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumberMax
            // 
            this.txtNumberMax.AnimateReadOnly = false;
            this.txtNumberMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNumberMax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumberMax.Depth = 0;
            this.txtNumberMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberMax.HideSelection = true;
            this.txtNumberMax.Hint = "40";
            this.txtNumberMax.LeadingIcon = null;
            this.txtNumberMax.Location = new System.Drawing.Point(376, 27);
            this.txtNumberMax.MaxLength = 32767;
            this.txtNumberMax.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumberMax.Name = "txtNumberMax";
            this.txtNumberMax.PasswordChar = '\0';
            this.txtNumberMax.PrefixSuffixText = null;
            this.txtNumberMax.ReadOnly = false;
            this.txtNumberMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumberMax.SelectedText = "";
            this.txtNumberMax.SelectionLength = 0;
            this.txtNumberMax.SelectionStart = 0;
            this.txtNumberMax.ShortcutsEnabled = true;
            this.txtNumberMax.Size = new System.Drawing.Size(56, 36);
            this.txtNumberMax.TabIndex = 11;
            this.txtNumberMax.TabStop = false;
            this.txtNumberMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumberMax.TrailingIcon = null;
            this.txtNumberMax.UseSystemPasswordChar = false;
            this.txtNumberMax.UseTallSize = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số lượng bệnh nhân tối đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Loại bệnh";
            // 
            // dGVListDisease
            // 
            this.dGVListDisease.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListDisease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListDisease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiseaseId,
            this.DiseaseName});
            this.dGVListDisease.Location = new System.Drawing.Point(37, 151);
            this.dGVListDisease.Name = "dGVListDisease";
            this.dGVListDisease.RowHeadersWidth = 51;
            this.dGVListDisease.RowTemplate.Height = 24;
            this.dGVListDisease.Size = new System.Drawing.Size(405, 191);
            this.dGVListDisease.TabIndex = 13;
            // 
            // DiseaseId
            // 
            this.DiseaseId.FillWeight = 70F;
            this.DiseaseId.HeaderText = "Mã loại bệnh";
            this.DiseaseId.MinimumWidth = 6;
            this.DiseaseId.Name = "DiseaseId";
            // 
            // DiseaseName
            // 
            this.DiseaseName.HeaderText = "Tên loại bệnh";
            this.DiseaseName.MinimumWidth = 6;
            this.DiseaseName.Name = "DiseaseName";
            // 
            // btnRemoveDisease
            // 
            this.btnRemoveDisease.BackColor = System.Drawing.Color.Red;
            this.btnRemoveDisease.BackgroundColor = System.Drawing.Color.Red;
            this.btnRemoveDisease.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemoveDisease.BorderRadius = 10;
            this.btnRemoveDisease.BorderSize = 0;
            this.btnRemoveDisease.FlatAppearance.BorderSize = 0;
            this.btnRemoveDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDisease.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDisease.Location = new System.Drawing.Point(448, 197);
            this.btnRemoveDisease.Name = "btnRemoveDisease";
            this.btnRemoveDisease.Size = new System.Drawing.Size(89, 40);
            this.btnRemoveDisease.TabIndex = 14;
            this.btnRemoveDisease.Text = "Xóa";
            this.btnRemoveDisease.TextColor = System.Drawing.Color.White;
            this.btnRemoveDisease.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineId,
            this.MedicineName,
            this.MedicinePrice});
            this.dataGridView2.Location = new System.Drawing.Point(577, 151);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(383, 191);
            this.dataGridView2.TabIndex = 16;
            // 
            // MedicineId
            // 
            this.MedicineId.HeaderText = "Mã thuốc";
            this.MedicineId.MinimumWidth = 6;
            this.MedicineId.Name = "MedicineId";
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "Tên thuốc";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            // 
            // MedicinePrice
            // 
            this.MedicinePrice.HeaderText = "Đơn giá";
            this.MedicinePrice.MinimumWidth = 6;
            this.MedicinePrice.Name = "MedicinePrice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(571, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thuốc";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitId,
            this.UnitName});
            this.dataGridView3.Location = new System.Drawing.Point(37, 403);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(405, 189);
            this.dataGridView3.TabIndex = 19;
            // 
            // UnitId
            // 
            this.UnitId.FillWeight = 50F;
            this.UnitId.HeaderText = "Mã đơn vị";
            this.UnitId.MinimumWidth = 6;
            this.UnitId.Name = "UnitId";
            // 
            // UnitName
            // 
            this.UnitName.HeaderText = "Tên đơn vị";
            this.UnitName.MinimumWidth = 6;
            this.UnitName.Name = "UnitName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(31, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Đơn vị tính";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UseId,
            this.UseName});
            this.dataGridView4.Location = new System.Drawing.Point(577, 403);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(383, 189);
            this.dataGridView4.TabIndex = 22;
            // 
            // UseId
            // 
            this.UseId.FillWeight = 85F;
            this.UseId.HeaderText = "Mã cách dùng";
            this.UseId.MinimumWidth = 6;
            this.UseId.Name = "UseId";
            // 
            // UseName
            // 
            this.UseName.HeaderText = "Cách dùng";
            this.UseName.MinimumWidth = 6;
            this.UseName.Name = "UseName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(571, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cách dùng";
            // 
            // btnAddDisease
            // 
            this.btnAddDisease.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddDisease.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddDisease.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddDisease.BorderRadius = 10;
            this.btnAddDisease.BorderSize = 0;
            this.btnAddDisease.FlatAppearance.BorderSize = 0;
            this.btnAddDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDisease.ForeColor = System.Drawing.Color.White;
            this.btnAddDisease.Location = new System.Drawing.Point(448, 151);
            this.btnAddDisease.Name = "btnAddDisease";
            this.btnAddDisease.Size = new System.Drawing.Size(89, 40);
            this.btnAddDisease.TabIndex = 24;
            this.btnAddDisease.Text = "Thêm";
            this.btnAddDisease.TextColor = System.Drawing.Color.White;
            this.btnAddDisease.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.rjButton1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(971, 151);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(89, 40);
            this.rjButton1.TabIndex = 26;
            this.rjButton1.Text = "Thêm";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.Red;
            this.rjButton4.BackgroundColor = System.Drawing.Color.Red;
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 10;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(971, 197);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(89, 40);
            this.rjButton4.TabIndex = 25;
            this.rjButton4.Text = "Xóa";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.rjButton2.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(448, 403);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(89, 40);
            this.rjButton2.TabIndex = 28;
            this.rjButton2.Text = "Thêm";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.Red;
            this.rjButton5.BackgroundColor = System.Drawing.Color.Red;
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 10;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(448, 449);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(89, 40);
            this.rjButton5.TabIndex = 27;
            this.rjButton5.Text = "Xóa";
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.SeaGreen;
            this.rjButton3.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 10;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(971, 403);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(89, 40);
            this.rjButton3.TabIndex = 30;
            this.rjButton3.Text = "Thêm";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.Red;
            this.rjButton6.BackgroundColor = System.Drawing.Color.Red;
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 10;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Location = new System.Drawing.Point(971, 449);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(89, 40);
            this.rjButton6.TabIndex = 29;
            this.rjButton6.Text = "Xóa";
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(571, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 31);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tiền khám";
            // 
            // txtExamineMoney
            // 
            this.txtExamineMoney.AnimateReadOnly = false;
            this.txtExamineMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtExamineMoney.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtExamineMoney.Depth = 0;
            this.txtExamineMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamineMoney.HideSelection = true;
            this.txtExamineMoney.Hint = "5 tỷ";
            this.txtExamineMoney.LeadingIcon = null;
            this.txtExamineMoney.Location = new System.Drawing.Point(717, 27);
            this.txtExamineMoney.MaxLength = 32767;
            this.txtExamineMoney.MouseState = MaterialSkin.MouseState.OUT;
            this.txtExamineMoney.Name = "txtExamineMoney";
            this.txtExamineMoney.PasswordChar = '\0';
            this.txtExamineMoney.PrefixSuffixText = null;
            this.txtExamineMoney.ReadOnly = false;
            this.txtExamineMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExamineMoney.SelectedText = "";
            this.txtExamineMoney.SelectionLength = 0;
            this.txtExamineMoney.SelectionStart = 0;
            this.txtExamineMoney.ShortcutsEnabled = true;
            this.txtExamineMoney.Size = new System.Drawing.Size(165, 36);
            this.txtExamineMoney.TabIndex = 32;
            this.txtExamineMoney.TabStop = false;
            this.txtExamineMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExamineMoney.TrailingIcon = null;
            this.txtExamineMoney.UseSystemPasswordChar = false;
            this.txtExamineMoney.UseTallSize = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(810, 657);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.BackgroundColor = System.Drawing.Color.Red;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 10;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(630, 657);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Hủy";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1072, 732);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtExamineMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton6);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton5);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.btnAddDisease);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveDisease);
            this.Controls.Add(this.dGVListDisease);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberMax);
            this.Controls.Add(this.label1);
            this.Name = "FormSetting";
            this.Text = "Thay đổi quy định";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListDisease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtNumberMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVListDisease;
        private RJCodeAdvance.RJControls.RJButton btnRemoveDisease;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJButton btnAddDisease;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton4;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton rjButton5;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton6;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox2 txtExamineMoney;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private RJCodeAdvance.RJControls.RJButton btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseName;
    }
}