namespace WinFormIOTProject
{
    partial class RFIDLoginForm
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
            this.RFIDLoginFormLabel = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RFIDtxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Testingbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RFIDLoginFormLabel
            // 
            this.RFIDLoginFormLabel.AutoSize = true;
            this.RFIDLoginFormLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFIDLoginFormLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RFIDLoginFormLabel.Location = new System.Drawing.Point(231, 25);
            this.RFIDLoginFormLabel.Name = "RFIDLoginFormLabel";
            this.RFIDLoginFormLabel.Size = new System.Drawing.Size(127, 27);
            this.RFIDLoginFormLabel.TabIndex = 0;
            this.RFIDLoginFormLabel.Text = "RFID Login ";
            this.RFIDLoginFormLabel.Click += new System.EventHandler(this.RFIDLoginFormLabel_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Aquamarine;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Aquamarine;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(195, 25);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(40, 32);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(191, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Scan your RFID card";
            // 
            // RFIDtxt
            // 
            this.RFIDtxt.Location = new System.Drawing.Point(173, 195);
            this.RFIDtxt.Name = "RFIDtxt";
            this.RFIDtxt.Size = new System.Drawing.Size(266, 20);
            this.RFIDtxt.TabIndex = 3;
            this.RFIDtxt.TextChanged += new System.EventHandler(this.RFIDtxt_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Testingbtn
            // 
            this.Testingbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Testingbtn.Location = new System.Drawing.Point(373, 288);
            this.Testingbtn.Name = "Testingbtn";
            this.Testingbtn.Size = new System.Drawing.Size(75, 23);
            this.Testingbtn.TabIndex = 4;
            this.Testingbtn.Text = "Click me";
            this.Testingbtn.UseVisualStyleBackColor = true;
            this.Testingbtn.Click += new System.EventHandler(this.Testingbtn_Click);
            // 
            // RFIDLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(647, 440);
            this.Controls.Add(this.Testingbtn);
            this.Controls.Add(this.RFIDtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.RFIDLoginFormLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "RFIDLoginForm";
            this.Text = "RFIDLoginForm";
            this.Load += new System.EventHandler(this.RFIDLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RFIDLoginFormLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RFIDtxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Testingbtn;
    }
}