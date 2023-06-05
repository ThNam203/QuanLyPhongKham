namespace DoAn.Forms
{
    partial class FormListInvoice
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
            this.txtName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListPatient = new System.Windows.Forms.Label();
            this.dGVListPatient = new System.Windows.Forms.DataGridView();
            this.lblDateExam = new System.Windows.Forms.Label();
            this.dpDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExamine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListPatient)).BeginInit();
            this.SuspendLayout();
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
            this.txtName.Location = new System.Drawing.Point(164, 24);
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
            this.txtName.TabIndex = 15;
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
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ và tên";
            // 
            // lblListPatient
            // 
            this.lblListPatient.AutoSize = true;
            this.lblListPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblListPatient.Location = new System.Drawing.Point(24, 106);
            this.lblListPatient.Name = "lblListPatient";
            this.lblListPatient.Size = new System.Drawing.Size(248, 31);
            this.lblListPatient.TabIndex = 13;
            this.lblListPatient.Text = "Danh sách hóa đơn";
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
            this.PatientName,
            this.Disease,
            this.DateExamine,
            this.Total});
            this.dGVListPatient.Location = new System.Drawing.Point(72, 172);
            this.dGVListPatient.Name = "dGVListPatient";
            this.dGVListPatient.ReadOnly = true;
            this.dGVListPatient.RowHeadersWidth = 51;
            this.dGVListPatient.RowTemplate.Height = 24;
            this.dGVListPatient.Size = new System.Drawing.Size(937, 460);
            this.dGVListPatient.TabIndex = 12;
            this.dGVListPatient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVListPatient_CellDoubleClick);
            // 
            // lblDateExam
            // 
            this.lblDateExam.AutoSize = true;
            this.lblDateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDateExam.Location = new System.Drawing.Point(624, 24);
            this.lblDateExam.Name = "lblDateExam";
            this.lblDateExam.Size = new System.Drawing.Size(151, 31);
            this.lblDateExam.TabIndex = 10;
            this.lblDateExam.Text = "Ngày khám";
            // 
            // dpDate
            // 
            this.dpDate.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dpDate.BorderSize = 3;
            this.dpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dpDate.CustomFormat = "dd/MM/yyyy";
            this.dpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDate.Location = new System.Drawing.Point(781, 12);
            this.dpDate.MinimumSize = new System.Drawing.Size(4, 60);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(228, 60);
            this.dpDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.dpDate.TabIndex = 16;
            this.dpDate.TextColor = System.Drawing.Color.Black;
            this.dpDate.ValueChanged += new System.EventHandler(this.dpDate_ValueChanged);
            // 
            // Index
            // 
            this.Index.FillWeight = 70F;
            this.Index.HeaderText = "Mã hóa đơn";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Họ và tên";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Disease
            // 
            this.Disease.HeaderText = "Bệnh";
            this.Disease.MinimumWidth = 6;
            this.Disease.Name = "Disease";
            this.Disease.ReadOnly = true;
            // 
            // DateExamine
            // 
            this.DateExamine.HeaderText = "Ngày khám";
            this.DateExamine.MinimumWidth = 6;
            this.DateExamine.Name = "DateExamine";
            this.DateExamine.ReadOnly = true;
            this.DateExamine.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Total
            // 
            this.Total.HeaderText = "Tổng tiền";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormListInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1084, 717);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblListPatient);
            this.Controls.Add(this.dGVListPatient);
            this.Controls.Add(this.lblDateExam);
            this.Name = "FormListInvoice";
            this.Text = "Danh sách hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListPatient;
        private System.Windows.Forms.DataGridView dGVListPatient;
        private System.Windows.Forms.Label lblDateExam;
        private RJCodeAdvance.RJControls.RJDatePicker dpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disease;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExamine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}