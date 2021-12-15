namespace WinFormIOTProject
{
    partial class UltraSonic
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
            this.Clearbtn2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Roomtemptxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Status2txt = new System.Windows.Forms.TextBox();
            this.Status2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clearbtn2
            // 
            this.Clearbtn2.Location = new System.Drawing.Point(349, 12);
            this.Clearbtn2.Name = "Clearbtn2";
            this.Clearbtn2.Size = new System.Drawing.Size(123, 42);
            this.Clearbtn2.TabIndex = 11;
            this.Clearbtn2.Text = "Clear";
            this.Clearbtn2.UseVisualStyleBackColor = true;
            this.Clearbtn2.Click += new System.EventHandler(this.Clearbtn2_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(449, 134);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Motion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Roomtemptxt
            // 
            this.Roomtemptxt.BackColor = System.Drawing.SystemColors.Control;
            this.Roomtemptxt.Location = new System.Drawing.Point(133, 21);
            this.Roomtemptxt.Name = "Roomtemptxt";
            this.Roomtemptxt.Size = new System.Drawing.Size(145, 20);
            this.Roomtemptxt.TabIndex = 7;
            this.Roomtemptxt.TextChanged += new System.EventHandler(this.Roomtemptxt_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Status2txt
            // 
            this.Status2txt.BackColor = System.Drawing.SystemColors.Control;
            this.Status2txt.Location = new System.Drawing.Point(133, 73);
            this.Status2txt.Name = "Status2txt";
            this.Status2txt.Size = new System.Drawing.Size(145, 20);
            this.Status2txt.TabIndex = 6;
            this.Status2txt.TextChanged += new System.EventHandler(this.Status2txt_TextChanged);
            // 
            // Status2
            // 
            this.Status2.AutoSize = true;
            this.Status2.Location = new System.Drawing.Point(20, 73);
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(37, 13);
            this.Status2.TabIndex = 9;
            this.Status2.Text = "Status";
            // 
            // UltraSonic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clearbtn2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Status2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Roomtemptxt);
            this.Controls.Add(this.Status2txt);
            this.Name = "UltraSonic";
            this.Text = "UltraSonic";
            this.Load += new System.EventHandler(this.UltraSonic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clearbtn2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Roomtemptxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Status2txt;
        private System.Windows.Forms.Label Status2;
    }
}