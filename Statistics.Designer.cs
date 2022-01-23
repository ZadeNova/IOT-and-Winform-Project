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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SoundAvgTxt = new System.Windows.Forms.TextBox();
            this.LightAvgTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProfileBtn = new FontAwesome.Sharp.IconButton();
            this.Logout = new FontAwesome.Sharp.IconButton();
            this.Homebtn = new FontAwesome.Sharp.IconButton();
            this.UserSettingsbtn = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LightAvgTxt);
            this.groupBox1.Controls.Add(this.SoundAvgTxt);
            this.groupBox1.Location = new System.Drawing.Point(59, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 534);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // SoundAvgTxt
            // 
            this.SoundAvgTxt.Location = new System.Drawing.Point(137, 82);
            this.SoundAvgTxt.Name = "SoundAvgTxt";
            this.SoundAvgTxt.ReadOnly = true;
            this.SoundAvgTxt.Size = new System.Drawing.Size(100, 20);
            this.SoundAvgTxt.TabIndex = 0;
            // 
            // LightAvgTxt
            // 
            this.LightAvgTxt.Location = new System.Drawing.Point(712, 82);
            this.LightAvgTxt.Name = "LightAvgTxt";
            this.LightAvgTxt.ReadOnly = true;
            this.LightAvgTxt.Size = new System.Drawing.Size(100, 20);
            this.LightAvgTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sound Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Light Average";
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
            this.ProfileBtn.Location = new System.Drawing.Point(967, 4);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(44, 46);
            this.ProfileBtn.TabIndex = 8;
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
            this.Logout.Location = new System.Drawing.Point(1017, 4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(46, 46);
            this.Logout.TabIndex = 9;
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
            this.Homebtn.Location = new System.Drawing.Point(12, 15);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(75, 41);
            this.Homebtn.TabIndex = 10;
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
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
            this.UserSettingsbtn.Location = new System.Drawing.Point(914, 4);
            this.UserSettingsbtn.Name = "UserSettingsbtn";
            this.UserSettingsbtn.Size = new System.Drawing.Size(47, 43);
            this.UserSettingsbtn.TabIndex = 5;
            this.UserSettingsbtn.UseVisualStyleBackColor = false;
            this.UserSettingsbtn.Click += new System.EventHandler(this.UserSettingsbtn_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1064, 651);
            this.Controls.Add(this.UserSettingsbtn);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Statslbl);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Statslbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LightAvgTxt;
        private System.Windows.Forms.TextBox SoundAvgTxt;
        private FontAwesome.Sharp.IconButton ProfileBtn;
        private FontAwesome.Sharp.IconButton Logout;
        private FontAwesome.Sharp.IconButton Homebtn;
        private FontAwesome.Sharp.IconButton UserSettingsbtn;
    }
}