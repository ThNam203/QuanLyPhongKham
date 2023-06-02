namespace DoAn.Forms.SmallForms
{
    partial class FormPatientDetail
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSex = new MaterialSkin.Controls.MaterialComboBox();
            this.dpDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.lblDateExam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.btnReset = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "#123";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 32;
            this.btnMinimize.Location = new System.Drawing.Point(389, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 44);
            this.btnMinimize.TabIndex = 33;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 32;
            this.btnClose.Location = new System.Drawing.Point(439, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 44);
            this.btnClose.TabIndex = 32;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.btnHome.Image = global::DoAn.Properties.Resources.Logo123;
            this.btnHome.Location = new System.Drawing.Point(123, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(192, 150);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 34;
            this.btnHome.TabStop = false;
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
            this.txtName.Location = new System.Drawing.Point(194, 209);
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
            this.txtName.TabIndex = 36;
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
            this.label1.Location = new System.Drawing.Point(37, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(37, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "Giới tính";
            // 
            // txtSex
            // 
            this.txtSex.AutoResize = false;
            this.txtSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSex.Depth = 0;
            this.txtSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtSex.DropDownHeight = 118;
            this.txtSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSex.DropDownWidth = 121;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSex.FormattingEnabled = true;
            this.txtSex.IntegralHeight = false;
            this.txtSex.ItemHeight = 29;
            this.txtSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtSex.Location = new System.Drawing.Point(194, 275);
            this.txtSex.MaxDropDownItems = 4;
            this.txtSex.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(250, 35);
            this.txtSex.StartIndex = 0;
            this.txtSex.TabIndex = 38;
            this.txtSex.UseAccent = false;
            this.txtSex.UseTallSize = false;
            // 
            // dpDate
            // 
            this.dpDate.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dpDate.BorderSize = 3;
            this.dpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dpDate.CustomFormat = "dd/MM/yyyy";
            this.dpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDate.Location = new System.Drawing.Point(194, 336);
            this.dpDate.MinimumSize = new System.Drawing.Size(4, 60);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(250, 60);
            this.dpDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.dpDate.TabIndex = 40;
            this.dpDate.TextColor = System.Drawing.Color.Black;
            // 
            // lblDateExam
            // 
            this.lblDateExam.AutoSize = true;
            this.lblDateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDateExam.Location = new System.Drawing.Point(37, 353);
            this.lblDateExam.Name = "lblDateExam";
            this.lblDateExam.Size = new System.Drawing.Size(135, 31);
            this.lblDateExam.TabIndex = 39;
            this.lblDateExam.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(37, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 31);
            this.label3.TabIndex = 41;
            this.label3.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Depth = 0;
            this.txtAddress.HideSelection = true;
            this.txtAddress.Hint = "Nhập địa chỉ";
            this.txtAddress.Location = new System.Drawing.Point(194, 429);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(250, 100);
            this.txtAddress.TabIndex = 42;
            this.txtAddress.TabStop = false;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.UseSystemPasswordChar = false;
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
            this.btnSave.Location = new System.Drawing.Point(356, 579);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 40);
            this.btnSave.TabIndex = 44;
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
            this.btnReset.Location = new System.Drawing.Point(243, 579);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 40);
            this.btnReset.TabIndex = 43;
            this.btnReset.Text = "Hủy";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(489, 656);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.lblDateExam);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPatientDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPatientDetail";
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.PictureBox btnHome;
        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox txtSex;
        private RJCodeAdvance.RJControls.RJDatePicker dpDate;
        private System.Windows.Forms.Label lblDateExam;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtAddress;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private RJCodeAdvance.RJControls.RJButton btnReset;
    }
}