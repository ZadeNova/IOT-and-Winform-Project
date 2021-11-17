namespace WinFormIOTProject
{
    partial class SignUpForm
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
            this.components = new System.ComponentModel.Container();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.NewUsertxt = new System.Windows.Forms.TextBox();
            this.NewUserlabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NewEmailTxt = new System.Windows.Forms.TextBox();
            this.NewPasswordTxt = new System.Windows.Forms.TextBox();
            this.CfmpassReg = new System.Windows.Forms.Label();
            this.CfmPassTxtBox = new System.Windows.Forms.TextBox();
            this.UserError = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.PassError = new System.Windows.Forms.ErrorProvider(this.components);
            this.CfmPassError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UserError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CfmPassError)).BeginInit();
            this.SuspendLayout();
            // 
            // Registerbtn
            // 
            this.Registerbtn.Location = new System.Drawing.Point(192, 229);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(75, 23);
            this.Registerbtn.TabIndex = 0;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.UseVisualStyleBackColor = true;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // NewUsertxt
            // 
            this.NewUsertxt.Location = new System.Drawing.Point(167, 82);
            this.NewUsertxt.Name = "NewUsertxt";
            this.NewUsertxt.Size = new System.Drawing.Size(166, 20);
            this.NewUsertxt.TabIndex = 1;
            this.NewUsertxt.TextChanged += new System.EventHandler(this.NewUsertxt_TextChanged);
            this.NewUsertxt.Validating += new System.ComponentModel.CancelEventHandler(this.NewUsertxt_Validating);
            // 
            // NewUserlabel
            // 
            this.NewUserlabel.AutoSize = true;
            this.NewUserlabel.Location = new System.Drawing.Point(66, 82);
            this.NewUserlabel.Name = "NewUserlabel";
            this.NewUserlabel.Size = new System.Drawing.Size(55, 13);
            this.NewUserlabel.TabIndex = 2;
            this.NewUserlabel.Text = "Username";
            this.NewUserlabel.Click += new System.EventHandler(this.NewUserlabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(69, 116);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(69, 150);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // NewEmailTxt
            // 
            this.NewEmailTxt.Location = new System.Drawing.Point(167, 113);
            this.NewEmailTxt.Name = "NewEmailTxt";
            this.NewEmailTxt.Size = new System.Drawing.Size(166, 20);
            this.NewEmailTxt.TabIndex = 5;
            this.NewEmailTxt.TextChanged += new System.EventHandler(this.NewEmailTxt_TextChanged);
            // 
            // NewPasswordTxt
            // 
            this.NewPasswordTxt.Location = new System.Drawing.Point(167, 150);
            this.NewPasswordTxt.Name = "NewPasswordTxt";
            this.NewPasswordTxt.Size = new System.Drawing.Size(166, 20);
            this.NewPasswordTxt.TabIndex = 6;
            this.NewPasswordTxt.TextChanged += new System.EventHandler(this.NewPasswordTxt_TextChanged);
            // 
            // CfmpassReg
            // 
            this.CfmpassReg.AutoSize = true;
            this.CfmpassReg.Location = new System.Drawing.Point(69, 194);
            this.CfmpassReg.Name = "CfmpassReg";
            this.CfmpassReg.Size = new System.Drawing.Size(91, 13);
            this.CfmpassReg.TabIndex = 7;
            this.CfmpassReg.Text = "Confirm Password";
            // 
            // CfmPassTxtBox
            // 
            this.CfmPassTxtBox.Location = new System.Drawing.Point(167, 191);
            this.CfmPassTxtBox.Name = "CfmPassTxtBox";
            this.CfmPassTxtBox.Size = new System.Drawing.Size(166, 20);
            this.CfmPassTxtBox.TabIndex = 8;
            this.CfmPassTxtBox.TextChanged += new System.EventHandler(this.CfmPassTxtBox_TextChanged);
            // 
            // UserError
            // 
            this.UserError.ContainerControl = this;
            // 
            // EmailError
            // 
            this.EmailError.ContainerControl = this;
            // 
            // PassError
            // 
            this.PassError.ContainerControl = this;
            // 
            // CfmPassError
            // 
            this.CfmPassError.ContainerControl = this;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 424);
            this.Controls.Add(this.CfmPassTxtBox);
            this.Controls.Add(this.CfmpassReg);
            this.Controls.Add(this.NewPasswordTxt);
            this.Controls.Add(this.NewEmailTxt);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NewUserlabel);
            this.Controls.Add(this.NewUsertxt);
            this.Controls.Add(this.Registerbtn);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CfmPassError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.TextBox NewUsertxt;
        private System.Windows.Forms.Label NewUserlabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox NewEmailTxt;
        private System.Windows.Forms.TextBox NewPasswordTxt;
        private System.Windows.Forms.Label CfmpassReg;
        private System.Windows.Forms.TextBox CfmPassTxtBox;
        private System.Windows.Forms.ErrorProvider UserError;
        private System.Windows.Forms.ErrorProvider EmailError;
        private System.Windows.Forms.ErrorProvider PassError;
        private System.Windows.Forms.ErrorProvider CfmPassError;
    }
}