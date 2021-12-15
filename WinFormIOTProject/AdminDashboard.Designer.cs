namespace WinFormIOTProject
{
    partial class AdminDashboard
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
            this.panelAdminMenu = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ManageUserBtn = new FontAwesome.Sharp.IconButton();
            this.Createuser = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Notification = new FontAwesome.Sharp.IconButton();
            this.Settings = new FontAwesome.Sharp.IconButton();
            this.SubmenuData = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DataGraphBtn = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Button();
            this.AdminLogo = new System.Windows.Forms.Panel();
            this.panelChildForms = new System.Windows.Forms.Panel();
            this.UserSettingsbtn = new FontAwesome.Sharp.IconButton();
            this.Logout = new FontAwesome.Sharp.IconButton();
            this.ProfileBtn = new FontAwesome.Sharp.IconButton();
            this.panelAdminMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SubmenuData.SuspendLayout();
            this.panelChildForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdminMenu
            // 
            this.panelAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(26)))), ((int)(((byte)(255)))));
            this.panelAdminMenu.Controls.Add(this.iconPictureBox1);
            this.panelAdminMenu.Controls.Add(this.ManageUserBtn);
            this.panelAdminMenu.Controls.Add(this.Createuser);
            this.panelAdminMenu.Controls.Add(this.iconButton1);
            this.panelAdminMenu.Controls.Add(this.Notification);
            this.panelAdminMenu.Controls.Add(this.Settings);
            this.panelAdminMenu.Controls.Add(this.SubmenuData);
            this.panelAdminMenu.Controls.Add(this.Data);
            this.panelAdminMenu.Controls.Add(this.AdminLogo);
            this.panelAdminMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminMenu.Location = new System.Drawing.Point(0, 0);
            this.panelAdminMenu.Name = "panelAdminMenu";
            this.panelAdminMenu.Size = new System.Drawing.Size(200, 633);
            this.panelAdminMenu.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(26)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 90);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 20;
            this.iconPictureBox1.TabStop = false;
            // 
            // ManageUserBtn
            // 
            this.ManageUserBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageUserBtn.FlatAppearance.BorderSize = 0;
            this.ManageUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.ManageUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageUserBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUserBtn.ForeColor = System.Drawing.Color.Aquamarine;
            this.ManageUserBtn.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.ManageUserBtn.IconColor = System.Drawing.Color.Gray;
            this.ManageUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ManageUserBtn.IconSize = 40;
            this.ManageUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageUserBtn.Location = new System.Drawing.Point(0, 462);
            this.ManageUserBtn.Name = "ManageUserBtn";
            this.ManageUserBtn.Size = new System.Drawing.Size(200, 54);
            this.ManageUserBtn.TabIndex = 19;
            this.ManageUserBtn.Text = "Manage User";
            this.ManageUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageUserBtn.UseVisualStyleBackColor = true;
            this.ManageUserBtn.Click += new System.EventHandler(this.ManageUserBtn_Click);
            // 
            // Createuser
            // 
            this.Createuser.Dock = System.Windows.Forms.DockStyle.Top;
            this.Createuser.FlatAppearance.BorderSize = 0;
            this.Createuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.Createuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Createuser.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createuser.ForeColor = System.Drawing.Color.Aquamarine;
            this.Createuser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Createuser.IconColor = System.Drawing.Color.Gray;
            this.Createuser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Createuser.IconSize = 40;
            this.Createuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Createuser.Location = new System.Drawing.Point(0, 408);
            this.Createuser.Name = "Createuser";
            this.Createuser.Size = new System.Drawing.Size(200, 54);
            this.Createuser.TabIndex = 18;
            this.Createuser.Text = "Create User";
            this.Createuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Createuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Createuser.UseVisualStyleBackColor = true;
            this.Createuser.Click += new System.EventHandler(this.Createuser_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Aquamarine;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.iconButton1.IconColor = System.Drawing.Color.Gray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 354);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 54);
            this.iconButton1.TabIndex = 17;
            this.iconButton1.Text = "Generate Report";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Notification
            // 
            this.Notification.Dock = System.Windows.Forms.DockStyle.Top;
            this.Notification.FlatAppearance.BorderSize = 0;
            this.Notification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.Notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification.ForeColor = System.Drawing.Color.Aquamarine;
            this.Notification.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.Notification.IconColor = System.Drawing.Color.Gray;
            this.Notification.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Notification.IconSize = 40;
            this.Notification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Notification.Location = new System.Drawing.Point(0, 300);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(200, 54);
            this.Notification.TabIndex = 16;
            this.Notification.Text = "Notification";
            this.Notification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Notification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Notification.UseVisualStyleBackColor = true;
            this.Notification.Click += new System.EventHandler(this.Notification_Click_1);
            // 
            // Settings
            // 
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.Aquamarine;
            this.Settings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.Settings.IconColor = System.Drawing.Color.Gray;
            this.Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Settings.IconSize = 40;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(0, 246);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(200, 54);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click_1);
            // 
            // SubmenuData
            // 
            this.SubmenuData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(26)))), ((int)(((byte)(255)))));
            this.SubmenuData.Controls.Add(this.button5);
            this.SubmenuData.Controls.Add(this.button4);
            this.SubmenuData.Controls.Add(this.button3);
            this.SubmenuData.Controls.Add(this.DataGraphBtn);
            this.SubmenuData.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuData.Location = new System.Drawing.Point(0, 128);
            this.SubmenuData.Name = "SubmenuData";
            this.SubmenuData.Size = new System.Drawing.Size(200, 118);
            this.SubmenuData.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Aquamarine;
            this.button5.Location = new System.Drawing.Point(0, 69);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(200, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "PRI";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Aquamarine;
            this.button4.Location = new System.Drawing.Point(0, 46);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(200, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "UltraSonic";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Aquamarine;
            this.button3.Location = new System.Drawing.Point(0, 23);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "RFID";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DataGraphBtn
            // 
            this.DataGraphBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGraphBtn.FlatAppearance.BorderSize = 0;
            this.DataGraphBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DataGraphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataGraphBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGraphBtn.ForeColor = System.Drawing.Color.Aquamarine;
            this.DataGraphBtn.Location = new System.Drawing.Point(0, 0);
            this.DataGraphBtn.Name = "DataGraphBtn";
            this.DataGraphBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.DataGraphBtn.Size = new System.Drawing.Size(200, 23);
            this.DataGraphBtn.TabIndex = 0;
            this.DataGraphBtn.Text = "Graphs/Data";
            this.DataGraphBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataGraphBtn.UseVisualStyleBackColor = true;
            this.DataGraphBtn.Click += new System.EventHandler(this.DataGraphBtn_Click);
            // 
            // Data
            // 
            this.Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.Data.FlatAppearance.BorderSize = 0;
            this.Data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Data.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.Color.Aquamarine;
            this.Data.Location = new System.Drawing.Point(0, 78);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Data.Size = new System.Drawing.Size(200, 50);
            this.Data.TabIndex = 6;
            this.Data.Text = "Data ";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // AdminLogo
            // 
            this.AdminLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdminLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminLogo.Location = new System.Drawing.Point(0, 0);
            this.AdminLogo.Name = "AdminLogo";
            this.AdminLogo.Size = new System.Drawing.Size(200, 78);
            this.AdminLogo.TabIndex = 5;
            // 
            // panelChildForms
            // 
            this.panelChildForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.panelChildForms.Controls.Add(this.UserSettingsbtn);
            this.panelChildForms.Controls.Add(this.Logout);
            this.panelChildForms.Controls.Add(this.ProfileBtn);
            this.panelChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForms.Location = new System.Drawing.Point(200, 0);
            this.panelChildForms.Name = "panelChildForms";
            this.panelChildForms.Size = new System.Drawing.Size(1080, 633);
            this.panelChildForms.TabIndex = 1;
            // 
            // UserSettingsbtn
            // 
            this.UserSettingsbtn.FlatAppearance.BorderSize = 0;
            this.UserSettingsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.UserSettingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSettingsbtn.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.UserSettingsbtn.IconColor = System.Drawing.Color.LightSeaGreen;
            this.UserSettingsbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserSettingsbtn.IconSize = 40;
            this.UserSettingsbtn.Location = new System.Drawing.Point(931, 2);
            this.UserSettingsbtn.Name = "UserSettingsbtn";
            this.UserSettingsbtn.Size = new System.Drawing.Size(47, 43);
            this.UserSettingsbtn.TabIndex = 3;
            this.UserSettingsbtn.UseVisualStyleBackColor = true;
            this.UserSettingsbtn.Click += new System.EventHandler(this.UserSettingsbtn_Click);
            // 
            // Logout
            // 
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Logout.IconColor = System.Drawing.Color.LightSeaGreen;
            this.Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Logout.IconSize = 40;
            this.Logout.Location = new System.Drawing.Point(1034, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(46, 46);
            this.Logout.TabIndex = 2;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.FlatAppearance.BorderSize = 0;
            this.ProfileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileBtn.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.ProfileBtn.IconColor = System.Drawing.Color.LightSeaGreen;
            this.ProfileBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProfileBtn.IconSize = 40;
            this.ProfileBtn.Location = new System.Drawing.Point(984, 0);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(44, 46);
            this.ProfileBtn.TabIndex = 1;
            this.ProfileBtn.UseVisualStyleBackColor = true;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 633);
            this.Controls.Add(this.panelChildForms);
            this.Controls.Add(this.panelAdminMenu);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelAdminMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.SubmenuData.ResumeLayout(false);
            this.panelChildForms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdminMenu;
        private System.Windows.Forms.Panel AdminLogo;
        private System.Windows.Forms.Panel SubmenuData;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DataGraphBtn;
        private System.Windows.Forms.Panel panelChildForms;
        private FontAwesome.Sharp.IconButton Settings;
        private FontAwesome.Sharp.IconButton ManageUserBtn;
        private FontAwesome.Sharp.IconButton Createuser;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton Notification;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button Data;
        private FontAwesome.Sharp.IconButton ProfileBtn;
        private FontAwesome.Sharp.IconButton Logout;
        private FontAwesome.Sharp.IconButton UserSettingsbtn;
    }
}