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
                




                // Check if user and password exists in database
                string strCommandText = "SELECT * FROM UserAccount WHERE Name=@uName";
                SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                cmd.Parameters.AddWithValue("@uName",UsernameTxtbox.Text);
                

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        bool flag = Hash.VerifyHash(PasswordTxtBox.Text, "SHA512", reader["Password"].ToString());
                        if (flag)
                        {
                            
                            // Enter into admin form
                            //MessageBox.Show("Login Successful");
                            this.Hide();
                            User.AccountUsername = UsernameTxtbox.Text;
                            User.AccountEmail = reader["Email"].ToString();
                            User.AccountRole = reader["Role"].ToString();


                            myConnect.Close();
                            myConnect.Open();
                            string commandss = "SELECT * FROM TwoFactorAuthenticationTable WHERE Name = @Name AND Email2FA = @Email2fa";
                            SqlCommand twofacommand = new SqlCommand(commandss, myConnect);
                            twofacommand.Parameters.AddWithValue("@Name", UsernameTxtbox.Text);
                            twofacommand.Parameters.AddWithValue("@Email2fa", "True");
                            SqlDataReader readerfa = twofacommand.ExecuteReader();
                           

                            if (readerfa.Read())
                            {
                                // IF the user has 2FA email enabled.

                                MessageBox.Show("Works1");
                                Email2FAafterLogin emailfaform = new Email2FAafterLogin();
                                emailfaform.ShowDialog();


                            }

                            else
                            {

                                AdminDashboard form2 = new AdminDashboard();
                                form2.ShowDialog();

                                MessageBox.Show("Not working");
                            }



                        }
                        else
                        {
                            MessageBox.Show("Username and password unknown!");
                        }





                       

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
            this.Hide();

            RFIDLoginForm rfidForm = new RFIDLoginForm();

            rfidForm.ShowDialog();
        }

        private void UsernameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            
        }

        private void SignupLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm signupform = new SignUpForm();
            signupform.Show();

        }

        public void LoginForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
