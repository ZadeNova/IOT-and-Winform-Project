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
    public partial class UpdatePassword : Form
    {

        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;

        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminform = new AdminDashboard();
            adminform.ShowDialog();

        }

        private void UpdatePassbtn_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection myConnect = new SqlConnection(strConnectionString);
                myConnect.Open();

                string commandtext = "SELECT Password FROM UserAccount WHERE Name = @Name";
                SqlCommand cmd2 = new SqlCommand(commandtext, myConnect);
                cmd2.Parameters.AddWithValue("@Name", User.AccountUsername);
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.Read())
                {
                    string currentpass = reader["Password"].ToString();
                    bool passwordcheck = Hash.VerifyHash(CurrentPasstxt.Text, "SHA512", currentpass);


                    if (passwordcheck)
                    {
                        MessageBox.Show("Password is correct!");
                        if (NewPasstxt.Text.Equals(CfmNewPasstxt.Text))
                        {

                            string hashedpass;
                            myConnect.Close();
                            myConnect.Open();
                            string strCommandText = "UPDATE UserAccount SET Password = @Password  WHERE Name = @Name ";




                            hashedpass = Hash.ComputeHash(NewPasstxt.Text, "SHA512", null);

                            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                            cmd.Parameters.AddWithValue("@Password", hashedpass);
                            cmd.Parameters.AddWithValue("@Name", User.AccountUsername);
                            cmd.ExecuteNonQuery();
                            myConnect.Close();
                            MessageBox.Show("Password successfully updated!");

                            CurrentPasstxt.Text = "";
                            NewPasstxt.Text = "";
                            CfmNewPasstxt.Text = "";



                        }
                        else
                        {
                            MessageBox.Show("Error?");
                        }






                    }





                }
                else
                {
                    MessageBox.Show("not found!");
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            




        }

        private void CurrentPasstxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }



