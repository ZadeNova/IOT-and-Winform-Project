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
            this.Registerbtn = new System.Windows.Forms.Button();
            this.NewUsertxt = new System.Windows.Forms.TextBox();
            this.NewUserlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Registerbtn
            // 
            this.Registerbtn.Location = new System.Drawing.Point(192, 171);
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
            this.NewUsertxt.Size = new System.Drawing.Size(100, 20);
            this.NewUsertxt.TabIndex = 1;
            this.NewUsertxt.TextChanged += new System.EventHandler(this.NewUsertxt_TextChanged);
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
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 424);
            this.Controls.Add(this.NewUserlabel);
            this.Controls.Add(this.NewUsertxt);
            this.Controls.Add(this.Registerbtn);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.TextBox NewUsertxt;
        private System.Windows.Forms.Label NewUserlabel;
    }
}