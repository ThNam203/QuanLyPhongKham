namespace DoAn.Forms
{
    partial class FormSearchPatient
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
            this.lblListPatient = new System.Windows.Forms.Label();
            this.dGVListPatient = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExamine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symptom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.dpDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.lblDateExam = new System.Windows.Forms.Label();
            this.btnReset = new RJCodeAdvance.RJControls.RJButton();
            this.txtTrieuChung = new MaterialSkin.Controls.MaterialTextBox2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLBenh = new RJCodeAdvance.RJControls.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListPatient
            // 
            this.lblListPatient.AutoSize = true;
            this.lblListPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblListPatient.Location = new System.Drawing.Point(77, 183);
            this.lblListPatient.Name = "lblListPatient";
            this.lblListPatient.Size = new System.Drawing.Size(278, 31);
            this.lblListPatient.TabIndex = 7;
            this.lblListPatient.Text = "Danh sách bệnh nhân";
            // 
            // dGVListPatient
            // 
            this.dGVListPatient.AllowUserToAddRows = false;
            this.dGVListPatient.AllowUserToDeleteRows = false;
            this.dGVListPatient.AllowUserToResizeColumns = false;
            this.dGVListPatient.AllowUserToResizeRows = false;
            this.dGVListPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.LastName,
            this.DateExamine,
            this.Symptom,
            this.Disease});
            this.dGVListPatient.Location = new System.Drawing.Point(83, 235);
            this.dGVListPatient.Name = "dGVListPatient";
            this.dGVListPatient.ReadOnly = true;
            this.dGVListPatient.RowHeadersWidth = 51;
            this.dGVListPatient.RowTemplate.Height = 24;
            this.dGVListPatient.Size = new System.Drawing.Size(947, 382);
            this.dGVListPatient.TabIndex = 6;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Index.HeaderText = "STT";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 63;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.HeaderText = "Họ và tên";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DateExamine
            // 
            this.DateExamine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateExamine.HeaderText = "Ngày khám";
            this.DateExamine.MinimumWidth = 6;
            this.DateExamine.Name = "DateExamine";
            this.DateExamine.ReadOnly = true;
            // 
            // Symptom
            // 
            this.Symptom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Symptom.FillWeight = 70F;
            this.Symptom.HeaderText = "Triệu chứng";
            this.Symptom.MinimumWidth = 6;
            this.Symptom.Name = "Symptom";
            this.Symptom.ReadOnly = true;
            this.Symptom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Disease
            // 
            this.Disease.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Disease.HeaderText = "Loại bệnh";
            this.Disease.MinimumWidth = 6;
            this.Disease.Name = "Disease";
            this.Disease.ReadOnly = true;
            this.Disease.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.txtName.Location = new System.Drawing.Point(222, 36);
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
            this.txtName.Size = new System.Drawing.Size(287, 36);
            this.txtName.TabIndex = 9;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TrailingIcon = null;
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.UseTallSize = false;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(70, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Họ và tên";
            // 
            // dpDate
            // 
            this.dpDate.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dpDate.BorderSize = 3;
            this.dpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dpDate.CustomFormat = "dd/MM/yyyy";
            this.dpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDate.Location = new System.Drawing.Point(745, 19);
            this.dpDate.MinimumSize = new System.Drawing.Size(4, 60);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(272, 60);
            this.dpDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.dpDate.TabIndex = 11;
            this.dpDate.TextColor = System.Drawing.Color.Black;
            this.dpDate.ValueChanged += new System.EventHandler(this.dpDate_ValueChanged);
            // 
            // lblDateExam
            // 
            this.lblDateExam.AutoSize = true;
            this.lblDateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDateExam.Location = new System.Drawing.Point(588, 36);
            this.lblDateExam.Name = "lblDateExam";
            this.lblDateExam.Size = new System.Drawing.Size(151, 31);
            this.lblDateExam.TabIndex = 10;
            this.lblDateExam.Text = "Ngày khám";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReset.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 10;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(880, 649);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Tải lại";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.AnimateReadOnly = false;
            this.txtTrieuChung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTrieuChung.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTrieuChung.Depth = 0;
            this.txtTrieuChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrieuChung.HideSelection = true;
            this.txtTrieuChung.Hint = "Nhập triệu chứng";
            this.txtTrieuChung.LeadingIcon = null;
            this.txtTrieuChung.Location = new System.Drawing.Point(222, 118);
            this.txtTrieuChung.MaxLength = 32767;
            this.txtTrieuChung.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.PasswordChar = '\0';
            this.txtTrieuChung.PrefixSuffixText = null;
            this.txtTrieuChung.ReadOnly = false;
            this.txtTrieuChung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTrieuChung.SelectedText = "";
            this.txtTrieuChung.SelectionLength = 0;
            this.txtTrieuChung.SelectionStart = 0;
            this.txtTrieuChung.ShortcutsEnabled = true;
            this.txtTrieuChung.Size = new System.Drawing.Size(287, 36);
            this.txtTrieuChung.TabIndex = 14;
            this.txtTrieuChung.TabStop = false;
            this.txtTrieuChung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTrieuChung.TrailingIcon = null;
            this.txtTrieuChung.UseSystemPasswordChar = false;
            this.txtTrieuChung.UseTallSize = false;
            this.txtTrieuChung.TextChanged += new System.EventHandler(this.txtTrieuChung_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(70, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Triệu chứng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(594, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Loại bệnh";
            // 
            // cbbLBenh
            // 
            this.cbbLBenh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.cbbLBenh.BorderColor = System.Drawing.Color.Gray;
            this.cbbLBenh.BorderSize = 1;
            this.cbbLBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbLBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbLBenh.ForeColor = System.Drawing.Color.Black;
            this.cbbLBenh.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbLBenh.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbLBenh.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbLBenh.Location = new System.Drawing.Point(745, 118);
            this.cbbLBenh.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbLBenh.Name = "cbbLBenh";
            this.cbbLBenh.Padding = new System.Windows.Forms.Padding(1);
            this.cbbLBenh.Size = new System.Drawing.Size(272, 30);
            this.cbbLBenh.TabIndex = 76;
            this.cbbLBenh.Texts = "";
            this.cbbLBenh.OnSelectedIndexChanged += new System.EventHandler(this.cbbLBenh_OnSelectedIndexChanged);
            // 
            // FormSearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1084, 717);
            this.Controls.Add(this.cbbLBenh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.lblDateExam);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblListPatient);
            this.Controls.Add(this.dGVListPatient);
            this.Name = "FormSearchPatient";
            this.Text = "Tra cứu bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListPatient;
        private System.Windows.Forms.DataGridView dGVListPatient;
        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExamine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symptom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disease;
        private RJCodeAdvance.RJControls.RJDatePicker dpDate;
        private System.Windows.Forms.Label lblDateExam;
        private RJCodeAdvance.RJControls.RJButton btnReset;
        private MaterialSkin.Controls.MaterialTextBox2 txtTrieuChung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJComboBox cbbLBenh;
    }
}