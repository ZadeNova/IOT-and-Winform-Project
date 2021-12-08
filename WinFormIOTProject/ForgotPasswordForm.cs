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
using System.Data.SqlClient;
using System.Configuration;


namespace WinFormIOTProject
{
    public partial class ForgotPasswordForm : Form
    {

        string NewPass = "";
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void EmailBoxTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void ResetPassBtn_Click(object sender, EventArgs e)
        {



            SendEmail();

            // Update User password in database with new Password
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            string strCommandText = "UPDATE UserAccounts SET Password = @uPassword WHERE Email = @uEmail";


            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@uPassword", NewPass);
            cmd.Parameters.AddWithValue("@uEmail", EmailBoxTxt.Text);


            cmd.ExecuteNonQuery();
            myConnect.Close();

            LoginForm loginform = new LoginForm();
            this.Hide();
            loginform.ShowDialog();





        }





        private void SendEmail()
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new System.Net.NetworkCredential("OzymandiasNovaLux@gmail.com", "GamestoptotheMoon42069");
            // smtpClient.UseDefaultCredentials = true; // uncomment if you don't want to use the network credentials
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();


            //New password
            

            //Setting From , To and CC
            mail.From = new MailAddress("OzymandiasNovaLux@gmail.com", "MyWeb Site");
            mail.To.Add(new MailAddress("lunasolprimenova@gmail.com"));
            //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

            mail.Subject = "Testing email";
            mail.Body = $"Hello it appears that you have asked for a password reset.Here is your new password: {NewPass}";
            mail.IsBodyHtml = true;

            smtpClient.Send(mail);
        }

        // 

        private void PassGenerator()
        {

            // Password 8 characters in length 
            // Password with 1 special character
            
            string characterpool = "abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()";
            Random rand = new Random();
            Console.WriteLine(rand.Next(0, 8));

            string NewPass = "";
            for (int i = 0; i < 7; i++)
            {
                NewPass = NewPass + characterpool[rand.Next(0, 36)];
            }
            NewPass = NewPass + characterpool[rand.Next(36, 46)];

            
        }
        


    }
}
