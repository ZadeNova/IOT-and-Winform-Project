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

       

      
     
      

        private void Home_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserSettingsbtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            AdminDashboard.ActiveForm.Close();
            UserSettingsForm usersettingform = new UserSettingsForm();
            usersettingform.Show();
            
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            AdminDashboard.ActiveForm.Close();
            ProfilePage ProfileForm = new ProfilePage();
            
            ProfileForm.Show();
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            AdminDashboard.ActiveForm.Close();
            LoginForm logform = new LoginForm();
            logform.ShowDialog();
            User.AccountEmail = "";
            User.AccountID = 0;
            User.AccountRole = "";
            User.AccountRole = "";
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void Useless_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Application.OpenForms);
            foreach (Form x in Application.OpenForms)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(AdminDashboard.ActiveForm);
            AdminDashboard.ActiveForm.Close();
        }
    }
}
