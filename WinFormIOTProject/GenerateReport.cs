using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormIOTProject
{
    public partial class GenerateReport : Form
    {
        public GenerateReport()
        {
            InitializeComponent();
        }

       

        private void GenerateReport_Load(object sender, EventArgs e)
        {

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void ProfileBtn_Click_1(object sender, EventArgs e)
        {
            AdminDashboard.ActiveForm.Close();
            ProfilePage ProfileForm = new ProfilePage();

            ProfileForm.Show();
        }

        private void UserSettingsbtn_Click(object sender, EventArgs e)
        {
            AdminDashboard.ActiveForm.Close();
            UserSettingsForm usersettingform = new UserSettingsForm();
            usersettingform.Show();
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
    }
}
