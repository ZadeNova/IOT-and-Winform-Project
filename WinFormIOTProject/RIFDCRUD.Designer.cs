namespace WinFormIOTProject
{
    partial class RIFDCRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.RFIDtxtCheck = new System.Windows.Forms.TextBox();
            this.Checknowbtn = new System.Windows.Forms.Button();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.Checkerpage = new System.Windows.Forms.TabPage();
            this.idcardpic = new FontAwesome.Sharp.IconPictureBox();
            this.DeletePage = new System.Windows.Forms.TabPage();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.RFIDdeletetxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.UpdatePage = new System.Windows.Forms.TabPage();
            this.RFIDupdatetxt = new System.Windows.Forms.TextBox();
            this.Userupdatetxt = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.StatusPage = new System.Windows.Forms.TabPage();
            this.tabcontrol.SuspendLayout();
            this.Checkerpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idcardpic)).BeginInit();
            this.DeletePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.UpdatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "RFID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please scan your RFID card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "RFIDchecker";
            // 
            // Usernametxt
            // 
            this.Usernametxt.Location = new System.Drawing.Point(215, 208);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(216, 20);
            this.Usernametxt.TabIndex = 4;
            // 
            // RFIDtxtCheck
            // 
            this.RFIDtxtCheck.Location = new System.Drawing.Point(215, 125);
            this.RFIDtxtCheck.Name = "RFIDtxtCheck";
            this.RFIDtxtCheck.Size = new System.Drawing.Size(216, 20);
            this.RFIDtxtCheck.TabIndex = 5;
            this.RFIDtxtCheck.TextChanged += new System.EventHandler(this.RFIDtxtCheck_TextChanged);
            // 
            // Checknowbtn
            // 
            this.Checknowbtn.Location = new System.Drawing.Point(538, 168);
            this.Checknowbtn.Name = "Checknowbtn";
            this.Checknowbtn.Size = new System.Drawing.Size(162, 42);
            this.Checknowbtn.TabIndex = 6;
            this.Checknowbtn.Text = "Check now";
            this.Checknowbtn.UseVisualStyleBackColor = true;
            this.Checknowbtn.Click += new System.EventHandler(this.Checknowbtn_Click);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.Checkerpage);
            this.tabcontrol.Controls.Add(this.DeletePage);
            this.tabcontrol.Controls.Add(this.UpdatePage);
            this.tabcontrol.Controls.Add(this.StatusPage);
            this.tabcontrol.Location = new System.Drawing.Point(12, 38);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(769, 385);
            this.tabcontrol.TabIndex = 7;
            // 
            // Checkerpage
            // 
            this.Checkerpage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Checkerpage.Controls.Add(this.idcardpic);
            this.Checkerpage.Controls.Add(this.Checknowbtn);
            this.Checkerpage.Controls.Add(this.label1);
            this.Checkerpage.Controls.Add(this.RFIDtxtCheck);
            this.Checkerpage.Controls.Add(this.label2);
            this.Checkerpage.Controls.Add(this.Usernametxt);
            this.Checkerpage.Controls.Add(this.label3);
            this.Checkerpage.Controls.Add(this.label4);
            this.Checkerpage.Location = new System.Drawing.Point(4, 22);
            this.Checkerpage.Name = "Checkerpage";
            this.Checkerpage.Padding = new System.Windows.Forms.Padding(3);
            this.Checkerpage.Size = new System.Drawing.Size(761, 359);
            this.Checkerpage.TabIndex = 0;
            this.Checkerpage.Text = "Checker";
            // 
            // idcardpic
            // 
            this.idcardpic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.idcardpic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idcardpic.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.idcardpic.IconColor = System.Drawing.SystemColors.ControlText;
            this.idcardpic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.idcardpic.Location = new System.Drawing.Point(268, 29);
            this.idcardpic.Name = "idcardpic";
            this.idcardpic.Size = new System.Drawing.Size(32, 32);
            this.idcardpic.TabIndex = 7;
            this.idcardpic.TabStop = false;
            // 
            // DeletePage
            // 
            this.DeletePage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DeletePage.Controls.Add(this.Deletebtn);
            this.DeletePage.Controls.Add(this.RFIDdeletetxt);
            this.DeletePage.Controls.Add(this.label7);
            this.DeletePage.Controls.Add(this.label6);
            this.DeletePage.Controls.Add(this.label5);
            this.DeletePage.Controls.Add(this.iconPictureBox1);
            this.DeletePage.Location = new System.Drawing.Point(4, 22);
            this.DeletePage.Name = "DeletePage";
            this.DeletePage.Padding = new System.Windows.Forms.Padding(3);
            this.DeletePage.Size = new System.Drawing.Size(761, 359);
            this.DeletePage.TabIndex = 1;
            this.DeletePage.Text = "Delete";
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(624, 145);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(108, 39);
            this.Deletebtn.TabIndex = 5;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // RFIDdeletetxt
            // 
            this.RFIDdeletetxt.Location = new System.Drawing.Point(262, 164);
            this.RFIDdeletetxt.Name = "RFIDdeletetxt";
            this.RFIDdeletetxt.Size = new System.Drawing.Size(319, 20);
            this.RFIDdeletetxt.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 27);
            this.label7.TabIndex = 3;
            this.label7.Text = "Delete RFID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "RFID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Please scan your RFID card";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(277, 47);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // UpdatePage
            // 
            this.UpdatePage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UpdatePage.Controls.Add(this.RFIDupdatetxt);
            this.UpdatePage.Controls.Add(this.Userupdatetxt);
            this.UpdatePage.Controls.Add(this.iconPictureBox2);
            this.UpdatePage.Controls.Add(this.label11);
            this.UpdatePage.Controls.Add(this.label10);
            this.UpdatePage.Controls.Add(this.label9);
            this.UpdatePage.Controls.Add(this.label8);
            this.UpdatePage.Controls.Add(this.Updatebtn);
            this.UpdatePage.Location = new System.Drawing.Point(4, 22);
            this.UpdatePage.Name = "UpdatePage";
            this.UpdatePage.Padding = new System.Windows.Forms.Padding(3);
            this.UpdatePage.Size = new System.Drawing.Size(761, 359);
            this.UpdatePage.TabIndex = 2;
            this.UpdatePage.Text = "Update";
            // 
            // RFIDupdatetxt
            // 
            this.RFIDupdatetxt.Location = new System.Drawing.Point(290, 215);
            this.RFIDupdatetxt.Name = "RFIDupdatetxt";
            this.RFIDupdatetxt.Size = new System.Drawing.Size(247, 20);
            this.RFIDupdatetxt.TabIndex = 7;
            // 
            // Userupdatetxt
            // 
            this.Userupdatetxt.Location = new System.Drawing.Point(290, 159);
            this.Userupdatetxt.Name = "Userupdatetxt";
            this.Userupdatetxt.Size = new System.Drawing.Size(247, 20);
            this.Userupdatetxt.TabIndex = 6;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(299, 47);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 5;
            this.iconPictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(286, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Please scan your RFID card";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "RFID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(337, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Add RFID";
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(625, 161);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(92, 41);
            this.Updatebtn.TabIndex = 0;
            this.Updatebtn.Text = "Add";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // StatusPage
            // 
            this.StatusPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StatusPage.Location = new System.Drawing.Point(4, 22);
            this.StatusPage.Name = "StatusPage";
            this.StatusPage.Padding = new System.Windows.Forms.Padding(3);
            this.StatusPage.Size = new System.Drawing.Size(761, 359);
            this.StatusPage.TabIndex = 3;
            this.StatusPage.Text = "Status";
            // 
            // RIFDCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(793, 470);
            this.Controls.Add(this.tabcontrol);
            this.Name = "RIFDCRUD";
            this.Text = "RFIDTEST";
            this.Load += new System.EventHandler(this.RFIDTEST_Load);
            this.tabcontrol.ResumeLayout(false);
            this.Checkerpage.ResumeLayout(false);
            this.Checkerpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idcardpic)).EndInit();
            this.DeletePage.ResumeLayout(false);
            this.DeletePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.UpdatePage.ResumeLayout(false);
            this.UpdatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.TextBox RFIDtxtCheck;
        private System.Windows.Forms.Button Checknowbtn;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage Checkerpage;
        private FontAwesome.Sharp.IconPictureBox idcardpic;
        private System.Windows.Forms.TabPage DeletePage;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox RFIDdeletetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TabPage UpdatePage;
        private System.Windows.Forms.TextBox RFIDupdatetxt;
        private System.Windows.Forms.TextBox Userupdatetxt;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.TabPage StatusPage;
    }
}