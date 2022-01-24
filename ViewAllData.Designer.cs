namespace WinFormIOTProject
{
    partial class ViewAllData
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
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.Statslbl = new System.Windows.Forms.Label();
            this.Homebtn = new FontAwesome.Sharp.IconButton();
            this.UserSettingsbtn = new FontAwesome.Sharp.IconButton();
            this.Logout = new FontAwesome.Sharp.IconButton();
            this.ProfileBtn = new FontAwesome.Sharp.IconButton();
            this.labelAF = new System.Windows.Forms.Label();
            this.dataGridViewL = new System.Windows.Forms.DataGridView();
            this.labelL = new System.Windows.Forms.Label();
            this.labelPRI = new System.Windows.Forms.Label();
            this.dataGridViewPRI = new System.Windows.Forms.DataGridView();
            this.Temperatue = new System.Windows.Forms.Label();
            this.dataGridViewT = new System.Windows.Forms.DataGridView();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.labelW = new System.Windows.Forms.Label();
            this.dataGridViewW = new System.Windows.Forms.DataGridView();
            this.labelU = new System.Windows.Forms.Label();
            this.dataGridViewU = new System.Windows.Forms.DataGridView();
            this.labelS = new System.Windows.Forms.Label();
            this.dataGridViewS = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.Location = new System.Drawing.Point(4, 432);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.Size = new System.Drawing.Size(447, 287);
            this.dataGridViewA.TabIndex = 0;
            this.dataGridViewA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Statslbl
            // 
            this.Statslbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Statslbl.AutoSize = true;
            this.Statslbl.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statslbl.Location = new System.Drawing.Point(367, 31);
            this.Statslbl.Name = "Statslbl";
            this.Statslbl.Size = new System.Drawing.Size(138, 24);
            this.Statslbl.TabIndex = 1;
            this.Statslbl.Text = "All Ras Pi data";
            // 
            // Homebtn
            // 
            this.Homebtn.FlatAppearance.BorderSize = 0;
            this.Homebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Homebtn.IconColor = System.Drawing.Color.Black;
            this.Homebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Homebtn.Location = new System.Drawing.Point(5, 31);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(75, 41);
            this.Homebtn.TabIndex = 11;
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
            this.UserSettingsbtn.Location = new System.Drawing.Point(680, 12);
            this.UserSettingsbtn.Name = "UserSettingsbtn";
            this.UserSettingsbtn.Size = new System.Drawing.Size(47, 43);
            this.UserSettingsbtn.TabIndex = 12;
            this.UserSettingsbtn.UseVisualStyleBackColor = false;
            this.UserSettingsbtn.Click += new System.EventHandler(this.UserSettingsbtn_Click);
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
            this.Logout.Location = new System.Drawing.Point(783, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(46, 46);
            this.Logout.TabIndex = 14;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
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
            this.ProfileBtn.Location = new System.Drawing.Point(733, 12);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(44, 46);
            this.ProfileBtn.TabIndex = 13;
            this.ProfileBtn.UseVisualStyleBackColor = false;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // labelAF
            // 
            this.labelAF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAF.AutoSize = true;
            this.labelAF.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAF.Location = new System.Drawing.Point(3, 393);
            this.labelAF.Name = "labelAF";
            this.labelAF.Size = new System.Drawing.Size(118, 24);
            this.labelAF.TabIndex = 15;
            this.labelAF.Text = "Active RFID";
            // 
            // dataGridViewL
            // 
            this.dataGridViewL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.dataGridViewL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewL.Location = new System.Drawing.Point(514, 432);
            this.dataGridViewL.Name = "dataGridViewL";
            this.dataGridViewL.Size = new System.Drawing.Size(515, 287);
            this.dataGridViewL.TabIndex = 16;
            this.dataGridViewL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // labelL
            // 
            this.labelL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(513, 393);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(101, 24);
            this.labelL.TabIndex = 17;
            this.labelL.Text = "Light Data";
            // 
            // labelPRI
            // 
            this.labelPRI.AutoSize = true;
            this.labelPRI.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPRI.Location = new System.Drawing.Point(522, 746);
            this.labelPRI.Name = "labelPRI";
            this.labelPRI.Size = new System.Drawing.Size(80, 24);
            this.labelPRI.TabIndex = 21;
            this.labelPRI.Text = "Pri Data";
            // 
            // dataGridViewPRI
            // 
            this.dataGridViewPRI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.dataGridViewPRI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPRI.Location = new System.Drawing.Point(514, 783);
            this.dataGridViewPRI.Name = "dataGridViewPRI";
            this.dataGridViewPRI.Size = new System.Drawing.Size(515, 287);
            this.dataGridViewPRI.TabIndex = 20;
            this.dataGridViewPRI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // Temperatue
            // 
            this.Temperatue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Temperatue.AutoSize = true;
            this.Temperatue.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperatue.Location = new System.Drawing.Point(4, 746);
            this.Temperatue.Name = "Temperatue";
            this.Temperatue.Size = new System.Drawing.Size(169, 24);
            this.Temperatue.TabIndex = 19;
            this.Temperatue.Text = "Temperature Data";
            // 
            // dataGridViewT
            // 
            this.dataGridViewT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.dataGridViewT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewT.Location = new System.Drawing.Point(4, 783);
            this.dataGridViewT.Name = "dataGridViewT";
            this.dataGridViewT.Size = new System.Drawing.Size(466, 287);
            this.dataGridViewT.TabIndex = 18;
            this.dataGridViewT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            // 
            // dataGridView7
            // 
            this.dataGridView7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(514, 1489);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(515, 302);
            this.dataGridView7.TabIndex = 32;
            this.dataGridView7.Visible = false;
            // 
            // labelW
            // 
            this.labelW.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelW.AutoSize = true;
            this.labelW.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW.Location = new System.Drawing.Point(3, 1450);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(110, 24);
            this.labelW.TabIndex = 31;
            this.labelW.Text = "Water Data";
            // 
            // dataGridViewW
            // 
            this.dataGridViewW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.dataGridViewW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewW.Location = new System.Drawing.Point(4, 1489);
            this.dataGridViewW.Name = "dataGridViewW";
            this.dataGridViewW.Size = new System.Drawing.Size(466, 278);
            this.dataGridViewW.TabIndex = 30;
            this.dataGridViewW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView8_CellClick);
            // 
            // labelU
            // 
            this.labelU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelU.AutoSize = true;
            this.labelU.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelU.Location = new System.Drawing.Point(513, 1091);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(149, 24);
            this.labelU.TabIndex = 29;
            this.labelU.Text = "UltraSonic Data";
            // 
            // dataGridViewU
            // 
            this.dataGridViewU.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.dataGridViewU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewU.Location = new System.Drawing.Point(514, 1128);
            this.dataGridViewU.Name = "dataGridViewU";
            this.dataGridViewU.Size = new System.Drawing.Size(515, 287);
            this.dataGridViewU.TabIndex = 28;
            this.dataGridViewU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView9_CellClick);
            // 
            // labelS
            // 
            this.labelS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.Location = new System.Drawing.Point(4, 1091);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(111, 24);
            this.labelS.TabIndex = 27;
            this.labelS.Text = "Sound Data";
            // 
            // dataGridViewS
            // 
            this.dataGridViewS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.dataGridViewS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewS.Location = new System.Drawing.Point(4, 1128);
            this.dataGridViewS.Name = "dataGridViewS";
            this.dataGridViewS.Size = new System.Drawing.Size(447, 287);
            this.dataGridViewS.TabIndex = 26;
            this.dataGridViewS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView10_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ToDateTimePicker);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.FilterBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Filter);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 226);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(745, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 39);
            this.button2.TabIndex = 64;
            this.button2.Text = "Filter both";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ID",
            "Date_Time",
            "Both",
            "None"});
            this.comboBox2.Location = new System.Drawing.Point(355, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 37);
            this.comboBox2.TabIndex = 63;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 62;
            this.label1.Text = "Filter by:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 24);
            this.label11.TabIndex = 40;
            this.label11.Text = "Show :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active_RFID",
            "Sound_Data",
            "Water_Data",
            "UltraSonic_Data",
            "Pri_Motion_Data",
            "Ligth_Data",
            "Temperature_Data",
            "ALL_Data"});
            this.comboBox1.Location = new System.Drawing.Point(81, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 61;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(604, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "To";
            this.label6.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(370, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 58;
            this.label10.Text = "From";
            this.label10.Visible = false;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ToDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ToDateTimePicker.Location = new System.Drawing.Point(608, 125);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ToDateTimePicker.TabIndex = 56;
            this.ToDateTimePicker.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 55;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 23, 2, 11, 53, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // FilterBtn
            // 
            this.FilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FilterBtn.Location = new System.Drawing.Point(369, 169);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(75, 23);
            this.FilterBtn.TabIndex = 54;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Visible = false;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Filter by ID";
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(851, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 45;
            this.button1.Text = "Reset Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.Location = new System.Drawing.Point(73, 166);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(75, 23);
            this.Filter.TabIndex = 44;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Visible = false;
            this.Filter.Click += new System.EventHandler(this.Filter_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(65, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 43;
            this.textBox1.Visible = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ViewAllData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1058, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView7);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.dataGridViewW);
            this.Controls.Add(this.labelU);
            this.Controls.Add(this.dataGridViewU);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.dataGridViewS);
            this.Controls.Add(this.labelPRI);
            this.Controls.Add(this.dataGridViewPRI);
            this.Controls.Add(this.Temperatue);
            this.Controls.Add(this.dataGridViewT);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.dataGridViewL);
            this.Controls.Add(this.labelAF);
            this.Controls.Add(this.UserSettingsbtn);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.Statslbl);
            this.Controls.Add(this.dataGridViewA);
            this.Name = "ViewAllData";
            this.Text = "ViewAllData";
            this.Load += new System.EventHandler(this.ViewAllData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewA;
        private System.Windows.Forms.Label Statslbl;
        private FontAwesome.Sharp.IconButton Homebtn;
        private FontAwesome.Sharp.IconButton UserSettingsbtn;
        private FontAwesome.Sharp.IconButton Logout;
        private FontAwesome.Sharp.IconButton ProfileBtn;
        private System.Windows.Forms.Label labelAF;
        private System.Windows.Forms.DataGridView dataGridViewL;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelPRI;
        private System.Windows.Forms.DataGridView dataGridViewPRI;
        private System.Windows.Forms.Label Temperatue;
        private System.Windows.Forms.DataGridView dataGridViewT;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.DataGridView dataGridViewW;
        private System.Windows.Forms.Label labelU;
        private System.Windows.Forms.DataGridView dataGridViewU;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.DataGridView dataGridViewS;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}