using System;
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
           

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new System.Net.NetworkCredential("OzymandiasNovaLux@gmail.com", "GamestoptotheMoon42069");
            // smtpClient.UseDefaultCredentials = true; // uncomment if you don't want to use the network credentials
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();

            //Setting From , To and CC
            mail.From = new MailAddress("OzymandiasNovaLux@gmail.com", "MyWeb Site");
            mail.To.Add(new MailAddress("lunasolprimenova@gmail.com"));
            //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));
            mail.Subject = "Testing email";
            mail.Body = "Hello motherfucker";
            mail.IsBodyHtml = true;

            smtpClient.Send(mail);



        }

     
        private void Emailtestbtn_Click(object sender, EventArgs e)
        {
            sendemail();
            MessageBox.Show("Email sent!");
        }
    }
}
