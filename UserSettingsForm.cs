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
    public partial class UserSettingsForm : Form
    {

        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;

        public UserSettingsForm()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdminDashboard adminform = new AdminDashboard();
            adminform.ShowDialog();

        }

      
        private void UserSettingsForm_Load(object sender, EventArgs e)
        {

            try
            {
                SqlConnection myConnect = new SqlConnection(strConnectionString);
                myConnect.Open();
                string strCommandText = "SELECT * FROM TwoFactorAuthenticationTable WHERE Name=@uname AND Email2FA = @Email2fa";
                SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                cmd.Parameters.AddWithValue("@uname", User.AccountUsername);
                cmd.Parameters.AddWithValue("@Email2fa", "True");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Enablebtn.Hide();
                    DisableBtn.Show();
                    DisableBtn.BringToFront();
                }
                else
                {
                    DisableBtn.Hide();
                    Enablebtn.Show();
                    Enablebtn.BringToFront();
                   
                
                }




               
            }
           catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }



        }

        private void Enablebtn_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            string strCommandText = "UPDATE TwoFactorAuthenticationTable SET Email2FA = @Email2fa  WHERE Name=@uname";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@uname", User.AccountUsername);
            cmd.Parameters.AddWithValue("@Email2fa", "True");
            cmd.ExecuteNonQuery();



            Enablebtn.Hide();
            DisableBtn.Show();
            DisableBtn.BringToFront();
        }

        private void DisableBtn_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            string strCommandText = "UPDATE TwoFactorAuthenticationTable SET Email2FA = @Email2fa  WHERE Name=@uname";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@uname", User.AccountUsername);
            cmd.Parameters.AddWithValue("@Email2fa", "False");
            cmd.ExecuteNonQuery();



            DisableBtn.Hide();
            Enablebtn.Show();
            Enablebtn.BringToFront();


        }
    }
}
