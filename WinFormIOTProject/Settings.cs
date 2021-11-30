﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;



namespace WinFormIOTProject
{
    public partial class Settings : Form
    {

        //Email stuff
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;



        public Settings()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendemail()
        {
            //login = new NetworkCredential(Username,Password);
            //client = new SmtpClient(txtsmtp.text);
            //client.Port = Convert.ToInt32(text);
            //client.EnableSsl = chkSSL.Checked;
            //client.Credentials = login;
            //msg = new MailMessage { From = new MailAddress(Username + txtsmtp.text.replace("smtp.", "@"), "Name", Encoding.UTF8) };
            //msg.To.Add(new MailAddress(txtTo.Text));
            //if (!string.IsNullOrEmpty(txtCC.Text))
            //msg.To.Add(new MailAddress(txtCC.Text));
            //msg.Subject = txtSubject.Text;
            //msg.Body = txtMessage.Text;
            //msg.BodyEncoding = Encoding.UTF8;
            //msg.IsBodyHtml = true;
            //msg.Priority = MailPriority.Normal;
            //msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);



        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(String.Format("{0} send canceled", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
