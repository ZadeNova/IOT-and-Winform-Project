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
    public partial class SignUpForm : Form
    {


        // SQL variable
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        EncryptionClass EncryptionAlgo = new EncryptionClass();


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
                
                MessageBox.Show("Fill in the empty textboxes!");
                
            }
            else //Else code is not empty
            {
                if (NewPasswordTxt.Text.Equals(CfmPassTxtBox.Text))
                {
                    MessageBox.Show("Password is the same!");




                    var key = KeyGen();
                    // key uses 32 bits
                    
                    
                    
                    

                    AESOperation encryptt = new AESOperation();
                    var encryptedPhoneNo = encryptt.EncryptString(key, PhoneNumTxt.Text);
                    
                    

                    string Role = "User";
                    string Status = "Active";

                    SqlConnection myConnect = new SqlConnection(strConnectionString);
                    myConnect.Open();
                    string strCommandText = "INSERT INTO UserAccount(Name,Password,Email,Phone_Number,Role,Status,SymmetricKey) VALUES (@Name,@Password,@Email,@Phone_Number,@Role,@Status,@SymmetricKey)";

                    SqlCommand cmd = new SqlCommand(strCommandText, myConnect);










                    //Hash the password

                    Console.WriteLine(NewUsertxt.Text.Length);
                    Console.WriteLine(NewEmailTxt.Text.Length);
                    Console.WriteLine(NewPasswordTxt.Text.Length);
                    Console.WriteLine(encryptedPhoneNo.Length);
                    Console.WriteLine(key.Length);

                    cmd.Parameters.AddWithValue("@Name", NewUsertxt.Text);
                    cmd.Parameters.AddWithValue("@Email", NewEmailTxt.Text);
                    cmd.Parameters.AddWithValue("@Password", NewPasswordTxt.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", encryptedPhoneNo);
                    cmd.Parameters.AddWithValue("@SymmetricKey",key);
                    cmd.Parameters.AddWithValue("@Role", Role);
                    cmd.Parameters.AddWithValue("@Status", Status);


                    cmd.ExecuteNonQuery(); // It executes the sql command

                    myConnect.Close();


                    ////string Username = NewUsertxt.Text;
                    ////string Email = NewEmailTxt.Text;
                    ////string Password = NewPasswordTxt.Text;
                    //MessageBox.Show("lolol");
                    ////// Validate if information is correct

                    //if user or admin

                    User.AccountUsername = NewUsertxt.Text; // User session
                    AdminDashboard AdminForm = new AdminDashboard();
                    this.Hide();
                    AdminForm.ShowDialog();
                    //string aa = EncryptionAlgo.Encrypt(NewUsertxt.Text);

                    //string bb = EncryptionAlgo.Decrypt(aa);








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
            //if (string.IsNullOrWhiteSpace(NewUsertxt.Text))
            //{
            //    e.Cancel = true;
            //    NewUsertxt.Focus();
            //    UserError.SetError(NewUsertxt, "Please enter your username!");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    UserError.SetError(NewUsertxt, null);
            //}

        }


        public string KeyGen()
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

        private void Loginformlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm logform = new LoginForm();
            logform.ShowDialog();
            User.AccountEmail = "";
            User.AccountEmail = "";
            User.AccountUsername = "";

        }
    }
}
