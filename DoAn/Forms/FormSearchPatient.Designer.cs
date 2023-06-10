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
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListPatient
            // 
            this.lblListPatient.AutoSize = true;
            this.lblListPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblListPatient.Location = new System.Drawing.Point(77, 157);
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
            this.Sex,
            this.Birth,
            this.Address});
            this.dGVListPatient.Location = new System.Drawing.Point(83, 235);
            this.dGVListPatient.Name = "dGVListPatient";
            this.dGVListPatient.RowHeadersWidth = 51;
            this.dGVListPatient.RowTemplate.Height = 24;
            this.dGVListPatient.Size = new System.Drawing.Size(947, 382);
            this.dGVListPatient.TabIndex = 6;
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
            // DateExamine
            // 
            this.DateExamine.HeaderText = "Ngày khám";
            this.DateExamine.MinimumWidth = 6;
            this.DateExamine.Name = "DateExamine";
            // 
            // Sex
            // 
            this.Sex.FillWeight = 70F;
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
            this.txtName.Location = new System.Drawing.Point(213, 53);
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
            this.label1.Location = new System.Drawing.Point(77, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Họ và tên";
            // 
            // FormSearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1084, 717);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}