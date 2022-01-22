namespace WinFormIOTProject
{
    partial class Statistics
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
            this.Statslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Statslbl
            // 
            this.Statslbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Statslbl.AutoSize = true;
            this.Statslbl.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statslbl.Location = new System.Drawing.Point(456, 26);
            this.Statslbl.Name = "Statslbl";
            this.Statslbl.Size = new System.Drawing.Size(87, 24);
            this.Statslbl.TabIndex = 0;
            this.Statslbl.Text = "Statistics";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1064, 651);
            this.Controls.Add(this.Statslbl);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Statslbl;
    }
}