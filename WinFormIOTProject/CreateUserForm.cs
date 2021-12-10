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
            AdminDashboard admdash = new AdminDashboard();
            admdash.ShowDialog();

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

                        //var key = KeyGen();
                        //AESOperation encryptt = new AESOperation();


                        //SqlConnection myConnect = new SqlConnection(strConnectionString);
                        //myConnect.Open();
                        //string strCommandText = "INSERT INTO UserAccount(Name,Password,Email,Phone_Number,Role,SymmetricKey) VALUES (@Name,@Password,@Email,@Phone_Number,@Role,@SymmetricKey)";

                        ////encrypt phone no
                        //var encryptedPhoneNo = encryptt.EncryptString(key, PhoneNumtxt.Text);

                        //SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                        //cmd.Parameters.AddWithValue("@Name", UserNametxt.Text);
                        //cmd.Parameters.AddWithValue("@Password", PasswordTxt.Text);
                        //cmd.Parameters.AddWithValue("@Email", EmailTxt.Text);
                        //cmd.Parameters.AddWithValue("@Phone_Number", encryptedPhoneNo);
                        //cmd.Parameters.AddWithValue("@Role", Role);
                        //cmd.Parameters.AddWithValue("@SymmetricKey", key);
                        //cmd.ExecuteNonQuery(); // It executes the sql command

                        //myConnect.Close();

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



    }
}
