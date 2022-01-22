namespace WinFormIOTProject
{
    partial class UserSettingsForm
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
            this.Homebtn = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Enablebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Twofalbl = new System.Windows.Forms.Label();
            this.DisableBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Homebtn
            // 
            this.Homebtn.FlatAppearance.BorderSize = 0;
            this.Homebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Homebtn.IconColor = System.Drawing.Color.Black;
            this.Homebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Homebtn.Location = new System.Drawing.Point(26, 12);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(75, 42);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Enablebtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Twofalbl);
            this.groupBox1.Controls.Add(this.DisableBtn);
            this.groupBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(80, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 445);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Settings";
            // 
            // Enablebtn
            // 
            this.Enablebtn.Location = new System.Drawing.Point(650, 130);
            this.Enablebtn.Name = "Enablebtn";
            this.Enablebtn.Size = new System.Drawing.Size(75, 23);
            this.Enablebtn.TabIndex = 3;
            this.Enablebtn.Text = "Enable";
            this.Enablebtn.UseVisualStyleBackColor = true;
            this.Enablebtn.Click += new System.EventHandler(this.Enablebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Twofalbl
            // 
            this.Twofalbl.AutoSize = true;
            this.Twofalbl.Location = new System.Drawing.Point(567, 76);
            this.Twofalbl.Name = "Twofalbl";
            this.Twofalbl.Size = new System.Drawing.Size(214, 20);
            this.Twofalbl.TabIndex = 0;
            this.Twofalbl.Text = "Two factor Authentication";
            // 
            // DisableBtn
            // 
            this.DisableBtn.Location = new System.Drawing.Point(650, 130);
            this.DisableBtn.Name = "DisableBtn";
            this.DisableBtn.Size = new System.Drawing.Size(75, 23);
            this.DisableBtn.TabIndex = 2;
            this.DisableBtn.Text = "Disable";
            this.DisableBtn.UseVisualStyleBackColor = true;
            this.DisableBtn.Click += new System.EventHandler(this.DisableBtn_Click);
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1014, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Homebtn);
            this.Name = "UserSettingsForm";
            this.Text = "UserSettingsForm";
            this.Load += new System.EventHandler(this.UserSettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Homebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Enablebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Twofalbl;
        private System.Windows.Forms.Button DisableBtn;
    }
}