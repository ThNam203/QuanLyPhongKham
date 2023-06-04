namespace DoAn.Forms
{
    partial class FormMakeInvoice
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
            this.dpDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.lblDateExam = new System.Windows.Forms.Label();
            this.dGVListMedicalBill = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblListMedicalBill = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListMedicalBill)).BeginInit();
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
            this.txtName.TabIndex = 13;
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
            this.label1.TabIndex = 12;
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
            this.dpDate.Location = new System.Drawing.Point(781, 12);
            this.dpDate.MinimumSize = new System.Drawing.Size(4, 60);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(228, 60);
            this.dpDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.dpDate.TabIndex = 11;
            this.dpDate.TextColor = System.Drawing.Color.Black;
            this.dpDate.ValueChanged += new System.EventHandler(this.dpDate_ValueChanged);
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
            // dGVListMedicalBill
            // 
            this.dGVListMedicalBill.AllowUserToResizeColumns = false;
            this.dGVListMedicalBill.AllowUserToResizeRows = false;
            this.dGVListMedicalBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListMedicalBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListMedicalBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.PatientName,
            this.Disease,
            this.Total,
            this.IsPaid});
            this.dGVListMedicalBill.Location = new System.Drawing.Point(72, 172);
            this.dGVListMedicalBill.Name = "dGVListMedicalBill";
            this.dGVListMedicalBill.ReadOnly = true;
            this.dGVListMedicalBill.RowHeadersWidth = 51;
            this.dGVListMedicalBill.RowTemplate.Height = 24;
            this.dGVListMedicalBill.Size = new System.Drawing.Size(937, 460);
            this.dGVListMedicalBill.TabIndex = 14;
            this.dGVListMedicalBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVListMedicalBill_CellDoubleClick);
            // 
            // Index
            // 
            this.Index.FillWeight = 60F;
            this.Index.HeaderText = "Mã phiếu";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PatientName
            // 
            this.PatientName.FillWeight = 87.91444F;
            this.PatientName.HeaderText = "Tên bệnh nhân";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Disease
            // 
            this.Disease.FillWeight = 87.91444F;
            this.Disease.HeaderText = "Bệnh";
            this.Disease.MinimumWidth = 6;
            this.Disease.Name = "Disease";
            this.Disease.ReadOnly = true;
            this.Disease.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Total
            // 
            this.Total.HeaderText = "Tổng tiền";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // IsPaid
            // 
            this.IsPaid.FillWeight = 87.91444F;
            this.IsPaid.HeaderText = "Đã thanh toán";
            this.IsPaid.MinimumWidth = 6;
            this.IsPaid.Name = "IsPaid";
            this.IsPaid.ReadOnly = true;
            this.IsPaid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsPaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblListMedicalBill
            // 
            this.lblListMedicalBill.AutoSize = true;
            this.lblListMedicalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblListMedicalBill.Location = new System.Drawing.Point(24, 106);
            this.lblListMedicalBill.Name = "lblListMedicalBill";
            this.lblListMedicalBill.Size = new System.Drawing.Size(357, 31);
            this.lblListMedicalBill.TabIndex = 15;
            this.lblListMedicalBill.Text = "Danh sách phiếu khám bệnh";
            // 
            // FormMakeInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1084, 717);
            this.Controls.Add(this.lblListMedicalBill);
            this.Controls.Add(this.dGVListMedicalBill);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.lblDateExam);
            this.Name = "FormMakeInvoice";
            this.Text = "Lập hóa đơn thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListMedicalBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJDatePicker dpDate;
        private System.Windows.Forms.Label lblDateExam;
        private System.Windows.Forms.DataGridView dGVListMedicalBill;
        private System.Windows.Forms.Label lblListMedicalBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disease;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPaid;
    }
}