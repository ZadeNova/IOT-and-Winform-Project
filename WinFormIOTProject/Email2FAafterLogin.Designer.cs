namespace WinFormIOTProject
{
    partial class Email2FAafterLogin
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
            this.Instructionlbl = new System.Windows.Forms.Label();
            this.TwoFAtxt = new System.Windows.Forms.TextBox();
            this.Confirmbtn = new System.Windows.Forms.Button();
            this.Sendemailagainbtn = new System.Windows.Forms.Button();
            this.Backtologin = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "2FA Email";
            // 
            // Instructionlbl
            // 
            this.Instructionlbl.AutoSize = true;
            this.Instructionlbl.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructionlbl.Location = new System.Drawing.Point(167, 123);
            this.Instructionlbl.Name = "Instructionlbl";
            this.Instructionlbl.Size = new System.Drawing.Size(314, 24);
            this.Instructionlbl.TabIndex = 1;
            this.Instructionlbl.Text = "Enter the code sent to your email";
            // 
            // TwoFAtxt
            // 
            this.TwoFAtxt.Location = new System.Drawing.Point(171, 193);
            this.TwoFAtxt.Name = "TwoFAtxt";
            this.TwoFAtxt.Size = new System.Drawing.Size(310, 20);
            this.TwoFAtxt.TabIndex = 2;
            this.TwoFAtxt.TextChanged += new System.EventHandler(this.TwoFAtxt_TextChanged);
            // 
            // Confirmbtn
            // 
            this.Confirmbtn.Location = new System.Drawing.Point(406, 287);
            this.Confirmbtn.Name = "Confirmbtn";
            this.Confirmbtn.Size = new System.Drawing.Size(75, 23);
            this.Confirmbtn.TabIndex = 3;
            this.Confirmbtn.Text = "Confirm";
            this.Confirmbtn.UseVisualStyleBackColor = true;
            this.Confirmbtn.Click += new System.EventHandler(this.Confirmbtn_Click);
            // 
            // Sendemailagainbtn
            // 
            this.Sendemailagainbtn.Location = new System.Drawing.Point(171, 287);
            this.Sendemailagainbtn.Name = "Sendemailagainbtn";
            this.Sendemailagainbtn.Size = new System.Drawing.Size(137, 23);
            this.Sendemailagainbtn.TabIndex = 4;
            this.Sendemailagainbtn.Text = "Send Email code again";
            this.Sendemailagainbtn.UseVisualStyleBackColor = true;
            this.Sendemailagainbtn.Click += new System.EventHandler(this.Sendemailagainbtn_Click);
            // 
            // Backtologin
            // 
            this.Backtologin.FlatAppearance.BorderSize = 0;
            this.Backtologin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.Backtologin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backtologin.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.Backtologin.IconColor = System.Drawing.Color.Black;
            this.Backtologin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Backtologin.IconSize = 40;
            this.Backtologin.Location = new System.Drawing.Point(24, 12);
            this.Backtologin.Name = "Backtologin";
            this.Backtologin.Size = new System.Drawing.Size(75, 41);
            this.Backtologin.TabIndex = 5;
            this.Backtologin.UseVisualStyleBackColor = true;
            this.Backtologin.Click += new System.EventHandler(this.Backtologin_Click);
            // 
            // Email2FAafterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(647, 440);
            this.Controls.Add(this.Backtologin);
            this.Controls.Add(this.Sendemailagainbtn);
            this.Controls.Add(this.Confirmbtn);
            this.Controls.Add(this.TwoFAtxt);
            this.Controls.Add(this.Instructionlbl);
            this.Controls.Add(this.label1);
            this.Name = "Email2FAafterLogin";
            this.Text = "Email2FAafterLogin";
            this.Load += new System.EventHandler(this.Email2FAafterLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Instructionlbl;
        private System.Windows.Forms.TextBox TwoFAtxt;
        private System.Windows.Forms.Button Confirmbtn;
        private System.Windows.Forms.Button Sendemailagainbtn;
        private FontAwesome.Sharp.IconButton Backtologin;
    }
}