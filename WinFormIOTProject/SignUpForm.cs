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
    public partial class SignUpForm : Form
    {


        // SQL variable
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;



        public SignUpForm()
        {
            // Form SQL connection at the start of the form
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            // Validators
            // Check if all empty (not for whitespace)
            if (string.IsNullOrWhiteSpace(NewUsertxt.Text) || string.IsNullOrWhiteSpace(NewEmailTxt.Text) || string.IsNullOrWhiteSpace(NewPasswordTxt.Text) || string.IsNullOrWhiteSpace(CfmPassTxtBox.Text))
            {
                // Extra validators
                MessageBox.Show("Fill in the empty textboxes!");
                
            }
            else //Else code is not empty
            {
                if (NewPasswordTxt.Text.Equals(CfmPassTxtBox.Text))
                {
                    MessageBox.Show("Password is the same!");

                    //string SymmKey = "Key";
                    //string Role = "User";
                    //string Status = "Active";

                    //SqlConnection myConnect = new SqlConnection(strConnectionString);
                    //myConnect.Open();
                    //string strCommandText = "INSERT INTO UserAccounts(Name,Email,Password,SymmetricKey,Role,Status) VALUES (@Name,@Email,@Password,@SymmetricKey,@Role,@Status)";

                    //SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                    //cmd.Parameters.AddWithValue("@Name", NewUsertxt.Text);
                    //cmd.Parameters.AddWithValue("@Email", NewEmailTxt.Text);
                    //cmd.Parameters.AddWithValue("@Password", NewPasswordTxt.Text);
                    //cmd.Parameters.AddWithValue("@SymmetricKey", SymmKey);
                    //cmd.Parameters.AddWithValue("@Role", Role);
                    //cmd.Parameters.AddWithValue("@Status", Status);

                    //cmd.ExecuteNonQuery(); // It executes the sql command

                    //myConnect.Close();
                    ////string Username = NewUsertxt.Text;
                    ////string Email = NewEmailTxt.Text;
                    ////string Password = NewPasswordTxt.Text;
                    //MessageBox.Show("lolol");
                    ////// Validate if information is correct

                }
                else
                {
                    MessageBox.Show("Password not equal");
                }

                
            }

            
            
        }

        private void NewUsertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUserlabel_Click(object sender, EventArgs e)
        {

        }

        private void NewPasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewEmailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void CfmPassTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUsertxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewUsertxt.Text))
            {
                e.Cancel = true;
                NewUsertxt.Focus();
                UserError.SetError(NewUsertxt, "Please enter your username!");
            }
            else
            {
                e.Cancel = true;
                UserError.SetError(NewUsertxt, null);
            }
        }
    }
}
