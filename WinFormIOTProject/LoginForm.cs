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

        private void ForgetPassBtn_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Add logic to check if user exist in database
            // Add validators too 
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            //
            //string strCommandText = "INSERT INTO UserAccounts(Name,Email,Password,SymmetricKey,Role,Status) VALUES (@Name,@Email,@Password,@SymmetricKey,@Role,@Status)";

            //SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            
            //Check if empty
            if (string.IsNullOrWhiteSpace(UsernameTxtbox.Text) || string.IsNullOrWhiteSpace(PasswordTxtBox.Text))
            {
                MessageBox.Show("IsEmpty");
            }
            else
            {
                MessageBox.Show("Not Empty");

                // Check if password exists in database


            }

            string Username = UsernameTxtbox.Text;
            string Password = PasswordTxtBox.Text;
            MessageBox.Show(Username + Password);
        }
    }
}
