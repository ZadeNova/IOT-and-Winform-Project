namespace WinFormIOTProject
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
            this.UserProfile = new System.Windows.Forms.GroupBox();
            this.PhnNumberTxt = new System.Windows.Forms.TextBox();
            this.PhnNoLbl = new System.Windows.Forms.Label();
            this.RoleTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.Updateusergrp = new System.Windows.Forms.GroupBox();
            this.Updateusernametxt = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new FontAwesome.Sharp.IconButton();
            this.PhoneNumupdatelbl = new System.Windows.Forms.Label();
            this.Roleupdatelbl = new System.Windows.Forms.Label();
            this.Emailupdatelbl = new System.Windows.Forms.Label();
            this.Usernameupdatelbl = new System.Windows.Forms.Label();
            this.UpdatePhoneTxt = new System.Windows.Forms.TextBox();
            this.UpdateRoletxt = new System.Windows.Forms.TextBox();
            this.UpdateEmailTxt = new System.Windows.Forms.TextBox();
            this.updateuserlbl = new System.Windows.Forms.Label();
            this.Updatepassbtn = new System.Windows.Forms.Button();
            this.UserProfile.SuspendLayout();
            this.Updateusergrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserProfile
            // 
            this.UserProfile.Controls.Add(this.PhnNumberTxt);
            this.UserProfile.Controls.Add(this.PhnNoLbl);
            this.UserProfile.Controls.Add(this.RoleTxt);
            this.UserProfile.Controls.Add(this.EmailTxt);
            this.UserProfile.Controls.Add(this.UsernameTxt);
            this.UserProfile.Controls.Add(this.label4);
            this.UserProfile.Controls.Add(this.label2);
            this.UserProfile.Controls.Add(this.label1);
            this.UserProfile.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserProfile.Location = new System.Drawing.Point(36, 69);
            this.UserProfile.Name = "UserProfile";
            this.UserProfile.Size = new System.Drawing.Size(450, 463);
            this.UserProfile.TabIndex = 0;
            this.UserProfile.TabStop = false;
            this.UserProfile.Text = "UserProfile";
            this.UserProfile.Enter += new System.EventHandler(this.UserProfile_Enter);
            // 
            // PhnNumberTxt
            // 
            this.PhnNumberTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhnNumberTxt.Location = new System.Drawing.Point(210, 287);
            this.PhnNumberTxt.Name = "PhnNumberTxt";
            this.PhnNumberTxt.ReadOnly = true;
            this.PhnNumberTxt.Size = new System.Drawing.Size(143, 23);
            this.PhnNumberTxt.TabIndex = 10;
            // 
            // PhnNoLbl
            // 
            this.PhnNoLbl.AutoSize = true;
            this.PhnNoLbl.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhnNoLbl.Location = new System.Drawing.Point(96, 293);
            this.PhnNoLbl.Name = "PhnNoLbl";
            this.PhnNoLbl.Size = new System.Drawing.Size(104, 17);
            this.PhnNoLbl.TabIndex = 9;
            this.PhnNoLbl.Text = "Phone Number";
            // 
            // RoleTxt
            // 
            this.RoleTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleTxt.Location = new System.Drawing.Point(211, 231);
            this.RoleTxt.Name = "RoleTxt";
            this.RoleTxt.ReadOnly = true;
            this.RoleTxt.Size = new System.Drawing.Size(143, 23);
            this.RoleTxt.TabIndex = 7;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(210, 171);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.ReadOnly = true;
            this.EmailTxt.Size = new System.Drawing.Size(143, 23);
            this.EmailTxt.TabIndex = 5;
            this.EmailTxt.TextChanged += new System.EventHandler(this.EmailTxt_TextChanged);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(210, 121);
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
            this.label4.Location = new System.Drawing.Point(98, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 121);
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
            // Updateusergrp
            // 
            this.Updateusergrp.Controls.Add(this.Updatepassbtn);
            this.Updateusergrp.Controls.Add(this.Updateusernametxt);
            this.Updateusergrp.Controls.Add(this.UpdateBtn);
            this.Updateusergrp.Controls.Add(this.PhoneNumupdatelbl);
            this.Updateusergrp.Controls.Add(this.Roleupdatelbl);
            this.Updateusergrp.Controls.Add(this.Emailupdatelbl);
            this.Updateusergrp.Controls.Add(this.Usernameupdatelbl);
            this.Updateusergrp.Controls.Add(this.UpdatePhoneTxt);
            this.Updateusergrp.Controls.Add(this.UpdateRoletxt);
            this.Updateusergrp.Controls.Add(this.UpdateEmailTxt);
            this.Updateusergrp.Controls.Add(this.updateuserlbl);
            this.Updateusergrp.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updateusergrp.Location = new System.Drawing.Point(529, 69);
            this.Updateusergrp.Name = "Updateusergrp";
            this.Updateusergrp.Size = new System.Drawing.Size(450, 463);
            this.Updateusergrp.TabIndex = 2;
            this.Updateusergrp.TabStop = false;
            this.Updateusergrp.Text = "User settings";
            // 
            // Updateusernametxt
            // 
            this.Updateusernametxt.Location = new System.Drawing.Point(193, 120);
            this.Updateusernametxt.Name = "Updateusernametxt";
            this.Updateusernametxt.Size = new System.Drawing.Size(143, 24);
            this.Updateusernametxt.TabIndex = 13;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.UpdateBtn.IconColor = System.Drawing.Color.Black;
            this.UpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.UpdateBtn.IconSize = 30;
            this.UpdateBtn.Location = new System.Drawing.Point(193, 398);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 46);
            this.UpdateBtn.TabIndex = 12;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // PhoneNumupdatelbl
            // 
            this.PhoneNumupdatelbl.AutoSize = true;
            this.PhoneNumupdatelbl.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumupdatelbl.Location = new System.Drawing.Point(83, 290);
            this.PhoneNumupdatelbl.Name = "PhoneNumupdatelbl";
            this.PhoneNumupdatelbl.Size = new System.Drawing.Size(104, 17);
            this.PhoneNumupdatelbl.TabIndex = 11;
            this.PhoneNumupdatelbl.Text = "Phone Number";
            // 
            // Roleupdatelbl
            // 
            this.Roleupdatelbl.AutoSize = true;
            this.Roleupdatelbl.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roleupdatelbl.Location = new System.Drawing.Point(83, 237);
            this.Roleupdatelbl.Name = "Roleupdatelbl";
            this.Roleupdatelbl.Size = new System.Drawing.Size(37, 17);
            this.Roleupdatelbl.TabIndex = 11;
            this.Roleupdatelbl.Text = "Role";
            // 
            // Emailupdatelbl
            // 
            this.Emailupdatelbl.AutoSize = true;
            this.Emailupdatelbl.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailupdatelbl.Location = new System.Drawing.Point(83, 176);
            this.Emailupdatelbl.Name = "Emailupdatelbl";
            this.Emailupdatelbl.Size = new System.Drawing.Size(43, 17);
            this.Emailupdatelbl.TabIndex = 7;
            this.Emailupdatelbl.Text = "Email";
            // 
            // Usernameupdatelbl
            // 
            this.Usernameupdatelbl.AutoSize = true;
            this.Usernameupdatelbl.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernameupdatelbl.Location = new System.Drawing.Point(83, 122);
            this.Usernameupdatelbl.Name = "Usernameupdatelbl";
            this.Usernameupdatelbl.Size = new System.Drawing.Size(70, 17);
            this.Usernameupdatelbl.TabIndex = 6;
            this.Usernameupdatelbl.Text = "Username";
            // 
            // UpdatePhoneTxt
            // 
            this.UpdatePhoneTxt.Location = new System.Drawing.Point(193, 290);
            this.UpdatePhoneTxt.Name = "UpdatePhoneTxt";
            this.UpdatePhoneTxt.Size = new System.Drawing.Size(143, 24);
            this.UpdatePhoneTxt.TabIndex = 5;
            // 
            // UpdateRoletxt
            // 
            this.UpdateRoletxt.Location = new System.Drawing.Point(193, 234);
            this.UpdateRoletxt.Name = "UpdateRoletxt";
            this.UpdateRoletxt.ReadOnly = true;
            this.UpdateRoletxt.Size = new System.Drawing.Size(143, 24);
            this.UpdateRoletxt.TabIndex = 4;
            // 
            // UpdateEmailTxt
            // 
            this.UpdateEmailTxt.Location = new System.Drawing.Point(193, 171);
            this.UpdateEmailTxt.Name = "UpdateEmailTxt";
            this.UpdateEmailTxt.Size = new System.Drawing.Size(143, 24);
            this.UpdateEmailTxt.TabIndex = 2;
            // 
            // updateuserlbl
            // 
            this.updateuserlbl.AutoSize = true;
            this.updateuserlbl.Location = new System.Drawing.Point(146, 39);
            this.updateuserlbl.Name = "updateuserlbl";
            this.updateuserlbl.Size = new System.Drawing.Size(168, 17);
            this.updateuserlbl.TabIndex = 0;
            this.updateuserlbl.Text = "Update User information";
            // 
            // Updatepassbtn
            // 
            this.Updatepassbtn.Location = new System.Drawing.Point(330, 398);
            this.Updatepassbtn.Name = "Updatepassbtn";
            this.Updatepassbtn.Size = new System.Drawing.Size(100, 46);
            this.Updatepassbtn.TabIndex = 14;
            this.Updatepassbtn.Text = "Update Password";
            this.Updatepassbtn.UseVisualStyleBackColor = true;
            this.Updatepassbtn.Click += new System.EventHandler(this.Updatepassbtn_Click);
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1014, 583);
            this.Controls.Add(this.Updateusergrp);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.UserProfile);
            this.Name = "ProfilePage";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            this.UserProfile.ResumeLayout(false);
            this.UserProfile.PerformLayout();
            this.Updateusergrp.ResumeLayout(false);
            this.Updateusergrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserProfile;
        private System.Windows.Forms.TextBox RoleTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.GroupBox Updateusergrp;
        private System.Windows.Forms.TextBox PhnNumberTxt;
        private System.Windows.Forms.Label PhnNoLbl;
        private System.Windows.Forms.Label PhoneNumupdatelbl;
        private System.Windows.Forms.Label Roleupdatelbl;
        private System.Windows.Forms.Label Emailupdatelbl;
        private System.Windows.Forms.Label Usernameupdatelbl;
        private System.Windows.Forms.TextBox UpdatePhoneTxt;
        private System.Windows.Forms.TextBox UpdateRoletxt;
        private System.Windows.Forms.TextBox UpdateEmailTxt;
        private System.Windows.Forms.Label updateuserlbl;
        private System.Windows.Forms.TextBox Updateusernametxt;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private System.Windows.Forms.Button Updatepassbtn;
    }
}