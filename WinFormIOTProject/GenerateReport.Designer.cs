namespace WinFormIOTProject
{
    partial class GenerateReport
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
            this.Genreport = new System.Windows.Forms.Button();
            this.Homebtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(335, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Generate Report";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Genreport
            // 
            this.Genreport.Location = new System.Drawing.Point(354, 458);
            this.Genreport.Name = "Genreport";
            this.Genreport.Size = new System.Drawing.Size(197, 23);
            this.Genreport.TabIndex = 3;
            this.Genreport.Text = "Generate Report";
            this.Genreport.UseVisualStyleBackColor = true;
            // 
            // Homebtn
            // 
            this.Homebtn.FlatAppearance.BorderSize = 0;
            this.Homebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Homebtn.IconColor = System.Drawing.Color.Black;
            this.Homebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Homebtn.Location = new System.Drawing.Point(25, 26);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(75, 41);
            this.Homebtn.TabIndex = 9;
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(896, 531);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.Genreport);
            this.Controls.Add(this.textBox1);
            this.Name = "GenerateReport";
            this.Text = "GenerateReport";
            this.Load += new System.EventHandler(this.GenerateReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Genreport;
        private FontAwesome.Sharp.IconButton Homebtn;
    }
}