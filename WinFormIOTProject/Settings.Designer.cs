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
            this.RaspBoxGrp = new System.Windows.Forms.GroupBox();
            this.Home = new FontAwesome.Sharp.IconButton();
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
            // RaspBoxGrp
            // 
            this.RaspBoxGrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RaspBoxGrp.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaspBoxGrp.Location = new System.Drawing.Point(36, 90);
            this.RaspBoxGrp.Name = "RaspBoxGrp";
            this.RaspBoxGrp.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.RaspBoxGrp.Size = new System.Drawing.Size(805, 384);
            this.RaspBoxGrp.TabIndex = 3;
            this.RaspBoxGrp.TabStop = false;
            this.RaspBoxGrp.Text = "Raspberry Pi";
            // 
            // Home
            // 
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home.IconColor = System.Drawing.Color.Black;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.Location = new System.Drawing.Point(36, 22);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 46);
            this.Home.TabIndex = 6;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click_1);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(896, 531);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.RaspBoxGrp);
            this.Controls.Add(this.textBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox RaspBoxGrp;
        private FontAwesome.Sharp.IconButton Home;
    }
}