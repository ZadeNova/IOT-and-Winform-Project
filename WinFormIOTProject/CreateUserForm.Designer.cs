namespace WinFormIOTProject
{
    partial class CreateUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Userpicicon = new FontAwesome.Sharp.IconPictureBox();
            this.Usercreategrpbox = new System.Windows.Forms.GroupBox();
            this.AddUserbtn = new FontAwesome.Sharp.IconButton();
            this.GrpSetting = new System.Windows.Forms.GroupBox();
            this.UserBtn = new System.Windows.Forms.RadioButton();
            this.AdminBtn = new System.Windows.Forms.RadioButton();
            this.CfmPassTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.PhoneNumtxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.Homebtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Userpicicon)).BeginInit();
            this.Usercreategrpbox.SuspendLayout();
            this.GrpSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create User";
            // 
            // Userpicicon
            // 
            this.Userpicicon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Userpicicon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Userpicicon.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.Userpicicon.IconColor = System.Drawing.SystemColors.ControlText;
            this.Userpicicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Userpicicon.Location = new System.Drawing.Point(420, 21);
            this.Userpicicon.Name = "Userpicicon";
            this.Userpicicon.Size = new System.Drawing.Size(32, 32);
            this.Userpicicon.TabIndex = 1;
            this.Userpicicon.TabStop = false;
            // 
            // Usercreategrpbox
            // 
            this.Usercreategrpbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Usercreategrpbox.Controls.Add(this.AddUserbtn);
            this.Usercreategrpbox.Controls.Add(this.GrpSetting);
            this.Usercreategrpbox.Controls.Add(this.CfmPassTxt);
            this.Usercreategrpbox.Controls.Add(this.PasswordTxt);
            this.Usercreategrpbox.Controls.Add(this.label6);
            this.Usercreategrpbox.Controls.Add(this.label5);
            this.Usercreategrpbox.Controls.Add(this.label2);
            this.Usercreategrpbox.Controls.Add(this.label4);
            this.Usercreategrpbox.Controls.Add(this.label3);
            this.Usercreategrpbox.Controls.Add(this.UserNamelbl);
            this.Usercreategrpbox.Controls.Add(this.PhoneNumtxt);
            this.Usercreategrpbox.Controls.Add(this.EmailTxt);
            this.Usercreategrpbox.Controls.Add(this.UserNametxt);
            this.Usercreategrpbox.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usercreategrpbox.Location = new System.Drawing.Point(43, 74);
            this.Usercreategrpbox.Name = "Usercreategrpbox";
            this.Usercreategrpbox.Size = new System.Drawing.Size(972, 466);
            this.Usercreategrpbox.TabIndex = 2;
            this.Usercreategrpbox.TabStop = false;
            this.Usercreategrpbox.Text = "User Creation";
            // 
            // AddUserbtn
            // 
            this.AddUserbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddUserbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddUserbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserbtn.FlatAppearance.BorderSize = 0;
            this.AddUserbtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddUserbtn.IconColor = System.Drawing.Color.LightSeaGreen;
            this.AddUserbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddUserbtn.IconSize = 40;
            this.AddUserbtn.Location = new System.Drawing.Point(819, 403);
            this.AddUserbtn.Name = "AddUserbtn";
            this.AddUserbtn.Size = new System.Drawing.Size(75, 48);
            this.AddUserbtn.TabIndex = 13;
            this.AddUserbtn.UseVisualStyleBackColor = false;
            this.AddUserbtn.Click += new System.EventHandler(this.AddUserbtn_Click);
            // 
            // GrpSetting
            // 
            this.GrpSetting.Controls.Add(this.UserBtn);
            this.GrpSetting.Controls.Add(this.AdminBtn);
            this.GrpSetting.Location = new System.Drawing.Point(632, 69);
            this.GrpSetting.Name = "GrpSetting";
            this.GrpSetting.Size = new System.Drawing.Size(284, 322);
            this.GrpSetting.TabIndex = 12;
            this.GrpSetting.TabStop = false;
            this.GrpSetting.Text = "User Settings";
            // 
            // UserBtn
            // 
            this.UserBtn.AutoSize = true;
            this.UserBtn.Location = new System.Drawing.Point(69, 194);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(67, 23);
            this.UserBtn.TabIndex = 12;
            this.UserBtn.TabStop = true;
            this.UserBtn.Text = "User";
            this.UserBtn.UseVisualStyleBackColor = true;
            // 
            // AdminBtn
            // 
            this.AdminBtn.AutoSize = true;
            this.AdminBtn.Location = new System.Drawing.Point(69, 70);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(77, 23);
            this.AdminBtn.TabIndex = 11;
            this.AdminBtn.TabStop = true;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = true;
            // 
            // CfmPassTxt
            // 
            this.CfmPassTxt.Location = new System.Drawing.Point(245, 370);
            this.CfmPassTxt.Name = "CfmPassTxt";
            this.CfmPassTxt.Size = new System.Drawing.Size(275, 27);
            this.CfmPassTxt.TabIndex = 10;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(245, 301);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(275, 27);
            this.PasswordTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelbl.Location = new System.Drawing.Point(91, 81);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(71, 15);
            this.UserNamelbl.TabIndex = 3;
            this.UserNamelbl.Text = "Username";
            // 
            // PhoneNumtxt
            // 
            this.PhoneNumtxt.Location = new System.Drawing.Point(245, 218);
            this.PhoneNumtxt.Name = "PhoneNumtxt";
            this.PhoneNumtxt.Size = new System.Drawing.Size(275, 27);
            this.PhoneNumtxt.TabIndex = 2;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(245, 147);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(275, 27);
            this.EmailTxt.TabIndex = 1;
            // 
            // UserNametxt
            // 
            this.UserNametxt.Location = new System.Drawing.Point(245, 75);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(275, 27);
            this.UserNametxt.TabIndex = 0;
            // 
            // Homebtn
            // 
            this.Homebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Homebtn.FlatAppearance.BorderSize = 0;
            this.Homebtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Homebtn.IconColor = System.Drawing.Color.LightSeaGreen;
            this.Homebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Homebtn.IconSize = 40;
            this.Homebtn.Location = new System.Drawing.Point(43, 12);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(75, 41);
            this.Homebtn.TabIndex = 3;
            this.Homebtn.UseVisualStyleBackColor = false;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1064, 594);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.Usercreategrpbox);
            this.Controls.Add(this.Userpicicon);
            this.Controls.Add(this.label1);
            this.Name = "CreateUserForm";
            this.Text = "CreateUser";
            ((System.ComponentModel.ISupportInitialize)(this.Userpicicon)).EndInit();
            this.Usercreategrpbox.ResumeLayout(false);
            this.Usercreategrpbox.PerformLayout();
            this.GrpSetting.ResumeLayout(false);
            this.GrpSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox Userpicicon;
        private System.Windows.Forms.GroupBox Usercreategrpbox;
        private FontAwesome.Sharp.IconButton Homebtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.TextBox PhoneNumtxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.TextBox CfmPassTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private FontAwesome.Sharp.IconButton AddUserbtn;
        private System.Windows.Forms.GroupBox GrpSetting;
        private System.Windows.Forms.RadioButton UserBtn;
        private System.Windows.Forms.RadioButton AdminBtn;
    }
}