namespace DoAn.Forms
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
            this.dGVListMedicine = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVListUsage = new System.Windows.Forms.DataGridView();
            this.UsageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddDisease = new RJCodeAdvance.RJControls.RJButton();
            this.btnAddUsage = new RJCodeAdvance.RJControls.RJButton();
            this.btnRemoveUsage = new RJCodeAdvance.RJControls.RJButton();
            this.btnAddMedicine = new RJCodeAdvance.RJControls.RJButton();
            this.btnRemoveMedicine = new RJCodeAdvance.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExamineMoney = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.btnReset = new RJCodeAdvance.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.MedicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVListUnit = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.UnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddUnit = new RJCodeAdvance.RJControls.RJButton();
            this.btnRemoveUnit = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListDisease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListUnit)).BeginInit();
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
            this.dGVListDisease.Size = new System.Drawing.Size(329, 191);
            this.dGVListDisease.TabIndex = 13;
            // 
            // DiseaseId
            // 
            this.DiseaseId.FillWeight = 70F;
            this.DiseaseId.HeaderText = "Mã loại bệnh";
            this.DiseaseId.MinimumWidth = 6;
            this.DiseaseId.Name = "DiseaseId";
            this.DiseaseId.ReadOnly = true;
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
            this.btnRemoveDisease.Location = new System.Drawing.Point(132, 348);
            this.btnRemoveDisease.Name = "btnRemoveDisease";
            this.btnRemoveDisease.Size = new System.Drawing.Size(89, 40);
            this.btnRemoveDisease.TabIndex = 14;
            this.btnRemoveDisease.Text = "Xóa";
            this.btnRemoveDisease.TextColor = System.Drawing.Color.White;
            this.btnRemoveDisease.UseVisualStyleBackColor = false;
            this.btnRemoveDisease.Click += new System.EventHandler(this.btnRemoveDisease_Click);
            // 
            // dGVListMedicine
            // 
            this.dGVListMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineId,
            this.MedicineName,
            this.MedicineUnit,
            this.MedicinePrice});
            this.dGVListMedicine.Location = new System.Drawing.Point(37, 483);
            this.dGVListMedicine.Name = "dGVListMedicine";
            this.dGVListMedicine.RowHeadersWidth = 51;
            this.dGVListMedicine.RowTemplate.Height = 24;
            this.dGVListMedicine.Size = new System.Drawing.Size(928, 191);
            this.dGVListMedicine.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(31, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thuốc";
            // 
            // dGVListUsage
            // 
            this.dGVListUsage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListUsage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsageId,
            this.UsageName});
            this.dGVListUsage.Location = new System.Drawing.Point(398, 151);
            this.dGVListUsage.Name = "dGVListUsage";
            this.dGVListUsage.RowHeadersWidth = 51;
            this.dGVListUsage.RowTemplate.Height = 24;
            this.dGVListUsage.Size = new System.Drawing.Size(313, 191);
            this.dGVListUsage.TabIndex = 22;
            // 
            // UsageId
            // 
            this.UsageId.FillWeight = 85F;
            this.UsageId.HeaderText = "Mã cách dùng";
            this.UsageId.MinimumWidth = 6;
            this.UsageId.Name = "UsageId";
            this.UsageId.ReadOnly = true;
            // 
            // UsageName
            // 
            this.UsageName.HeaderText = "Cách dùng";
            this.UsageName.MinimumWidth = 6;
            this.UsageName.Name = "UsageName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(392, 93);
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
            this.btnAddDisease.Location = new System.Drawing.Point(37, 348);
            this.btnAddDisease.Name = "btnAddDisease";
            this.btnAddDisease.Size = new System.Drawing.Size(89, 40);
            this.btnAddDisease.TabIndex = 24;
            this.btnAddDisease.Text = "Thêm";
            this.btnAddDisease.TextColor = System.Drawing.Color.White;
            this.btnAddDisease.UseVisualStyleBackColor = false;
            this.btnAddDisease.Click += new System.EventHandler(this.btnAddDisease_Click);
            // 
            // btnAddUsage
            // 
            this.btnAddUsage.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddUsage.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddUsage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddUsage.BorderRadius = 10;
            this.btnAddUsage.BorderSize = 0;
            this.btnAddUsage.FlatAppearance.BorderSize = 0;
            this.btnAddUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsage.ForeColor = System.Drawing.Color.White;
            this.btnAddUsage.Location = new System.Drawing.Point(398, 348);
            this.btnAddUsage.Name = "btnAddUsage";
            this.btnAddUsage.Size = new System.Drawing.Size(89, 40);
            this.btnAddUsage.TabIndex = 26;
            this.btnAddUsage.Text = "Thêm";
            this.btnAddUsage.TextColor = System.Drawing.Color.White;
            this.btnAddUsage.UseVisualStyleBackColor = false;
            this.btnAddUsage.Click += new System.EventHandler(this.btnAddUsage_Click);
            // 
            // btnRemoveUsage
            // 
            this.btnRemoveUsage.BackColor = System.Drawing.Color.Red;
            this.btnRemoveUsage.BackgroundColor = System.Drawing.Color.Red;
            this.btnRemoveUsage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemoveUsage.BorderRadius = 10;
            this.btnRemoveUsage.BorderSize = 0;
            this.btnRemoveUsage.FlatAppearance.BorderSize = 0;
            this.btnRemoveUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUsage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUsage.Location = new System.Drawing.Point(493, 348);
            this.btnRemoveUsage.Name = "btnRemoveUsage";
            this.btnRemoveUsage.Size = new System.Drawing.Size(89, 40);
            this.btnRemoveUsage.TabIndex = 25;
            this.btnRemoveUsage.Text = "Xóa";
            this.btnRemoveUsage.TextColor = System.Drawing.Color.White;
            this.btnRemoveUsage.UseVisualStyleBackColor = false;
            this.btnRemoveUsage.Click += new System.EventHandler(this.btnRemoveUsage_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddMedicine.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddMedicine.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddMedicine.BorderRadius = 10;
            this.btnAddMedicine.BorderSize = 0;
            this.btnAddMedicine.FlatAppearance.BorderSize = 0;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Location = new System.Drawing.Point(971, 483);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(89, 40);
            this.btnAddMedicine.TabIndex = 30;
            this.btnAddMedicine.Text = "Thêm";
            this.btnAddMedicine.TextColor = System.Drawing.Color.White;
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnRemoveMedicine
            // 
            this.btnRemoveMedicine.BackColor = System.Drawing.Color.Red;
            this.btnRemoveMedicine.BackgroundColor = System.Drawing.Color.Red;
            this.btnRemoveMedicine.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemoveMedicine.BorderRadius = 10;
            this.btnRemoveMedicine.BorderSize = 0;
            this.btnRemoveMedicine.FlatAppearance.BorderSize = 0;
            this.btnRemoveMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMedicine.ForeColor = System.Drawing.Color.White;
            this.btnRemoveMedicine.Location = new System.Drawing.Point(971, 546);
            this.btnRemoveMedicine.Name = "btnRemoveMedicine";
            this.btnRemoveMedicine.Size = new System.Drawing.Size(89, 40);
            this.btnRemoveMedicine.TabIndex = 29;
            this.btnRemoveMedicine.Text = "Xóa";
            this.btnRemoveMedicine.TextColor = System.Drawing.Color.White;
            this.btnRemoveMedicine.UseVisualStyleBackColor = false;
            this.btnRemoveMedicine.Click += new System.EventHandler(this.btnRemoveMedicine_Click);
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
            this.btnSave.Location = new System.Drawing.Point(815, 680);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnReset.Location = new System.Drawing.Point(631, 680);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Hủy";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(888, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "đ";
            // 
            // MedicineId
            // 
            this.MedicineId.FillWeight = 70F;
            this.MedicineId.HeaderText = "Mã thuốc";
            this.MedicineId.MinimumWidth = 6;
            this.MedicineId.Name = "MedicineId";
            this.MedicineId.ReadOnly = true;
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "Tên thuốc";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            // 
            // MedicineUnit
            // 
            this.MedicineUnit.HeaderText = "Mã đơn vị";
            this.MedicineUnit.MinimumWidth = 6;
            this.MedicineUnit.Name = "MedicineUnit";
            // 
            // MedicinePrice
            // 
            this.MedicinePrice.HeaderText = "Đơn giá";
            this.MedicinePrice.MinimumWidth = 6;
            this.MedicinePrice.Name = "MedicinePrice";
            // 
            // dGVListUnit
            // 
            this.dGVListUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitId,
            this.UnitName});
            this.dGVListUnit.Location = new System.Drawing.Point(747, 151);
            this.dGVListUnit.Name = "dGVListUnit";
            this.dGVListUnit.RowHeadersWidth = 51;
            this.dGVListUnit.RowTemplate.Height = 24;
            this.dGVListUnit.Size = new System.Drawing.Size(313, 191);
            this.dGVListUnit.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(741, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 31);
            this.label7.TabIndex = 37;
            this.label7.Text = "Đơn vị";
            // 
            // UnitId
            // 
            this.UnitId.FillWeight = 85F;
            this.UnitId.HeaderText = "Mã đơn vị";
            this.UnitId.MinimumWidth = 6;
            this.UnitId.Name = "UnitId";
            this.UnitId.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.HeaderText = "Đơn vị";
            this.UnitName.MinimumWidth = 6;
            this.UnitName.Name = "UnitName";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddUnit.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddUnit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddUnit.BorderRadius = 10;
            this.btnAddUnit.BorderSize = 0;
            this.btnAddUnit.FlatAppearance.BorderSize = 0;
            this.btnAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnit.ForeColor = System.Drawing.Color.White;
            this.btnAddUnit.Location = new System.Drawing.Point(747, 348);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(89, 40);
            this.btnAddUnit.TabIndex = 38;
            this.btnAddUnit.Text = "Thêm";
            this.btnAddUnit.TextColor = System.Drawing.Color.White;
            this.btnAddUnit.UseVisualStyleBackColor = false;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // btnRemoveUnit
            // 
            this.btnRemoveUnit.BackColor = System.Drawing.Color.Red;
            this.btnRemoveUnit.BackgroundColor = System.Drawing.Color.Red;
            this.btnRemoveUnit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemoveUnit.BorderRadius = 10;
            this.btnRemoveUnit.BorderSize = 0;
            this.btnRemoveUnit.FlatAppearance.BorderSize = 0;
            this.btnRemoveUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUnit.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUnit.Location = new System.Drawing.Point(842, 348);
            this.btnRemoveUnit.Name = "btnRemoveUnit";
            this.btnRemoveUnit.Size = new System.Drawing.Size(89, 40);
            this.btnRemoveUnit.TabIndex = 39;
            this.btnRemoveUnit.Text = "Xóa";
            this.btnRemoveUnit.TextColor = System.Drawing.Color.White;
            this.btnRemoveUnit.UseVisualStyleBackColor = false;
            this.btnRemoveUnit.Click += new System.EventHandler(this.btnRemoveUnit_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1072, 732);
            this.Controls.Add(this.btnRemoveUnit);
            this.Controls.Add(this.btnAddUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dGVListUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtExamineMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.btnRemoveMedicine);
            this.Controls.Add(this.btnAddUsage);
            this.Controls.Add(this.btnRemoveUsage);
            this.Controls.Add(this.btnAddDisease);
            this.Controls.Add(this.dGVListUsage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dGVListMedicine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveDisease);
            this.Controls.Add(this.dGVListDisease);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberMax);
            this.Controls.Add(this.label1);
            this.Name = "FormSetting";
            this.Text = "Thay đổi quy định";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListDisease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtNumberMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVListDisease;
        private RJCodeAdvance.RJControls.RJButton btnRemoveDisease;
        private System.Windows.Forms.DataGridView dGVListMedicine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVListUsage;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJButton btnAddDisease;
        private RJCodeAdvance.RJControls.RJButton btnAddUsage;
        private RJCodeAdvance.RJControls.RJButton btnRemoveUsage;
        private RJCodeAdvance.RJControls.RJButton btnAddMedicine;
        private RJCodeAdvance.RJControls.RJButton btnRemoveMedicine;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox2 txtExamineMoney;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private RJCodeAdvance.RJControls.RJButton btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsageName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicinePrice;
        private System.Windows.Forms.DataGridView dGVListUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.Label label7;
        private RJCodeAdvance.RJControls.RJButton btnAddUnit;
        private RJCodeAdvance.RJControls.RJButton btnRemoveUnit;
    }
}