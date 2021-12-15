namespace WinFormIOTProject
{
    partial class DataVisualisationForm
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
            this.tabControlData = new System.Windows.Forms.TabControl();
            this.Temperature = new System.Windows.Forms.TabPage();
            this.Clearbtn2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Status2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Roomtemptxt = new System.Windows.Forms.TextBox();
            this.Status2txt = new System.Windows.Forms.TextBox();
            this.Lighttab = new System.Windows.Forms.TabPage();
            this.Statustxt = new System.Windows.Forms.TextBox();
            this.Roomlighttxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDataComms = new System.Windows.Forms.ListBox();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControlData.SuspendLayout();
            this.Temperature.SuspendLayout();
            this.Lighttab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlData
            // 
            this.tabControlData.Controls.Add(this.Temperature);
            this.tabControlData.Controls.Add(this.Lighttab);
            this.tabControlData.Location = new System.Drawing.Point(12, 24);
            this.tabControlData.Name = "tabControlData";
            this.tabControlData.SelectedIndex = 0;
            this.tabControlData.Size = new System.Drawing.Size(493, 318);
            this.tabControlData.TabIndex = 0;
            // 
            // Temperature
            // 
            this.Temperature.Controls.Add(this.Clearbtn2);
            this.Temperature.Controls.Add(this.listBox1);
            this.Temperature.Controls.Add(this.Status2);
            this.Temperature.Controls.Add(this.label3);
            this.Temperature.Controls.Add(this.Roomtemptxt);
            this.Temperature.Controls.Add(this.Status2txt);
            this.Temperature.Location = new System.Drawing.Point(4, 22);
            this.Temperature.Name = "Temperature";
            this.Temperature.Padding = new System.Windows.Forms.Padding(3);
            this.Temperature.Size = new System.Drawing.Size(485, 292);
            this.Temperature.TabIndex = 0;
            this.Temperature.Text = "Temperature";
            this.Temperature.UseVisualStyleBackColor = true;
            this.Temperature.Click += new System.EventHandler(this.Temperature_Click);
            // 
            // Clearbtn2
            // 
            this.Clearbtn2.Location = new System.Drawing.Point(334, 34);
            this.Clearbtn2.Name = "Clearbtn2";
            this.Clearbtn2.Size = new System.Drawing.Size(123, 42);
            this.Clearbtn2.TabIndex = 5;
            this.Clearbtn2.Text = "Clear";
            this.Clearbtn2.UseVisualStyleBackColor = true;
            this.Clearbtn2.Click += new System.EventHandler(this.Clearbtn2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(449, 134);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Status2
            // 
            this.Status2.AutoSize = true;
            this.Status2.Location = new System.Drawing.Point(15, 72);
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(37, 13);
            this.Status2.TabIndex = 3;
            this.Status2.Text = "Status";
            this.Status2.Click += new System.EventHandler(this.Status2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Temperature";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Roomtemptxt
            // 
            this.Roomtemptxt.BackColor = System.Drawing.SystemColors.Control;
            this.Roomtemptxt.Location = new System.Drawing.Point(128, 20);
            this.Roomtemptxt.Name = "Roomtemptxt";
            this.Roomtemptxt.Size = new System.Drawing.Size(145, 20);
            this.Roomtemptxt.TabIndex = 1;
            this.Roomtemptxt.TextChanged += new System.EventHandler(this.Roomtemptxt_TextChanged);
            // 
            // Status2txt
            // 
            this.Status2txt.BackColor = System.Drawing.SystemColors.Control;
            this.Status2txt.Location = new System.Drawing.Point(128, 72);
            this.Status2txt.Name = "Status2txt";
            this.Status2txt.Size = new System.Drawing.Size(145, 20);
            this.Status2txt.TabIndex = 0;
            this.Status2txt.TextChanged += new System.EventHandler(this.Status2txt_TextChanged);
            // 
            // Lighttab
            // 
            this.Lighttab.Controls.Add(this.Statustxt);
            this.Lighttab.Controls.Add(this.Roomlighttxt);
            this.Lighttab.Controls.Add(this.label2);
            this.Lighttab.Controls.Add(this.label1);
            this.Lighttab.Controls.Add(this.lbDataComms);
            this.Lighttab.Controls.Add(this.Clearbtn);
            this.Lighttab.Location = new System.Drawing.Point(4, 22);
            this.Lighttab.Name = "Lighttab";
            this.Lighttab.Padding = new System.Windows.Forms.Padding(3);
            this.Lighttab.Size = new System.Drawing.Size(485, 292);
            this.Lighttab.TabIndex = 1;
            this.Lighttab.Text = "Light";
            this.Lighttab.UseVisualStyleBackColor = true;
            // 
            // Statustxt
            // 
            this.Statustxt.BackColor = System.Drawing.SystemColors.Control;
            this.Statustxt.Location = new System.Drawing.Point(107, 80);
            this.Statustxt.Name = "Statustxt";
            this.Statustxt.Size = new System.Drawing.Size(161, 20);
            this.Statustxt.TabIndex = 5;
            // 
            // Roomlighttxt
            // 
            this.Roomlighttxt.BackColor = System.Drawing.SystemColors.Control;
            this.Roomlighttxt.Location = new System.Drawing.Point(107, 26);
            this.Roomlighttxt.Name = "Roomlighttxt";
            this.Roomlighttxt.Size = new System.Drawing.Size(161, 20);
            this.Roomlighttxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Light";
            // 
            // lbDataComms
            // 
            this.lbDataComms.FormattingEnabled = true;
            this.lbDataComms.Location = new System.Drawing.Point(6, 120);
            this.lbDataComms.Name = "lbDataComms";
            this.lbDataComms.Size = new System.Drawing.Size(473, 134);
            this.lbDataComms.TabIndex = 1;
            this.lbDataComms.SelectedIndexChanged += new System.EventHandler(this.lbDataComms_SelectedIndexChanged);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(333, 33);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(116, 44);
            this.Clearbtn.TabIndex = 0;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop both sensor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataVisualisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1064, 594);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControlData);
            this.Name = "DataVisualisationForm";
            this.Text = "DataVisualisationForm";
            this.Load += new System.EventHandler(this.DataVisualisationForm_Load);
            this.tabControlData.ResumeLayout(false);
            this.Temperature.ResumeLayout(false);
            this.Temperature.PerformLayout();
            this.Lighttab.ResumeLayout(false);
            this.Lighttab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlData;
        private System.Windows.Forms.TabPage Temperature;
        private System.Windows.Forms.TabPage Lighttab;
        private System.Windows.Forms.Button Clearbtn2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Status2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Roomtemptxt;
        private System.Windows.Forms.TextBox Status2txt;
        private System.Windows.Forms.TextBox Statustxt;
        private System.Windows.Forms.TextBox Roomlighttxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDataComms;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button button2;
    }
}