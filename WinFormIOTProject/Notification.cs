using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Configuration;






namespace WinFormIOTProject
{

    

    public partial class Notification : Form
    {

        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        public Notification()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            //AdminDashboard AdminDash = new AdminDashboard();
            this.Close();
            
            //AdminDash.ShowDialog();
        }

        private void Notification_Load(object sender, EventArgs e)
        {

            
        }

        private void Email_CheckedChanged(object sender, EventArgs e)
        {
            if (Email.Checked)
            {
                MessageBox.Show("Email notification has been sent");
                // Add new table if the state is true. Email notification = true
                // Login Notification
                SqlConnection myConnect = new SqlConnection(strConnectionString);
                myConnect.Open();
                string strCommandText = "UPDATE UserAccounts SET EmailNotification = @uEmailTrue WHERE Email = @uEmail AND Name = @uName ";
                


                SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                cmd.Parameters.AddWithValue("@uEmailTrue", "True");
                cmd.Parameters.AddWithValue("@uEmail", User.AccountEmail);
                cmd.Parameters.AddWithValue("@uName", User.AccountUsername);
                cmd.ExecuteNonQuery();
                myConnect.Close();
                //lol

            }
            else
            {
                MessageBox.Show("False");
                //SqlConnection myConnect = new SqlConnection(strConnectionString);
                //myConnect.Open();
                //string strCommandText = "UPDATE UserAccounts SET Password = @uPassword WHERE Email = @uEmail";


                //SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            }


        }
    }
}
