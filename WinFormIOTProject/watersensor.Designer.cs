namespace WinFormIOTProject
{
    partial class watersensor
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
            this.Water = new System.Windows.Forms.TabPage();
            this.Clearbtn2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Status2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Roomtemptxt = new System.Windows.Forms.TextBox();
            this.Status2txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.tabControlData.SuspendLayout();
            this.Water.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlData
            // 
            this.tabControlData.Controls.Add(this.Water);
            this.tabControlData.Location = new System.Drawing.Point(12, 51);
            this.tabControlData.Name = "tabControlData";
            this.tabControlData.SelectedIndex = 0;
            this.tabControlData.Size = new System.Drawing.Size(590, 335);
            this.tabControlData.TabIndex = 1;
            // 
            // Water
            // 
            this.Water.BackColor = System.Drawing.Color.DarkGray;
            this.Water.Controls.Add(this.button1);
            this.Water.Controls.Add(this.Clearbtn2);
            this.Water.Controls.Add(this.listBox1);
            this.Water.Controls.Add(this.Status2);
            this.Water.Controls.Add(this.label3);
            this.Water.Controls.Add(this.Roomtemptxt);
            this.Water.Controls.Add(this.Status2txt);
            this.Water.Location = new System.Drawing.Point(4, 22);
            this.Water.Name = "Water";
            this.Water.Padding = new System.Windows.Forms.Padding(3);
            this.Water.Size = new System.Drawing.Size(582, 309);
            this.Water.TabIndex = 0;
            this.Water.Text = "Water";
            // 
            // Clearbtn2
            // 
            this.Clearbtn2.Location = new System.Drawing.Point(344, 8);
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
            this.Status2.Location = new System.Drawing.Point(25, 75);
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(37, 13);
            this.Status2.TabIndex = 3;
            this.Status2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Moisture";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home.IconColor = System.Drawing.Color.Black;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.Location = new System.Drawing.Point(3, -1);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 46);
            this.Home.TabIndex = 9;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // watersensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(678, 398);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.tabControlData);
            this.Name = "watersensor";
            this.Text = "watersensor";
            this.Load += new System.EventHandler(this.watersensor_Load);
            this.tabControlData.ResumeLayout(false);
            this.Water.ResumeLayout(false);
            this.Water.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlData;
        private System.Windows.Forms.TabPage Water;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Clearbtn2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Status2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Roomtemptxt;
        private System.Windows.Forms.TextBox Status2txt;
        private FontAwesome.Sharp.IconButton Home;
    }
}