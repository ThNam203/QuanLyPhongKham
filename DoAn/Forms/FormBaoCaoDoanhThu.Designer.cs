namespace DoAn.Forms
{
    partial class FormBaoCaoDoanhThu
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
            this.cbbMonth = new RJCodeAdvance.RJControls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVListRevenue = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new RJCodeAdvance.RJControls.RJButton();
            this.txtYear = new MaterialSkin.Controls.MaterialTextBox2();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListRevenue)).BeginInit();
            this.SuspendLayout();
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
            this.cbbMonth.TabIndex = 75;
            this.cbbMonth.Texts = "";
            this.cbbMonth.OnSelectedIndexChanged += new System.EventHandler(this.cbbMonth_OnSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 74;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(67, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 31);
            this.label2.TabIndex = 76;
            this.label2.Text = "Báo cáo doanh thu";
            // 
            // dGVListRevenue
            // 
            this.dGVListRevenue.AllowUserToAddRows = false;
            this.dGVListRevenue.AllowUserToDeleteRows = false;
            this.dGVListRevenue.AllowUserToResizeColumns = false;
            this.dGVListRevenue.AllowUserToResizeRows = false;
            this.dGVListRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.PatientNumber,
            this.Revenue,
            this.Percent});
            this.dGVListRevenue.Location = new System.Drawing.Point(73, 180);
            this.dGVListRevenue.Name = "dGVListRevenue";
            this.dGVListRevenue.ReadOnly = true;
            this.dGVListRevenue.RowHeadersWidth = 51;
            this.dGVListRevenue.RowTemplate.Height = 24;
            this.dGVListRevenue.Size = new System.Drawing.Size(937, 460);
            this.dGVListRevenue.TabIndex = 77;
            // 
            // Day
            // 
            this.Day.FillWeight = 60F;
            this.Day.HeaderText = "Ngày";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PatientNumber
            // 
            this.PatientNumber.FillWeight = 87.91444F;
            this.PatientNumber.HeaderText = "Số lượng bệnh nhân";
            this.PatientNumber.MinimumWidth = 6;
            this.PatientNumber.Name = "PatientNumber";
            this.PatientNumber.ReadOnly = true;
            this.PatientNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Revenue
            // 
            this.Revenue.FillWeight = 87.91444F;
            this.Revenue.HeaderText = "Doanh thu";
            this.Revenue.MinimumWidth = 6;
            this.Revenue.Name = "Revenue";
            this.Revenue.ReadOnly = true;
            this.Revenue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "Tỷ lệ";
            this.Percent.MinimumWidth = 6;
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
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
            this.btnSearch.Location = new System.Drawing.Point(913, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 81;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtYear.Location = new System.Drawing.Point(610, 45);
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
            this.txtYear.TabIndex = 80;
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
            this.label3.Location = new System.Drawing.Point(522, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 31);
            this.label3.TabIndex = 79;
            this.label3.Text = "Năm";
            // 
            // FormBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1084, 717);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dGVListRevenue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCaoDoanhThu";
            this.Text = "FormBaoCaoDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJComboBox cbbMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVListRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private RJCodeAdvance.RJControls.RJButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox2 txtYear;
        private System.Windows.Forms.Label label3;
    }
}