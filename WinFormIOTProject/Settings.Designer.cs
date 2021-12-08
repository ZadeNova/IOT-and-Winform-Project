namespace WinFormIOTProject
{
    partial class Settings
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Home = new System.Windows.Forms.Button();
            this.RaspBoxGrp = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Emailtestbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(385, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Settings";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Home
            // 
            this.Home.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(12, 14);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 23);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // RaspBoxGrp
            // 
            this.RaspBoxGrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RaspBoxGrp.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaspBoxGrp.Location = new System.Drawing.Point(12, 150);
            this.RaspBoxGrp.Name = "RaspBoxGrp";
            this.RaspBoxGrp.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.RaspBoxGrp.Size = new System.Drawing.Size(260, 252);
            this.RaspBoxGrp.TabIndex = 3;
            this.RaspBoxGrp.TabStop = false;
            this.RaspBoxGrp.Text = "Raspberry Pi";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Location = new System.Drawing.Point(624, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(260, 252);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Emailtestbtn
            // 
            this.Emailtestbtn.Location = new System.Drawing.Point(385, 420);
            this.Emailtestbtn.Name = "Emailtestbtn";
            this.Emailtestbtn.Size = new System.Drawing.Size(75, 23);
            this.Emailtestbtn.TabIndex = 5;
            this.Emailtestbtn.Text = "Send email";
            this.Emailtestbtn.UseVisualStyleBackColor = true;
            this.Emailtestbtn.Click += new System.EventHandler(this.Emailtestbtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(896, 531);
            this.Controls.Add(this.Emailtestbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RaspBoxGrp);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.textBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.GroupBox RaspBoxGrp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Emailtestbtn;
    }
}