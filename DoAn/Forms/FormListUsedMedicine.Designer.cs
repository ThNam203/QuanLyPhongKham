namespace DoAn.Forms
{
    partial class FormListUsedMedicine
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMonth = new RJCodeAdvance.RJControls.RJComboBox();
            this.dGVListUsedMedicine = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new MaterialSkin.Controls.MaterialTextBox2();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListUsedMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tháng";
            // 
            // cbbMonth
            // 
            this.cbbMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.cbbMonth.BorderColor = System.Drawing.Color.Gray;
            this.cbbMonth.BorderSize = 1;
            this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbMonth.ForeColor = System.Drawing.Color.Black;
            this.cbbMonth.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbMonth.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbMonth.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbMonth.Location = new System.Drawing.Point(181, 45);
            this.cbbMonth.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Padding = new System.Windows.Forms.Padding(1);
            this.cbbMonth.Size = new System.Drawing.Size(200, 30);
            this.cbbMonth.TabIndex = 73;
            this.cbbMonth.Texts = "";
            this.cbbMonth.OnSelectedIndexChanged += new System.EventHandler(this.cbbMonth_OnSelectedIndexChanged);
            // 
            // dGVListUsedMedicine
            // 
            this.dGVListUsedMedicine.AllowUserToAddRows = false;
            this.dGVListUsedMedicine.AllowUserToDeleteRows = false;
            this.dGVListUsedMedicine.AllowUserToResizeColumns = false;
            this.dGVListUsedMedicine.AllowUserToResizeRows = false;
            this.dGVListUsedMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListUsedMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListUsedMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.MedicineName,
            this.Unit,
            this.NumberUsed,
            this.TotalNumber});
            this.dGVListUsedMedicine.Location = new System.Drawing.Point(73, 180);
            this.dGVListUsedMedicine.Name = "dGVListUsedMedicine";
            this.dGVListUsedMedicine.ReadOnly = true;
            this.dGVListUsedMedicine.RowHeadersWidth = 51;
            this.dGVListUsedMedicine.RowTemplate.Height = 24;
            this.dGVListUsedMedicine.Size = new System.Drawing.Size(937, 460);
            this.dGVListUsedMedicine.TabIndex = 74;
            // 
            // Index
            // 
            this.Index.FillWeight = 60F;
            this.Index.HeaderText = "Mã thuốc";
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
            this.Unit.ReadOnly = true;
            this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NumberUsed
            // 
            this.NumberUsed.HeaderText = "Số lần kê đơn";
            this.NumberUsed.MinimumWidth = 6;
            this.NumberUsed.Name = "NumberUsed";
            this.NumberUsed.ReadOnly = true;
            // 
            // TotalNumber
            // 
            this.TotalNumber.HeaderText = "Số lượng đã dùng";
            this.TotalNumber.MinimumWidth = 6;
            this.TotalNumber.Name = "TotalNumber";
            this.TotalNumber.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(67, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 31);
            this.label2.TabIndex = 75;
            this.label2.Text = "Báo cáo sử dụng thuốc";
            // 
            // txtYear
            // 
            this.txtYear.AnimateReadOnly = false;
            this.txtYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtYear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtYear.Depth = 0;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.HideSelection = true;
            this.txtYear.Hint = "Nhập năm";
            this.txtYear.LeadingIcon = null;
            this.txtYear.Location = new System.Drawing.Point(598, 45);
            this.txtYear.MaxLength = 32767;
            this.txtYear.MouseState = MaterialSkin.MouseState.OUT;
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.PrefixSuffixText = null;
            this.txtYear.ReadOnly = false;
            this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYear.SelectedText = "";
            this.txtYear.SelectionLength = 0;
            this.txtYear.SelectionStart = 0;
            this.txtYear.ShortcutsEnabled = true;
            this.txtYear.Size = new System.Drawing.Size(250, 36);
            this.txtYear.TabIndex = 77;
            this.txtYear.TabStop = false;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtYear.TrailingIcon = null;
            this.txtYear.UseSystemPasswordChar = false;
            this.txtYear.UseTallSize = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(510, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 31);
            this.label3.TabIndex = 76;
            this.label3.Text = "Năm";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(901, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 78;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormListUsedMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1084, 717);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGVListUsedMedicine);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.label1);
            this.Name = "FormListUsedMedicine";
            this.Text = "Báo cáo sử dụng thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListUsedMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJComboBox cbbMonth;
        private System.Windows.Forms.DataGridView dGVListUsedMedicine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNumber;
        private MaterialSkin.Controls.MaterialTextBox2 txtYear;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJButton btnSearch;
    }
}