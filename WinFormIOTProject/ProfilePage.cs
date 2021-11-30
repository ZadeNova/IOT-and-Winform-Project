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
    public partial class ProfilePage : Form
    {

        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        EncryptionClass EncryptionAlgo = new EncryptionClass();
        

        public ProfilePage()
        {

            InitializeComponent();
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            string strCommandText = "SELECT * FROM UserAccounts WHERE Name=@uname";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@uname", User.Username);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    AESOperation Encryption = new AESOperation(); // Encryption
                    string Name, Email, Password, Role,Key;
                    Name = reader["Name"].ToString();
                    Email = reader["Email"].ToString();
                    Password = reader["Password"].ToString();
                    Role = reader["Role"].ToString();
                    Key = reader["SymmetricKey"].ToString();
                    
                    Email = Encryption.DecryptString(Key, Email);  //Decryption
                    UsernameTxt.Text = Name;
                    EmailTxt.Text = Email;
                    PasswordTxt.Text = Password;
                    RoleTxt.Text = Role;
                    
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

            

        }

        private void Home_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminForm = new AdminDashboard();
            this.Hide();
            AdminForm.ShowDialog();
            
        }

        private void UserProfile_Enter(object sender, EventArgs e)
        {

        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
