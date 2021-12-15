namespace WinFormIOTProject
{
    partial class LoginForm
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
            this.UsernameTxtbox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new FontAwesome.Sharp.IconButton();
            this.ForgetPassBtn = new FontAwesome.Sharp.IconButton();
            this.RFIDLoginBtn = new FontAwesome.Sharp.IconButton();
            this.Login = new System.Windows.Forms.Label();
            this.SignupLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.Location = new System.Drawing.Point(251, 98);
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.Size = new System.Drawing.Size(157, 20);
            this.UsernameTxtbox.TabIndex = 0;
            this.UsernameTxtbox.TextChanged += new System.EventHandler(this.UsernameTxtbox_TextChanged);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(251, 177);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(157, 20);
            this.PasswordTxtBox.TabIndex = 1;
            this.PasswordTxtBox.TextChanged += new System.EventHandler(this.PasswordTxtBox_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(129, 98);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(132, 177);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.LoginBtn.IconColor = System.Drawing.Color.Black;
            this.LoginBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.LoginBtn.IconSize = 40;
            this.LoginBtn.Location = new System.Drawing.Point(370, 295);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(111, 43);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click_1);
            // 
            // ForgetPassBtn
            // 
            this.ForgetPassBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.ForgetPassBtn.IconColor = System.Drawing.Color.Black;
            this.ForgetPassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ForgetPassBtn.IconSize = 40;
            this.ForgetPassBtn.Location = new System.Drawing.Point(146, 295);
            this.ForgetPassBtn.Name = "ForgetPassBtn";
            this.ForgetPassBtn.Size = new System.Drawing.Size(138, 43);
            this.ForgetPassBtn.TabIndex = 8;
            this.ForgetPassBtn.Text = "Forget Password";
            this.ForgetPassBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ForgetPassBtn.UseVisualStyleBackColor = true;
            this.ForgetPassBtn.Click += new System.EventHandler(this.ForgetPassBtn_Click_1);
            // 
            // RFIDLoginBtn
            // 
            this.RFIDLoginBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFIDLoginBtn.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.RFIDLoginBtn.IconColor = System.Drawing.Color.Black;
            this.RFIDLoginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RFIDLoginBtn.IconSize = 30;
            this.RFIDLoginBtn.Location = new System.Drawing.Point(370, 248);
            this.RFIDLoginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RFIDLoginBtn.Name = "RFIDLoginBtn";
            this.RFIDLoginBtn.Size = new System.Drawing.Size(111, 41);
            this.RFIDLoginBtn.TabIndex = 9;
            this.RFIDLoginBtn.Text = "RFIDLogin";
            this.RFIDLoginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RFIDLoginBtn.UseVisualStyleBackColor = true;
            this.RFIDLoginBtn.Click += new System.EventHandler(this.RFIDLoginBtn_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(302, 28);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(52, 20);
            this.Login.TabIndex = 10;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // SignupLbl
            // 
            this.SignupLbl.AutoSize = true;
            this.SignupLbl.Location = new System.Drawing.Point(266, 370);
            this.SignupLbl.Name = "SignupLbl";
            this.SignupLbl.Size = new System.Drawing.Size(105, 13);
            this.SignupLbl.TabIndex = 11;
            this.SignupLbl.TabStop = true;
            this.SignupLbl.Text = "No account?Sign up";
            this.SignupLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignupLbl_LinkClicked);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(647, 440);
            this.Controls.Add(this.SignupLbl);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.RFIDLoginBtn);
            this.Controls.Add(this.ForgetPassBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UsernameTxtbox);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxtbox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private FontAwesome.Sharp.IconButton LoginBtn;
        private FontAwesome.Sharp.IconButton ForgetPassBtn;
        private FontAwesome.Sharp.IconButton RFIDLoginBtn;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.LinkLabel SignupLbl;
    }
}

