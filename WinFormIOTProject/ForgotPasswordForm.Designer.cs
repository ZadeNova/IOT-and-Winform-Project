namespace WinFormIOTProject
{
    partial class ForgotPasswordForm
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
            this.EmailBoxTxt = new System.Windows.Forms.TextBox();
            this.Forgetpasslabel = new System.Windows.Forms.Label();
            this.EnteremailLabel = new System.Windows.Forms.Label();
            this.ResetPassBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // EmailBoxTxt
            // 
            this.EmailBoxTxt.Location = new System.Drawing.Point(290, 202);
            this.EmailBoxTxt.Name = "EmailBoxTxt";
            this.EmailBoxTxt.Size = new System.Drawing.Size(276, 20);
            this.EmailBoxTxt.TabIndex = 0;
            this.EmailBoxTxt.TextChanged += new System.EventHandler(this.EmailBoxTxt_TextChanged);
            // 
            // Forgetpasslabel
            // 
            this.Forgetpasslabel.AutoSize = true;
            this.Forgetpasslabel.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forgetpasslabel.Location = new System.Drawing.Point(354, 28);
            this.Forgetpasslabel.Name = "Forgetpasslabel";
            this.Forgetpasslabel.Size = new System.Drawing.Size(155, 24);
            this.Forgetpasslabel.TabIndex = 1;
            this.Forgetpasslabel.Text = "Forget Password";
            // 
            // EnteremailLabel
            // 
            this.EnteremailLabel.AutoSize = true;
            this.EnteremailLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnteremailLabel.Location = new System.Drawing.Point(286, 158);
            this.EnteremailLabel.Name = "EnteremailLabel";
            this.EnteremailLabel.Size = new System.Drawing.Size(109, 20);
            this.EnteremailLabel.TabIndex = 2;
            this.EnteremailLabel.Text = "Email address";
            // 
            // ResetPassBtn
            // 
            this.ResetPassBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ResetPassBtn.IconColor = System.Drawing.Color.Black;
            this.ResetPassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ResetPassBtn.Location = new System.Drawing.Point(358, 307);
            this.ResetPassBtn.Name = "ResetPassBtn";
            this.ResetPassBtn.Size = new System.Drawing.Size(136, 23);
            this.ResetPassBtn.TabIndex = 4;
            this.ResetPassBtn.Text = "Reset password";
            this.ResetPassBtn.UseVisualStyleBackColor = true;
            this.ResetPassBtn.Click += new System.EventHandler(this.ResetPassBtn_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 531);
            this.Controls.Add(this.ResetPassBtn);
            this.Controls.Add(this.EnteremailLabel);
            this.Controls.Add(this.Forgetpasslabel);
            this.Controls.Add(this.EmailBoxTxt);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailBoxTxt;
        private System.Windows.Forms.Label Forgetpasslabel;
        private System.Windows.Forms.Label EnteremailLabel;
        private FontAwesome.Sharp.IconButton ResetPassBtn;
    }
}