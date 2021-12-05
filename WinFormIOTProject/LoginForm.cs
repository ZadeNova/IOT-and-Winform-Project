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
    public partial class LoginForm : Form
    {



        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

       

       

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            // Add logic to check if user exist in database
            // Add validators too 
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            //
            //string strCommandText = "INSERT INTO UserAccounts(Name,Email,Password,Role,Status,RFID_ID) VALUES (@Name,@Email,@Password,@Role,@Status,@RFID_ID)";

            //SqlCommand cmd = new SqlCommand(strCommandText, myConnect);

            //Check if empty
            if (string.IsNullOrWhiteSpace(UsernameTxtbox.Text) || string.IsNullOrWhiteSpace(PasswordTxtBox.Text))
            {
                MessageBox.Show("IsEmpty");
            }
            else
            {
                MessageBox.Show("Not Empty");

                // Check if user and password exists in database
                string strCommandText = "SELECT * FROM UserAccounts WHERE Name=@uName AND Password=@pass";
                SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                cmd.Parameters.AddWithValue("@uName",UsernameTxtbox.Text);
                cmd.Parameters.AddWithValue("@pass", PasswordTxtBox.Text);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Enter into admin form
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        User.Username = UsernameTxtbox.Text;
                        
                        AdminDashboard form2 = new AdminDashboard();
                        form2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login Unsuccessful");

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
                finally
                {
                    myConnect.Close();
                }




                // Enter into admin dashboard
                

            }

            //string Username = UsernameTxtbox.Text;
            //string Password = PasswordTxtBox.Text;
            //MessageBox.Show(Username + Password);
        }

        private void ForgetPassBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordForm forgetpassform = new ForgotPasswordForm();
            forgetpassform.ShowDialog();


        }

        private void RFIDLoginBtn_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            
        }
    }
}
