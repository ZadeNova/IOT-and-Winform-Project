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
        string Key;

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
                    string Name, Email, Password, Role, Phone_Number;
                    Name = reader["Name"].ToString();
                    Email = reader["Email"].ToString();
                   
                    Role = reader["Role"].ToString();
                    Key = reader["SymmetricKey"].ToString();
                    Phone_Number = reader["Phone_Number"].ToString();

                    
                    
                    User.AccountID = Convert.ToInt32(reader["ID"]);
                    Phone_Number = Encryption.DecryptString(Key, Phone_Number);  //Decryption
                    UsernameTxt.Text = Name;
                    EmailTxt.Text = Email;
                   
                    RoleTxt.Text = Role;
                    PhnNumberTxt.Text = Phone_Number;
                    Updateusernametxt.Text = Name;
                    UpdateEmailTxt.Text = Email;
                    
                    UpdatePhoneTxt.Text = Phone_Number;
                    UpdateRoletxt.Text = Role;

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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            try
            {

              


                AESOperation Encryption = new AESOperation();
                SqlConnection myConnect = new SqlConnection(strConnectionString);
              

                myConnect.Open();
                string strCommandText = "UPDATE UserAccount SET Name = @Name ,Email = @Email ,Phone_Number = @Phone_No  WHERE ID = @ID ";
                SqlCommand cmd = new SqlCommand(strCommandText, myConnect);

                string encryptphoneno = Encryption.EncryptString(Key, UpdatePhoneTxt.Text);

                cmd.Parameters.AddWithValue("@Name", Updateusernametxt.Text);
                cmd.Parameters.AddWithValue("@Email", UpdateEmailTxt.Text);
                
                cmd.Parameters.AddWithValue("@Phone_No", encryptphoneno);
                cmd.Parameters.AddWithValue("@ID", User.AccountID);

                cmd.ExecuteNonQuery();
                myConnect.Close();
                MessageBox.Show("Your user profile has been updated!");
                updateprofiletxtbox(Updateusernametxt.Text, UpdateEmailTxt.Text, UpdatePhoneTxt.Text);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void updateprofiletxtbox(string user , string email , string phone_no)
        {

            UsernameTxt.Text = user;
            EmailTxt.Text = email;
            
            PhnNumberTxt.Text = phone_no;
            Updateusernametxt.Text = user;
            UpdateEmailTxt.Text = email;
            
            UpdatePhoneTxt.Text = phone_no;



        
        }

        private void Updatepassbtn_Click(object sender, EventArgs e)
        {

            UpdatePassword updatepassform = new UpdatePassword();
            this.Hide();
            updatepassform.ShowDialog();

        }
    }
}
