namespace WinFormIOTProject
{
    partial class Ras_Pie_Setting
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RaspBoxGrp = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.UserSettingsbtn = new FontAwesome.Sharp.IconButton();
            this.ProfileBtn = new FontAwesome.Sharp.IconButton();
            this.Logout = new FontAwesome.Sharp.IconButton();
            this.iOTProjDBDataSet = new WinFormIOTProject.IOTProjDBDataSet();
            this.iOTProjDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.Label();
            this.avgsoundvalue = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new WinFormIOTProject.IOTProjDBDataSet1TableAdapters.TableAdapterManager();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.RaspBoxGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOTProjDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOTProjDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(450, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Settings";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RaspBoxGrp
            // 
            this.RaspBoxGrp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RaspBoxGrp.Controls.Add(this.dataGridView1);
            this.RaspBoxGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaspBoxGrp.Location = new System.Drawing.Point(12, 93);
            this.RaspBoxGrp.Name = "RaspBoxGrp";
            this.RaspBoxGrp.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.RaspBoxGrp.Size = new System.Drawing.Size(977, 262);
            this.RaspBoxGrp.TabIndex = 3;
            this.RaspBoxGrp.TabStop = false;
            this.RaspBoxGrp.Text = "Winform Ras Pi Setting";
            this.RaspBoxGrp.Enter += new System.EventHandler(this.RaspBoxGrp_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(963, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.UserSettingsbtn.Location = new System.Drawing.Point(887, 5);
            this.UserSettingsbtn.Name = "UserSettingsbtn";
            this.UserSettingsbtn.Size = new System.Drawing.Size(47, 43);
            this.UserSettingsbtn.TabIndex = 7;
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
            this.ProfileBtn.Location = new System.Drawing.Point(940, 2);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(44, 46);
            this.ProfileBtn.TabIndex = 8;
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
            this.Logout.Location = new System.Drawing.Point(981, 2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(46, 46);
            this.Logout.TabIndex = 9;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
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
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.Location = new System.Drawing.Point(184, 362);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // UserId
            // 
            this.UserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserId.AutoSize = true;
            this.UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserId.Location = new System.Drawing.Point(7, 358);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(80, 25);
            this.UserId.TabIndex = 9;
            this.UserId.Text = "UserId";
            // 
            // avgsoundvalue
            // 
            this.avgsoundvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avgsoundvalue.AutoSize = true;
            this.avgsoundvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgsoundvalue.Location = new System.Drawing.Point(7, 405);
            this.avgsoundvalue.Name = "avgsoundvalue";
            this.avgsoundvalue.Size = new System.Drawing.Size(171, 25);
            this.avgsoundvalue.TabIndex = 11;
            this.avgsoundvalue.Text = "avgsoundvalue";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox3.Location = new System.Drawing.Point(184, 408);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "soundstatus1";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox4.Location = new System.Drawing.Point(184, 512);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "soundstatus";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox5.Location = new System.Drawing.Point(184, 459);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(124, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "lightvalue";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox6.Location = new System.Drawing.Point(544, 365);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(124, 20);
            this.textBox6.TabIndex = 22;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            this.textBox6.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6_Validating);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 649);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "waterstatus1";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox7.Location = new System.Drawing.Point(186, 653);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(124, 20);
            this.textBox7.TabIndex = 20;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.Validating += new System.ComponentModel.CancelEventHandler(this.textBox7_Validating);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "waterstatus";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox8.Location = new System.Drawing.Point(186, 602);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(124, 20);
            this.textBox8.TabIndex = 18;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.textBox8.Validating += new System.ComponentModel.CancelEventHandler(this.textBox8_Validating);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "watervalue";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox9.Location = new System.Drawing.Point(186, 556);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(124, 20);
            this.textBox9.TabIndex = 16;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            this.textBox9.Validating += new System.ComponentModel.CancelEventHandler(this.textBox9_Validating);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = WinFormIOTProject.IOTProjDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserAccountTableAdapter = null;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 647);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "ultravalue";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox10.Location = new System.Drawing.Point(546, 650);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(124, 20);
            this.textBox10.TabIndex = 34;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            this.textBox10.Validating += new System.ComponentModel.CancelEventHandler(this.textBox10_Validating);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(369, 600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "temstatus1";
            // 
            // textBox11
            // 
            this.textBox11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox11.Location = new System.Drawing.Point(546, 604);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(124, 20);
            this.textBox11.TabIndex = 32;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            this.textBox11.Validating += new System.ComponentModel.CancelEventHandler(this.textBox11_Validating);
            // 
            // textBox12
            // 
            this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox12.Location = new System.Drawing.Point(544, 410);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(124, 20);
            this.textBox12.TabIndex = 24;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            this.textBox12.Validating += new System.ComponentModel.CancelEventHandler(this.textBox12_Validating);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(367, 557);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "temstatus";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "ligtstatus";
            // 
            // textBox13
            // 
            this.textBox13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox13.Location = new System.Drawing.Point(544, 560);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(124, 20);
            this.textBox13.TabIndex = 30;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            this.textBox13.Validating += new System.ComponentModel.CancelEventHandler(this.textBox13_Validating);
            // 
            // textBox14
            // 
            this.textBox14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox14.Location = new System.Drawing.Point(544, 456);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(124, 20);
            this.textBox14.TabIndex = 26;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            this.textBox14.Validating += new System.ComponentModel.CancelEventHandler(this.textBox14_Validating);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "temvalue";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(367, 453);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "ligtstatus1";
            // 
            // textBox15
            // 
            this.textBox15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox15.Location = new System.Drawing.Point(544, 507);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(124, 20);
            this.textBox15.TabIndex = 28;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            this.textBox15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox15_KeyPress);
            this.textBox15.Validating += new System.ComponentModel.CancelEventHandler(this.textBox15_Validating);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(688, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 25);
            this.label13.TabIndex = 39;
            this.label13.Text = "ultrastatus1";
            // 
            // textBox16
            // 
            this.textBox16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox16.Location = new System.Drawing.Point(865, 415);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(124, 20);
            this.textBox16.TabIndex = 38;
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            this.textBox16.Validating += new System.ComponentModel.CancelEventHandler(this.textBox16_Validating);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(688, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 25);
            this.label14.TabIndex = 37;
            this.label14.Text = "ultrastatus";
            // 
            // textBox17
            // 
            this.textBox17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox17.Location = new System.Drawing.Point(865, 369);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(124, 20);
            this.textBox17.TabIndex = 36;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            this.textBox17.Validating += new System.ComponentModel.CancelEventHandler(this.textBox17_Validating);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(706, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 50);
            this.button1.TabIndex = 40;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(845, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 50);
            this.button2.TabIndex = 41;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ras_Pie_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1027, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserSettingsbtn);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RaspBoxGrp);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.avgsoundvalue);
            this.Controls.Add(this.textBox5);
            this.Name = "Ras_Pie_Setting";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.RaspBoxGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOTProjDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOTProjDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox RaspBoxGrp;
        private FontAwesome.Sharp.IconButton Home;
        private FontAwesome.Sharp.IconButton UserSettingsbtn;
        private FontAwesome.Sharp.IconButton ProfileBtn;
        private FontAwesome.Sharp.IconButton Logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IOTProjDBDataSet iOTProjDBDataSet;
        private System.Windows.Forms.BindingSource iOTProjDBDataSetBindingSource;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label avgsoundvalue;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private IOTProjDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}