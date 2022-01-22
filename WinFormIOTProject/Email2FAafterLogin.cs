using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Configuration;



namespace WinFormIOTProject
{
    public partial class Email2FAafterLogin : Form
    {

        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        string NewCode;
        string StoredCode;

        public Email2FAafterLogin()
        {
            InitializeComponent();
            

        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {


            if (TwoFAtxt.Text.Equals(StoredCode))
            {

                MessageBox.Show("Correct code entered! Go in!");
                AdminDashboard adminform = new AdminDashboard();
                adminform.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not correct! Enter the code received in your email again!");

            }









        }

        private void Email2FAafterLogin_Load(object sender, EventArgs e)
        {


            NewCode = CodeGenerator();
            StoredCode = NewCode;
            SendEmail(User.AccountEmail);
            //SqlConnection myConnect = new SqlConnection(strConnectionString);
            //myConnect.Open();
            //string strCommandText2 = "SELECT * FROM TwoFactorAuthenticationTable WHERE Name = @Name";

            //SqlCommand cmd2 = new SqlCommand(strCommandText2, myConnect);
            //cmd2.Parameters.AddWithValue("@Name", User.AccountUsername);
            //SqlDataReader reader = cmd2.ExecuteReader();

            

        }





        private void SendEmail(string Email)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new System.Net.NetworkCredential("OzymandiasNovaLux@gmail.com", "GamestoptotheMoon42069");
            // smtpClient.UseDefaultCredentials = true; // uncomment if you don't want to use the network credentials
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            
            MailMessage mail = new MailMessage();


            //New password


            //Setting From , To and CC
            mail.From = new MailAddress("OzymandiasNovaLux@gmail.com", "Windows Form IOT");
            mail.To.Add(new MailAddress(Email));
            //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

            mail.Subject = "Two Factor Authentication Email";
            mail.Body = $"Here is your code to enter {NewCode}" ;
            mail.IsBodyHtml = true;

            smtpClient.Send(mail);
        }


        private string CodeGenerator()
        {

            // Password 8 characters in length 
            // Password with 1 special character

            string characterpool = "abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()";
            Random rand = new Random();
            Console.WriteLine(rand.Next(0, 8));

            string NewPass = "";
            for (int i = 0; i < 8; i++)
            {
                NewPass = NewPass + characterpool[rand.Next(0, 36)];
            }
            

            return NewPass;

        }

        private void Sendemailagainbtn_Click(object sender, EventArgs e)
        {
            NewCode = CodeGenerator();
            StoredCode = NewCode;
            SendEmail(User.AccountEmail);
            MessageBox.Show("New code has been sent to your email.");

        }

        private void Backtologin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logform = new LoginForm();
            logform.ShowDialog();
        }

        private void TwoFAtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
