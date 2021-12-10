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
            string strCommandText = "SELECT * FROM UserAccount WHERE Name=@uname";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@uname", User.AccountUsername);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    AESOperation Encryption = new AESOperation(); // Encryption
                    string Name, Email, Password, Role,Key , Phone_Number;
                    Name = reader["Name"].ToString();
                    Email = reader["Email"].ToString();
                    Password = reader["Password"].ToString();
                    Role = reader["Role"].ToString();
                    Key = reader["SymmetricKey"].ToString();
                    Phone_Number = reader["Phone_Number"].ToString();
                    
                    Phone_Number = Encryption.DecryptString(Key, Phone_Number);  //Decryption
                    UsernameTxt.Text = Name;
                    EmailTxt.Text = Email;
                    PasswordTxt.Text = Password;
                    RoleTxt.Text = Role;
                    PhnNumberTxt.Text = Phone_Number;
                    

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

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {

        }
    }
}
