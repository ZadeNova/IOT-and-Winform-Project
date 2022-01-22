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
using System.Security.Cryptography;



namespace WinFormIOTProject
{
    public partial class CreateUserForm : Form
    {

        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        EncryptionClass EncryptionAlgo = new EncryptionClass();


        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            
           
            this.Hide();
            

        }

        private void AddUserbtn_Click(object sender, EventArgs e)
        {

            try
            {


                if (string.IsNullOrWhiteSpace(UserNametxt.Text) || string.IsNullOrWhiteSpace(EmailTxt.Text) || string.IsNullOrWhiteSpace(PhoneNumtxt.Text)
                    || string.IsNullOrWhiteSpace(PasswordTxt.Text) || string.IsNullOrWhiteSpace(CfmPassTxt.Text))
                {


                    MessageBox.Show("Fill in the textboxes!");



                }
                else
                {
                    if (!AdminBtn.Checked && !UserBtn.Checked)
                    {
                        MessageBox.Show("Radio buttons cannot be empty");
                    }

                    else
                    {

                        string Role = "";


                        if (AdminBtn.Checked)
                        {
                            //Admin Check
                            Role = "Admin";
                        }
                        else
                        {
                            Role = "User";




                        }

                        SqlConnection myConnect = new SqlConnection(strConnectionString);
                        myConnect.Open();

                        string strcommandtext2 = "SELECT * FROM UserAccount WHERE Name = @Name";
                        SqlCommand cmd2 = new SqlCommand(strcommandtext2, myConnect);
                        cmd2.Parameters.AddWithValue("@Name", UserNametxt.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        if (reader.Read())
                        {
                            myConnect.Close();
                            // account exists
                            MessageBox.Show("Username has been taken");


                        }
                        else
                        {
                            myConnect.Close();
                            myConnect.Open();
                            string strcommandtext3 = "SELECT * FROM UserAccount WHERE Email = @Email";
                            SqlCommand cmd3 = new SqlCommand(strcommandtext3, myConnect);
                            cmd3.Parameters.AddWithValue("@Email",EmailTxt.Text);
                            SqlDataReader reader2 = cmd3.ExecuteReader();
                            if (reader2.Read())
                            {
                                myConnect.Close();
                                MessageBox.Show("Email has already been taken!");

                            }
                            else
                            {
                                myConnect.Close();
                                myConnect.Open();


                                var key = KeyGen();
                                AESOperation encryptt = new AESOperation();



                                string strCommandText = "INSERT INTO UserAccount(Name,Password,Email,Phone_Number,Role,SymmetricKey) VALUES (@Name,@Password,@Email,@Phone_Number,@Role,@SymmetricKey)";

                                //encrypt phone no
                                var encryptedPhoneNo = encryptt.EncryptString(key, PhoneNumtxt.Text);

                                string hashedpass = Hash.ComputeHash(PasswordTxt.Text, "SHA512", null);


                                SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                                cmd.Parameters.AddWithValue("@Name", UserNametxt.Text);
                                cmd.Parameters.AddWithValue("@Password", hashedpass);
                                cmd.Parameters.AddWithValue("@Email", EmailTxt.Text);
                                cmd.Parameters.AddWithValue("@Phone_Number", encryptedPhoneNo);
                                cmd.Parameters.AddWithValue("@Role", Role);
                                cmd.Parameters.AddWithValue("@SymmetricKey", key);
                                cmd.ExecuteNonQuery(); // It executes the sql command

                                myConnect.Close();
                                myConnect.Open();
                                string anothercommand = "INSERT INTO TwoFactorAuthenticationTable (Name,Email) VALUES (@Name , @Email)";
                                SqlCommand anothercommand2 = new SqlCommand(anothercommand, myConnect);
                                anothercommand2.Parameters.AddWithValue("@Name", UserNametxt.Text);
                                anothercommand2.Parameters.AddWithValue("@Email", EmailTxt.Text);
                                anothercommand2.ExecuteNonQuery();


                                myConnect.Close();

                                MessageBox.Show($"{Role} {UserNametxt.Text} has been created!");

                                UserNametxt.Text = "";
                                PasswordTxt.Text = "";
                                EmailTxt.Text = "";
                                CfmPassTxt.Text = "";
                                PhoneNumtxt.Text = "";
                                AdminBtn.Checked = false;
                                UserBtn.Checked = false;





                            }




                        }

                        


                  

                    }
                   


                }



                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }





        private string KeyGen()
        {
            Random rnd = new Random();
            string Charpool = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            string key = "";
            for (int i = 0; i < 32; i++)
            {

                key = key + Charpool[rnd.Next(0, 46)];



            }
            return key;

        }

        private void Homee_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminForm = new AdminDashboard();
            this.Hide();
            AdminForm.ShowDialog();

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

    }
}
