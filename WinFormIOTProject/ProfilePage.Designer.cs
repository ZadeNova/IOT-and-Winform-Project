﻿namespace WinFormIOTProject
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            this.UserProfile = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoleTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.DataStats = new System.Windows.Forms.GroupBox();
            this.PhnNoLbl = new System.Windows.Forms.Label();
            this.PhnNumberTxt = new System.Windows.Forms.TextBox();
            this.UserProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserProfile
            // 
            this.UserProfile.Controls.Add(this.PhnNumberTxt);
            this.UserProfile.Controls.Add(this.PhnNoLbl);
            this.UserProfile.Controls.Add(this.pictureBox1);
            this.UserProfile.Controls.Add(this.RoleTxt);
            this.UserProfile.Controls.Add(this.PasswordTxt);
            this.UserProfile.Controls.Add(this.EmailTxt);
            this.UserProfile.Controls.Add(this.UsernameTxt);
            this.UserProfile.Controls.Add(this.label4);
            this.UserProfile.Controls.Add(this.label3);
            this.UserProfile.Controls.Add(this.label2);
            this.UserProfile.Controls.Add(this.label1);
            this.UserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserProfile.Location = new System.Drawing.Point(36, 69);
            this.UserProfile.Name = "UserProfile";
            this.UserProfile.Size = new System.Drawing.Size(450, 463);
            this.UserProfile.TabIndex = 0;
            this.UserProfile.TabStop = false;
            this.UserProfile.Text = "UserProfile";
            this.UserProfile.Enter += new System.EventHandler(this.UserProfile_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 159);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // RoleTxt
            // 
            this.RoleTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleTxt.Location = new System.Drawing.Point(219, 358);
            this.RoleTxt.Name = "RoleTxt";
            this.RoleTxt.ReadOnly = true;
            this.RoleTxt.Size = new System.Drawing.Size(143, 23);
            this.RoleTxt.TabIndex = 7;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(219, 305);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.ReadOnly = true;
            this.PasswordTxt.Size = new System.Drawing.Size(143, 23);
            this.PasswordTxt.TabIndex = 6;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(219, 262);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.ReadOnly = true;
            this.EmailTxt.Size = new System.Drawing.Size(143, 23);
            this.EmailTxt.TabIndex = 5;
            this.EmailTxt.TextChanged += new System.EventHandler(this.EmailTxt_TextChanged);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(219, 212);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.ReadOnly = true;
            this.UsernameTxt.Size = new System.Drawing.Size(143, 23);
            this.UsernameTxt.TabIndex = 4;
            this.UsernameTxt.TextChanged += new System.EventHandler(this.UsernameTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Home
            // 
            this.Home.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(36, 22);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(86, 23);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // DataStats
            // 
            this.DataStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataStats.Location = new System.Drawing.Point(529, 69);
            this.DataStats.Name = "DataStats";
            this.DataStats.Size = new System.Drawing.Size(450, 463);
            this.DataStats.TabIndex = 2;
            this.DataStats.TabStop = false;
            this.DataStats.Text = "Statistics";
            // 
            // PhnNoLbl
            // 
            this.PhnNoLbl.AutoSize = true;
            this.PhnNoLbl.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhnNoLbl.Location = new System.Drawing.Point(105, 408);
            this.PhnNoLbl.Name = "PhnNoLbl";
            this.PhnNoLbl.Size = new System.Drawing.Size(104, 17);
            this.PhnNoLbl.TabIndex = 9;
            this.PhnNoLbl.Text = "Phone Number";
            // 
            // PhnNumberTxt
            // 
            this.PhnNumberTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhnNumberTxt.Location = new System.Drawing.Point(220, 408);
            this.PhnNumberTxt.Name = "PhnNumberTxt";
            this.PhnNumberTxt.ReadOnly = true;
            this.PhnNumberTxt.Size = new System.Drawing.Size(143, 23);
            this.PhnNumberTxt.TabIndex = 10;
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1014, 583);
            this.Controls.Add(this.DataStats);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.UserProfile);
            this.Name = "ProfilePage";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            this.UserProfile.ResumeLayout(false);
            this.UserProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox RoleTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.GroupBox DataStats;
        private System.Windows.Forms.TextBox PhnNumberTxt;
        private System.Windows.Forms.Label PhnNoLbl;
    }
}