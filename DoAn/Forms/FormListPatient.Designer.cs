﻿namespace DoAn.Forms
{
    partial class FormListPatient
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
            this.dpDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.dGVListPatient = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListPatient = new System.Windows.Forms.Label();
            this.btnAddPatient = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateExam
            // 
            this.lblDateExam.AutoSize = true;
            this.lblDateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDateExam.Location = new System.Drawing.Point(83, 29);
            this.lblDateExam.Name = "lblDateExam";
            this.lblDateExam.Size = new System.Drawing.Size(151, 31);
            this.lblDateExam.TabIndex = 0;
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
            this.dpDate.Location = new System.Drawing.Point(89, 97);
            this.dpDate.MinimumSize = new System.Drawing.Size(4, 60);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(272, 60);
            this.dpDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.dpDate.TabIndex = 1;
            this.dpDate.TextColor = System.Drawing.Color.Black;
            this.dpDate.ValueChanged += new System.EventHandler(this.dpDate_ValueChanged);
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
            this.Sex,
            this.Birth,
            this.Address});
            this.dGVListPatient.Location = new System.Drawing.Point(89, 266);
            this.dGVListPatient.Name = "dGVListPatient";
            this.dGVListPatient.RowHeadersWidth = 51;
            this.dGVListPatient.RowTemplate.Height = 24;
            this.dGVListPatient.Size = new System.Drawing.Size(926, 382);
            this.dGVListPatient.TabIndex = 2;
            this.dGVListPatient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVListPatient_CellDoubleClick);
            // 
            // Index
            // 
            this.Index.HeaderText = "Mã bệnh nhân";
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
            this.Sex.HeaderText = "Giới tính";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Ngày sinh";
            this.Birth.MinimumWidth = 6;
            this.Birth.Name = "Birth";
            this.Birth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblListPatient
            // 
            this.lblListPatient.AutoSize = true;
            this.lblListPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblListPatient.Location = new System.Drawing.Point(83, 199);
            this.lblListPatient.Name = "lblListPatient";
            this.lblListPatient.Size = new System.Drawing.Size(278, 31);
            this.lblListPatient.TabIndex = 3;
            this.lblListPatient.Text = "Danh sách bệnh nhân";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddPatient.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddPatient.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddPatient.BorderRadius = 10;
            this.btnAddPatient.BorderSize = 0;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Location = new System.Drawing.Point(865, 199);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(150, 36);
            this.btnAddPatient.TabIndex = 76;
            this.btnAddPatient.Text = "Thêm bệnh nhân";
            this.btnAddPatient.TextColor = System.Drawing.Color.White;
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // FormListPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1084, 717);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.lblListPatient);
            this.Controls.Add(this.dGVListPatient);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.lblDateExam);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormListPatient";
            this.Text = "Danh sách khám bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateExam;
        private RJCodeAdvance.RJControls.RJDatePicker dpDate;
        private System.Windows.Forms.DataGridView dGVListPatient;
        private System.Windows.Forms.Label lblListPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private RJCodeAdvance.RJControls.RJButton btnAddPatient;
    }
}