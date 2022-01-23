namespace WinFormIOTProject
{
    partial class LightChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UserSettingsbtn = new FontAwesome.Sharp.IconButton();
            this.ProfileBtn = new FontAwesome.Sharp.IconButton();
            this.Logout = new FontAwesome.Sharp.IconButton();
            this.Homebtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(141, 44);
            this.chart1.Name = "chart1";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(657, 324);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // UserSettingsbtn
            // 
            this.UserSettingsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserSettingsbtn.FlatAppearance.BorderSize = 0;
            this.UserSettingsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.UserSettingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSettingsbtn.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.UserSettingsbtn.IconColor = System.Drawing.Color.LightSeaGreen;
            this.UserSettingsbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserSettingsbtn.IconSize = 40;
            this.UserSettingsbtn.Location = new System.Drawing.Point(830, 0);
            this.UserSettingsbtn.Name = "UserSettingsbtn";
            this.UserSettingsbtn.Size = new System.Drawing.Size(47, 43);
            this.UserSettingsbtn.TabIndex = 4;
            this.UserSettingsbtn.UseVisualStyleBackColor = false;
            this.UserSettingsbtn.Click += new System.EventHandler(this.UserSettingsbtn_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileBtn.FlatAppearance.BorderSize = 0;
            this.ProfileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileBtn.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.ProfileBtn.IconColor = System.Drawing.Color.LightSeaGreen;
            this.ProfileBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProfileBtn.IconSize = 40;
            this.ProfileBtn.Location = new System.Drawing.Point(873, 0);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(44, 46);
            this.ProfileBtn.TabIndex = 5;
            this.ProfileBtn.UseVisualStyleBackColor = false;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Logout.IconColor = System.Drawing.Color.LightSeaGreen;
            this.Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Logout.IconSize = 40;
            this.Logout.Location = new System.Drawing.Point(921, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(46, 46);
            this.Logout.TabIndex = 6;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.FlatAppearance.BorderSize = 0;
            this.Homebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Homebtn.IconColor = System.Drawing.Color.Black;
            this.Homebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Homebtn.Location = new System.Drawing.Point(23, 12);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(75, 41);
            this.Homebtn.TabIndex = 9;
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // LightChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(969, 612);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.UserSettingsbtn);
            this.Controls.Add(this.chart1);
            this.Name = "LightChart";
            this.Text = "GraphDatass";
            this.Load += new System.EventHandler(this.GraphDatass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FontAwesome.Sharp.IconButton UserSettingsbtn;
        private FontAwesome.Sharp.IconButton ProfileBtn;
        private FontAwesome.Sharp.IconButton Logout;
        private FontAwesome.Sharp.IconButton Homebtn;
    }
}