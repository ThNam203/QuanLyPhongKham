namespace DoAn
{
    partial class Form1
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_Dashboard = new FontAwesome.Sharp.IconButton();
            this.btn_Setting = new FontAwesome.Sharp.IconButton();
            this.btn_MakeListGetMedicine = new FontAwesome.Sharp.IconButton();
            this.btn_SearchPatient = new FontAwesome.Sharp.IconButton();
            this.btn_MakeListExamine = new FontAwesome.Sharp.IconButton();
            this.btnListInvoice = new FontAwesome.Sharp.IconButton();
            this.btn_MakeInvoice = new FontAwesome.Sharp.IconButton();
            this.btn_ListPatient = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelDesktop);
            this.panelContainer.Controls.Add(this.panelShadow);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Controls.Add(this.panelMenu);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1282, 853);
            this.panelContainer.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(280, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1002, 764);
            this.panelDesktop.TabIndex = 3;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(212)))), ((int)(((byte)(143)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(280, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1002, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(212)))), ((int)(((byte)(143)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(280, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1002, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(212)))), ((int)(((byte)(143)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 32;
            this.btnMinimize.Location = new System.Drawing.Point(855, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 44);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(212)))), ((int)(((byte)(143)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 32;
            this.btnClose.Location = new System.Drawing.Point(927, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 44);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Black;
            this.lblTitleChildForm.Location = new System.Drawing.Point(81, 24);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(81, 29);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(43, 24);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.panelMenu.Controls.Add(this.btn_Dashboard);
            this.panelMenu.Controls.Add(this.btn_Setting);
            this.panelMenu.Controls.Add(this.btn_MakeListGetMedicine);
            this.panelMenu.Controls.Add(this.btn_SearchPatient);
            this.panelMenu.Controls.Add(this.btn_MakeListExamine);
            this.panelMenu.Controls.Add(this.btnListInvoice);
            this.panelMenu.Controls.Add(this.btn_MakeInvoice);
            this.panelMenu.Controls.Add(this.btn_ListPatient);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Black;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(280, 853);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.ForeColor = System.Drawing.Color.Black;
            this.btn_Dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btn_Dashboard.IconColor = System.Drawing.Color.Black;
            this.btn_Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 620);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Dashboard.Size = new System.Drawing.Size(280, 60);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "Thống kê";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.btn_Setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.ForeColor = System.Drawing.Color.Black;
            this.btn_Setting.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btn_Setting.IconColor = System.Drawing.Color.Black;
            this.btn_Setting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.Location = new System.Drawing.Point(0, 560);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Setting.Size = new System.Drawing.Size(280, 60);
            this.btn_Setting.TabIndex = 7;
            this.btn_Setting.Text = "Thay đổi quy định";
            this.btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_MakeListGetMedicine
            // 
            this.btn_MakeListGetMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.btn_MakeListGetMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MakeListGetMedicine.FlatAppearance.BorderSize = 0;
            this.btn_MakeListGetMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MakeListGetMedicine.ForeColor = System.Drawing.Color.Black;
            this.btn_MakeListGetMedicine.IconChar = FontAwesome.Sharp.IconChar.FirstAid;
            this.btn_MakeListGetMedicine.IconColor = System.Drawing.Color.Black;
            this.btn_MakeListGetMedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MakeListGetMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MakeListGetMedicine.Location = new System.Drawing.Point(0, 500);
            this.btn_MakeListGetMedicine.Name = "btn_MakeListGetMedicine";
            this.btn_MakeListGetMedicine.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_MakeListGetMedicine.Size = new System.Drawing.Size(280, 60);
            this.btn_MakeListGetMedicine.TabIndex = 4;
            this.btn_MakeListGetMedicine.Text = "Lập phiếu nhập thuốc";
            this.btn_MakeListGetMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MakeListGetMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MakeListGetMedicine.UseVisualStyleBackColor = false;
            this.btn_MakeListGetMedicine.Click += new System.EventHandler(this.btn_MakeListGetMedicine_Click);
            // 
            // btn_SearchPatient
            // 
            this.btn_SearchPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.btn_SearchPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SearchPatient.FlatAppearance.BorderSize = 0;
            this.btn_SearchPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchPatient.ForeColor = System.Drawing.Color.Black;
            this.btn_SearchPatient.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_SearchPatient.IconColor = System.Drawing.Color.Black;
            this.btn_SearchPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SearchPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchPatient.Location = new System.Drawing.Point(0, 440);
            this.btn_SearchPatient.Name = "btn_SearchPatient";
            this.btn_SearchPatient.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_SearchPatient.Size = new System.Drawing.Size(280, 60);
            this.btn_SearchPatient.TabIndex = 6;
            this.btn_SearchPatient.Text = "Tra cứu bệnh nhân";
            this.btn_SearchPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SearchPatient.UseVisualStyleBackColor = false;
            this.btn_SearchPatient.Click += new System.EventHandler(this.btn_SearchPatient_Click);
            // 
            // btn_MakeListExamine
            // 
            this.btn_MakeListExamine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.btn_MakeListExamine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MakeListExamine.FlatAppearance.BorderSize = 0;
            this.btn_MakeListExamine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MakeListExamine.ForeColor = System.Drawing.Color.Black;
            this.btn_MakeListExamine.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.btn_MakeListExamine.IconColor = System.Drawing.Color.Black;
            this.btn_MakeListExamine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MakeListExamine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MakeListExamine.Location = new System.Drawing.Point(0, 380);
            this.btn_MakeListExamine.Name = "btn_MakeListExamine";
            this.btn_MakeListExamine.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_MakeListExamine.Size = new System.Drawing.Size(280, 60);
            this.btn_MakeListExamine.TabIndex = 3;
            this.btn_MakeListExamine.Text = "Lập phiếu khám bệnh";
            this.btn_MakeListExamine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MakeListExamine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MakeListExamine.UseVisualStyleBackColor = false;
            this.btn_MakeListExamine.Click += new System.EventHandler(this.btn_MakeListExamine_Click);
            // 
            // btnListInvoice
            // 
            this.btnListInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.btnListInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListInvoice.FlatAppearance.BorderSize = 0;
            this.btnListInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnListInvoice.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnListInvoice.IconColor = System.Drawing.Color.Black;
            this.btnListInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListInvoice.Location = new System.Drawing.Point(0, 320);
            this.btnListInvoice.Name = "btnListInvoice";
            this.btnListInvoice.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnListInvoice.Size = new System.Drawing.Size(280, 60);
            this.btnListInvoice.TabIndex = 9;
            this.btnListInvoice.Text = "Danh sách hóa đơn";
            this.btnListInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListInvoice.UseVisualStyleBackColor = false;
            this.btnListInvoice.Click += new System.EventHandler(this.btnListInvoice_Click);
            // 
            // btn_MakeInvoice
            // 
            this.btn_MakeInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.btn_MakeInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MakeInvoice.FlatAppearance.BorderSize = 0;
            this.btn_MakeInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MakeInvoice.ForeColor = System.Drawing.Color.Black;
            this.btn_MakeInvoice.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btn_MakeInvoice.IconColor = System.Drawing.Color.Black;
            this.btn_MakeInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MakeInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MakeInvoice.Location = new System.Drawing.Point(0, 260);
            this.btn_MakeInvoice.Name = "btn_MakeInvoice";
            this.btn_MakeInvoice.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_MakeInvoice.Size = new System.Drawing.Size(280, 60);
            this.btn_MakeInvoice.TabIndex = 5;
            this.btn_MakeInvoice.Text = "Lập hóa đơn thanh toán";
            this.btn_MakeInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MakeInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MakeInvoice.UseVisualStyleBackColor = false;
            this.btn_MakeInvoice.Click += new System.EventHandler(this.btn_MakeInvoice_Click);
            // 
            // btn_ListPatient
            // 
            this.btn_ListPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.btn_ListPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ListPatient.FlatAppearance.BorderSize = 0;
            this.btn_ListPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListPatient.ForeColor = System.Drawing.Color.Black;
            this.btn_ListPatient.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.btn_ListPatient.IconColor = System.Drawing.Color.Black;
            this.btn_ListPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ListPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListPatient.Location = new System.Drawing.Point(0, 200);
            this.btn_ListPatient.Name = "btn_ListPatient";
            this.btn_ListPatient.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_ListPatient.Size = new System.Drawing.Size(280, 60);
            this.btn_ListPatient.TabIndex = 2;
            this.btn_ListPatient.Text = "Danh sách khám bệnh";
            this.btn_ListPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ListPatient.UseVisualStyleBackColor = false;
            this.btn_ListPatient.Click += new System.EventHandler(this.btn_ListPatient_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(0, 745);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(280, 108);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(280, 200);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = global::DoAn.Properties.Resources.Logo123;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(280, 200);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.panelContainer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelContainer.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_Setting;
        private FontAwesome.Sharp.IconButton btn_SearchPatient;
        private FontAwesome.Sharp.IconButton btn_MakeInvoice;
        private FontAwesome.Sharp.IconButton btn_MakeListGetMedicine;
        private FontAwesome.Sharp.IconButton btn_MakeListExamine;
        private FontAwesome.Sharp.IconButton btn_ListPatient;
        private FontAwesome.Sharp.IconButton btn_Dashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnListInvoice;
    }
}

