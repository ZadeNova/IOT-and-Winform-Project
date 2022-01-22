namespace WinFormIOTProject
{
    partial class ManageUserForm
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
            this.components = new System.ComponentModel.Container();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOTProjDBDataSet1 = new WinFormIOTProject.IOTProjDBDataSet1();
            this.iOTProjDBDataSet = new WinFormIOTProject.IOTProjDBDataSet();
            this.iOTProjDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAccountTableAdapter = new WinFormIOTProject.IOTProjDBDataSet1TableAdapters.UserAccountTableAdapter();
            this.UserSettingsbtn = new FontAwesome.Sharp.IconButton();
            this.ProfileBtn = new FontAwesome.Sharp.IconButton();
            this.Logout = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Usernametxtbox = new System.Windows.Forms.TextBox();
            this.Filterbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.iotProjDBDataSet2 = new WinFormIOTProject.IOTProjDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOTProjDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOTProjDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOTProjDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iotProjDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(6, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 46);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(354, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(39, 44);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "ManageUsers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 176);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userAccountBindingSource
            // 
            this.userAccountBindingSource.DataMember = "UserAccount";
            this.userAccountBindingSource.DataSource = this.iOTProjDBDataSet1;
            // 
            // iOTProjDBDataSet1
            // 
            this.iOTProjDBDataSet1.DataSetName = "IOTProjDBDataSet1";
            this.iOTProjDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iOTProjDBDataSet
            // 
            this.iOTProjDBDataSet.DataSetName = "IOTProjDBDataSet";
            this.iOTProjDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iOTProjDBDataSetBindingSource
            // 
            this.iOTProjDBDataSetBindingSource.DataSource = this.iOTProjDBDataSet;
            this.iOTProjDBDataSetBindingSource.Position = 0;
            // 
            // userAccountTableAdapter
            // 
            this.userAccountTableAdapter.ClearBeforeFill = true;
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
            this.UserSettingsbtn.Location = new System.Drawing.Point(830, 1);
            this.UserSettingsbtn.Name = "UserSettingsbtn";
            this.UserSettingsbtn.Size = new System.Drawing.Size(47, 43);
            this.UserSettingsbtn.TabIndex = 11;
            this.UserSettingsbtn.UseVisualStyleBackColor = true;
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
            this.ProfileBtn.Location = new System.Drawing.Point(883, 2);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(44, 46);
            this.ProfileBtn.TabIndex = 12;
            this.ProfileBtn.UseVisualStyleBackColor = true;
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
            this.Logout.Location = new System.Drawing.Point(933, 1);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(46, 46);
            this.Logout.TabIndex = 13;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(807, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter By:";
            // 
            // Usernametxtbox
            // 
            this.Usernametxtbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Usernametxtbox.Location = new System.Drawing.Point(810, 146);
            this.Usernametxtbox.Name = "Usernametxtbox";
            this.Usernametxtbox.Size = new System.Drawing.Size(100, 20);
            this.Usernametxtbox.TabIndex = 15;
            this.Usernametxtbox.TextChanged += new System.EventHandler(this.Usernametxtbox_TextChanged);
            // 
            // Filterbtn
            // 
            this.Filterbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Filterbtn.Location = new System.Drawing.Point(788, 190);
            this.Filterbtn.Name = "Filterbtn";
            this.Filterbtn.Size = new System.Drawing.Size(75, 23);
            this.Filterbtn.TabIndex = 16;
            this.Filterbtn.Text = "Filter";
            this.Filterbtn.UseVisualStyleBackColor = true;
            this.Filterbtn.Click += new System.EventHandler(this.Filterbtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(869, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reset Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Update Users Information";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(122, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(124, 357);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(355, 354);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 26;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Role";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(355, 309);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 24;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Phone_Number";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(561, 351);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 30;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "RFID_ID";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(561, 306);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 28;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Status";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(138, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 27);
            this.button2.TabIndex = 31;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(301, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 27);
            this.button3.TabIndex = 32;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // iotProjDBDataSet2
            // 
            this.iotProjDBDataSet2.DataSetName = "IOTProjDBDataSet";
            this.iotProjDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ManageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(980, 487);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Filterbtn);
            this.Controls.Add(this.Usernametxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.UserSettingsbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ManageUserForm";
            this.Text = "ManageUserForm";
            this.Load += new System.EventHandler(this.ManageUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOTProjDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOTProjDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOTProjDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iotProjDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource iOTProjDBDataSetBindingSource;
        private IOTProjDBDataSet iOTProjDBDataSet;
        private IOTProjDBDataSet1 iOTProjDBDataSet1;
        private System.Windows.Forms.BindingSource userAccountBindingSource;
        private IOTProjDBDataSet1TableAdapters.UserAccountTableAdapter userAccountTableAdapter;
        private FontAwesome.Sharp.IconButton UserSettingsbtn;
        private FontAwesome.Sharp.IconButton ProfileBtn;
        private FontAwesome.Sharp.IconButton Logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usernametxtbox;
        private System.Windows.Forms.Button Filterbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private IOTProjDBDataSet iotProjDBDataSet2;
    }
}