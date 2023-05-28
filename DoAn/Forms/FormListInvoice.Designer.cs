﻿namespace DoAn.Forms
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
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.lblDateExam = new System.Windows.Forms.Label();
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
            this.txtName.Location = new System.Drawing.Point(181, 73);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ và tên";
            // 
            // lblListPatient
            // 
            this.lblListPatient.AutoSize = true;
            this.lblListPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblListPatient.Location = new System.Drawing.Point(41, 203);
            this.lblListPatient.Name = "lblListPatient";
            this.lblListPatient.Size = new System.Drawing.Size(248, 31);
            this.lblListPatient.TabIndex = 13;
            this.lblListPatient.Text = "Danh sách hóa đơn";
            // 
            // dGVListPatient
            // 
            this.dGVListPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.LastName,
            this.Sex,
            this.Birth,
            this.Address});
            this.dGVListPatient.Location = new System.Drawing.Point(97, 279);
            this.dGVListPatient.Name = "dGVListPatient";
            this.dGVListPatient.RowHeadersWidth = 51;
            this.dGVListPatient.RowTemplate.Height = 24;
            this.dGVListPatient.Size = new System.Drawing.Size(947, 382);
            this.dGVListPatient.TabIndex = 12;
            // 
            // Index
            // 
            this.Index.FillWeight = 70F;
            this.Index.HeaderText = "Mã hóa đơn";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Họ và tên";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Ngày khám";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Ngày thanh toán";
            this.Birth.MinimumWidth = 6;
            this.Birth.Name = "Birth";
            this.Birth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Address
            // 
            this.Address.HeaderText = "Tổng tiền";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dpDate
            // 
            this.dpDate.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dpDate.BorderSize = 3;
            this.dpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dpDate.Location = new System.Drawing.Point(604, 56);
            this.dpDate.MinimumSize = new System.Drawing.Size(4, 60);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(382, 60);
            this.dpDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.dpDate.TabIndex = 11;
            this.dpDate.TextColor = System.Drawing.Color.Black;
            // 
            // lblDateExam
            // 
            this.lblDateExam.AutoSize = true;
            this.lblDateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDateExam.Location = new System.Drawing.Point(447, 73);
            this.lblDateExam.Name = "lblDateExam";
            this.lblDateExam.Size = new System.Drawing.Size(151, 31);
            this.lblDateExam.TabIndex = 10;
            this.lblDateExam.Text = "Ngày khám";
            // 
            // FormListInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1084, 717);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblListPatient);
            this.Controls.Add(this.dGVListPatient);
            this.Controls.Add(this.dpDate);
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
        private RJCodeAdvance.RJControls.RJDatePicker dpDate;
        private System.Windows.Forms.Label lblDateExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}