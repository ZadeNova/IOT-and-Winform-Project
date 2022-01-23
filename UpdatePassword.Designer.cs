namespace WinFormIOTProject
{
    partial class UpdatePassword
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
            this.updatepassgrp = new System.Windows.Forms.GroupBox();
            this.UpdatePassbtn = new System.Windows.Forms.Button();
            this.Cfmpasslbl = new System.Windows.Forms.Label();
            this.NewPasstxt = new System.Windows.Forms.TextBox();
            this.CurrentPasstxt = new System.Windows.Forms.TextBox();
            this.NewPasslbl = new System.Windows.Forms.Label();
            this.CurrentPasslbl = new System.Windows.Forms.Label();
            this.CfmNewPasstxt = new System.Windows.Forms.TextBox();
            this.updatepassgrp.SuspendLayout();
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
            this.Homebtn.IconSize = 40;
            this.Homebtn.Location = new System.Drawing.Point(23, 12);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(75, 43);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // updatepassgrp
            // 
            this.updatepassgrp.Controls.Add(this.UpdatePassbtn);
            this.updatepassgrp.Controls.Add(this.Cfmpasslbl);
            this.updatepassgrp.Controls.Add(this.NewPasstxt);
            this.updatepassgrp.Controls.Add(this.CurrentPasstxt);
            this.updatepassgrp.Controls.Add(this.NewPasslbl);
            this.updatepassgrp.Controls.Add(this.CurrentPasslbl);
            this.updatepassgrp.Controls.Add(this.CfmNewPasstxt);
            this.updatepassgrp.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatepassgrp.Location = new System.Drawing.Point(34, 74);
            this.updatepassgrp.Name = "updatepassgrp";
            this.updatepassgrp.Size = new System.Drawing.Size(933, 471);
            this.updatepassgrp.TabIndex = 1;
            this.updatepassgrp.TabStop = false;
            this.updatepassgrp.Text = "Update Password";
            // 
            // UpdatePassbtn
            // 
            this.UpdatePassbtn.Location = new System.Drawing.Point(400, 391);
            this.UpdatePassbtn.Name = "UpdatePassbtn";
            this.UpdatePassbtn.Size = new System.Drawing.Size(126, 30);
            this.UpdatePassbtn.TabIndex = 6;
            this.UpdatePassbtn.Text = "Update";
            this.UpdatePassbtn.UseVisualStyleBackColor = true;
            this.UpdatePassbtn.Click += new System.EventHandler(this.UpdatePassbtn_Click);
            // 
            // Cfmpasslbl
            // 
            this.Cfmpasslbl.AutoSize = true;
            this.Cfmpasslbl.Location = new System.Drawing.Point(242, 266);
            this.Cfmpasslbl.Name = "Cfmpasslbl";
            this.Cfmpasslbl.Size = new System.Drawing.Size(183, 20);
            this.Cfmpasslbl.TabIndex = 4;
            this.Cfmpasslbl.Text = "Confirm New Password";
            // 
            // NewPasstxt
            // 
            this.NewPasstxt.Location = new System.Drawing.Point(460, 196);
            this.NewPasstxt.Name = "NewPasstxt";
            this.NewPasstxt.Size = new System.Drawing.Size(204, 28);
            this.NewPasstxt.TabIndex = 3;
            // 
            // CurrentPasstxt
            // 
            this.CurrentPasstxt.Location = new System.Drawing.Point(460, 134);
            this.CurrentPasstxt.Name = "CurrentPasstxt";
            this.CurrentPasstxt.Size = new System.Drawing.Size(204, 28);
            this.CurrentPasstxt.TabIndex = 2;
            this.CurrentPasstxt.TextChanged += new System.EventHandler(this.CurrentPasstxt_TextChanged);
            // 
            // NewPasslbl
            // 
            this.NewPasslbl.AutoSize = true;
            this.NewPasslbl.Location = new System.Drawing.Point(242, 204);
            this.NewPasslbl.Name = "NewPasslbl";
            this.NewPasslbl.Size = new System.Drawing.Size(115, 20);
            this.NewPasslbl.TabIndex = 1;
            this.NewPasslbl.Text = "New Password";
            // 
            // CurrentPasslbl
            // 
            this.CurrentPasslbl.AutoSize = true;
            this.CurrentPasslbl.Location = new System.Drawing.Point(242, 134);
            this.CurrentPasslbl.Name = "CurrentPasslbl";
            this.CurrentPasslbl.Size = new System.Drawing.Size(139, 20);
            this.CurrentPasslbl.TabIndex = 0;
            this.CurrentPasslbl.Text = "Current Password";
            // 
            // CfmNewPasstxt
            // 
            this.CfmNewPasstxt.Location = new System.Drawing.Point(460, 263);
            this.CfmNewPasstxt.Name = "CfmNewPasstxt";
            this.CfmNewPasstxt.Size = new System.Drawing.Size(204, 28);
            this.CfmNewPasstxt.TabIndex = 5;
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1014, 583);
            this.Controls.Add(this.updatepassgrp);
            this.Controls.Add(this.Homebtn);
            this.Name = "UpdatePassword";
            this.Text = "UpdatePassword";
            this.updatepassgrp.ResumeLayout(false);
            this.updatepassgrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Homebtn;
        private System.Windows.Forms.GroupBox updatepassgrp;
        private System.Windows.Forms.TextBox CfmNewPasstxt;
        private System.Windows.Forms.Label Cfmpasslbl;
        private System.Windows.Forms.TextBox NewPasstxt;
        private System.Windows.Forms.TextBox CurrentPasstxt;
        private System.Windows.Forms.Label NewPasslbl;
        private System.Windows.Forms.Label CurrentPasslbl;
        private System.Windows.Forms.Button UpdatePassbtn;
    }
}