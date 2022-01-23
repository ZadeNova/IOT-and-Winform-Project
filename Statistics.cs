using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace WinFormIOTProject
{
    public partial class Statistics : Form
    {
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // Sound Avg
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            string strCommandText = "SELECT AVG(Sound) AS AVG_Sound FROM Sound_table";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                SoundAvgTxt.Text = reader["AVG_Sound"].ToString();
            }
            myConnect.Close();


            SqlConnection myConnect2 = new SqlConnection(strConnectionString);
            myConnect2.Open();
            string strCommandText2 = "SELECT AVG(LIGHT) AS AVG_Light FROM Light_table";
            SqlCommand cmd2 = new SqlCommand(strCommandText2, myConnect2);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                LightAvgTxt.Text = reader2["AVG_Light"].ToString();
            }

            myConnect2.Close();

            



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

        private void ProfileBtn_Click(object sender, EventArgs e)
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

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
