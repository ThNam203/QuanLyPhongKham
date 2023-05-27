namespace DoAn.Forms
{
    partial class FormMakeListExamine
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
            this.lblDateExam = new System.Windows.Forms.Label();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtDuDoan = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblDuDoan = new System.Windows.Forms.Label();
            this.dpDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.dGVListMedicine = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Use = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnReset = new RJCodeAdvance.RJControls.RJButton();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.txtTrieuChung = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateExam
            // 
            this.lblDateExam.AutoSize = true;
            this.lblDateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDateExam.Location = new System.Drawing.Point(33, 25);
            this.lblDateExam.Name = "lblDateExam";
            this.lblDateExam.Size = new System.Drawing.Size(130, 31);
            this.lblDateExam.TabIndex = 1;
            this.lblDateExam.Text = "Họ và tên";
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.HideSelection = true;
            this.txtName.Hint = "Nhập họ và tên";
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(173, 25);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PrefixSuffixText = null;
            this.txtName.ReadOnly = false;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(250, 36);
            this.txtName.TabIndex = 2;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TrailingIcon = null;
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.UseTallSize = false;
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTrieuChung.Location = new System.Drawing.Point(6, 158);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(157, 31);
            this.lblTrieuChung.TabIndex = 3;
            this.lblTrieuChung.Text = "Triệu chứng";
            // 
            // txtDuDoan
            // 
            this.txtDuDoan.AnimateReadOnly = false;
            this.txtDuDoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDuDoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDuDoan.Depth = 0;
            this.txtDuDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuDoan.HideSelection = true;
            this.txtDuDoan.Hint = "Nhập dự đoán bệnh";
            this.txtDuDoan.LeadingIcon = null;
            this.txtDuDoan.Location = new System.Drawing.Point(173, 252);
            this.txtDuDoan.MaxLength = 32767;
            this.txtDuDoan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDuDoan.Name = "txtDuDoan";
            this.txtDuDoan.PasswordChar = '\0';
            this.txtDuDoan.PrefixSuffixText = null;
            this.txtDuDoan.ReadOnly = false;
            this.txtDuDoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDuDoan.SelectedText = "";
            this.txtDuDoan.SelectionLength = 0;
            this.txtDuDoan.SelectionStart = 0;
            this.txtDuDoan.ShortcutsEnabled = true;
            this.txtDuDoan.Size = new System.Drawing.Size(250, 36);
            this.txtDuDoan.TabIndex = 6;
            this.txtDuDoan.TabStop = false;
            this.txtDuDoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDuDoan.TrailingIcon = null;
            this.txtDuDoan.UseSystemPasswordChar = false;
            this.txtDuDoan.UseTallSize = false;
            // 
            // lblDuDoan
            // 
            this.lblDuDoan.AutoSize = true;
            this.lblDuDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDuDoan.Location = new System.Drawing.Point(33, 252);
            this.lblDuDoan.Name = "lblDuDoan";
            this.lblDuDoan.Size = new System.Drawing.Size(116, 31);
            this.lblDuDoan.TabIndex = 5;
            this.lblDuDoan.Text = "Dự đoán";
            // 
            // dpDate
            // 
            this.dpDate.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dpDate.BorderSize = 3;
            this.dpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dpDate.Location = new System.Drawing.Point(173, 75);
            this.dpDate.MinimumSize = new System.Drawing.Size(4, 60);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(382, 60);
            this.dpDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.dpDate.TabIndex = 7;
            this.dpDate.TextColor = System.Drawing.Color.Black;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDate.Location = new System.Drawing.Point(12, 92);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(151, 31);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Ngày khám";
            // 
            // dGVListMedicine
            // 
            this.dGVListMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.MedicineName,
            this.Unit,
            this.Quantity,
            this.Use,
            this.Add});
            this.dGVListMedicine.Location = new System.Drawing.Point(83, 318);
            this.dGVListMedicine.Name = "dGVListMedicine";
            this.dGVListMedicine.RowHeadersWidth = 51;
            this.dGVListMedicine.RowTemplate.Height = 24;
            this.dGVListMedicine.Size = new System.Drawing.Size(841, 302);
            this.dGVListMedicine.TabIndex = 9;
            this.dGVListMedicine.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dGVListMedicine_RowPostPaint);
            // 
            // Index
            // 
            this.Index.FillWeight = 50F;
            this.Index.HeaderText = "STT";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MedicineName
            // 
            this.MedicineName.FillWeight = 87.91444F;
            this.MedicineName.HeaderText = "Thuốc";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.ReadOnly = true;
            this.MedicineName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Unit
            // 
            this.Unit.FillWeight = 87.91444F;
            this.Unit.HeaderText = "Đơn vị";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 87.91444F;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Use
            // 
            this.Use.FillWeight = 87.91444F;
            this.Use.HeaderText = "Cách dùng";
            this.Use.MinimumWidth = 6;
            this.Use.Name = "Use";
            this.Use.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Use.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Add
            // 
            this.Add.FillWeight = 87.91444F;
            this.Add.HeaderText = "Thêm";
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.btnReset.Location = new System.Drawing.Point(606, 651);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Hủy";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnSave.Location = new System.Drawing.Point(774, 651);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.AnimateReadOnly = false;
            this.txtTrieuChung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTrieuChung.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTrieuChung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrieuChung.Depth = 0;
            this.txtTrieuChung.HideSelection = true;
            this.txtTrieuChung.Hint = "Nhập triệu chứng bệnh";
            this.txtTrieuChung.Location = new System.Drawing.Point(173, 158);
            this.txtTrieuChung.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrieuChung.MaxLength = 2147483647;
            this.txtTrieuChung.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.PasswordChar = '\0';
            this.txtTrieuChung.ReadOnly = false;
            this.txtTrieuChung.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTrieuChung.SelectedText = "";
            this.txtTrieuChung.SelectionLength = 0;
            this.txtTrieuChung.SelectionStart = 0;
            this.txtTrieuChung.ShortcutsEnabled = true;
            this.txtTrieuChung.Size = new System.Drawing.Size(541, 81);
            this.txtTrieuChung.TabIndex = 71;
            this.txtTrieuChung.TabStop = false;
            this.txtTrieuChung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTrieuChung.UseSystemPasswordChar = false;
            // 
            // FormMakeListExamine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(984, 717);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dGVListMedicine);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.txtDuDoan);
            this.Controls.Add(this.lblDuDoan);
            this.Controls.Add(this.lblTrieuChung);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDateExam);
            this.Name = "FormMakeListExamine";
            this.Text = "Lập phiếu khám bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateExam;
        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private System.Windows.Forms.Label lblTrieuChung;
        private MaterialSkin.Controls.MaterialTextBox2 txtDuDoan;
        private System.Windows.Forms.Label lblDuDoan;
        private RJCodeAdvance.RJControls.RJDatePicker dpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dGVListMedicine;
        private RJCodeAdvance.RJControls.RJButton btnReset;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn Use;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTrieuChung;
    }
}