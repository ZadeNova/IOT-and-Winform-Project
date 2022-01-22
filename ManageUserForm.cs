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
    public partial class ManageUserForm : Form
    {
        public ManageUserForm()
        {
            InitializeComponent();
        }
        
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ManageUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iOTProjDBDataSet1.UserAccount' table. You can move, or remove it, as needed.
            // this.userAccountTableAdapter.Fill(this.iOTProjDBDataSet1.UserAccount);
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String results2 = "SELECT Id ,Name,Email,Phone_Number,Role,Status,RFID_ID FROM UserAccount";
            SqlCommand updateCmd2 = new SqlCommand(results2, myconnect);
            myconnect.Open();
            SqlDataAdapter sdr2 = new SqlDataAdapter(updateCmd2);
            DataTable dt2 = new DataTable();
            sdr2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            myconnect.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
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

        private void Usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Filterbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Usernametxtbox.Text))
            {
                MessageBox.Show("IsEmpty");
            }
            else
            {
                SqlConnection myconnect = new SqlConnection(strConnectionString);

                string strCommandText = "SELECT * FROM UserAccount WHERE  Name=@uqqName";
                SqlCommand cmd = new SqlCommand(strCommandText, myconnect);
                //cmd.Parameters.AddWithValue("@RFID", textBox2.Text);
                cmd.Parameters.AddWithValue("@uqqName", Usernametxtbox.Text);

                try
                {
                    myconnect.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        myconnect.Close();

                        {
                            //SqlConnection myconnect = new SqlConnection(strConnectionString);
                            String results2 = "SELECT Id ,Name,Email,Phone_Number,Role,Status,RFID_ID FROM UserAccount WHERE Name=@Name";
                            SqlCommand updateCmd2 = new SqlCommand(results2, myconnect);
                            updateCmd2.Parameters.AddWithValue("@Name", Usernametxtbox.Text);
                            myconnect.Open();
                            SqlDataAdapter sdr2 = new SqlDataAdapter(updateCmd2);
                            DataTable dt2 = new DataTable();
                            sdr2.Fill(dt2);
                            dataGridView1.DataSource = dt2;
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
                finally
                {
                    myconnect.Close();
                }
            }
        }
            //Type the filter code here lmao
            //if ((Usernametxtbox.Text.StartsWith("660")) | (Usernametxtbox.Text.StartsWith("6A0")))
            //{

                //    SqlConnection myconnect = new SqlConnection(strConnectionString);
                //    String results = "SELECT Id ,Name,Email,Phone_Number,Role,Status,RFID_ID FROM UserAccount WHERE RFID_ID LIKE @RFID %";
                //    SqlCommand updateCmd = new SqlCommand(results, myconnect);
                //    updateCmd.Parameters.AddWithValue("@RFID", Usernametxtbox.Text);
                //    myconnect.Open();
                //    SqlDataAdapter sdr = new SqlDataAdapter(updateCmd);
                //    DataTable dt = new DataTable();
                //    sdr.Fill(dt);
                //    dataGridView1.DataSource = dt;
                //    myconnect.Close();
                //}
                //else {
                //    SqlConnection myconnect = new SqlConnection(strConnectionString);
                //    String results = "SELECT Id ,Name,Email,Phone_Number,Role,Status,RFID_ID FROM UserAccount";
                //    SqlCommand updateCmd = new SqlCommand(results, myconnect);
                //    updateCmd.Parameters.AddWithValue("@RFID", Usernametxtbox.Text);
                //    myconnect.Open();
                //    SqlDataAdapter sdr = new SqlDataAdapter(updateCmd);
                //    DataTable dt = new DataTable();
                //    sdr.Fill(dt);
                //    dataGridView1.DataSource = dt;
                //    myconnect.Close();
                //}


        private void button1_Click(object sender, EventArgs e)
        {
            Usernametxtbox.Text = String.Empty;
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String results2 = "SELECT Id ,Name,Email,Phone_Number,Role,Status,RFID_ID FROM UserAccount";
            SqlCommand updateCmd2 = new SqlCommand(results2, myconnect);
            myconnect.Open();
            SqlDataAdapter sdr2 = new SqlDataAdapter(updateCmd2);
            DataTable dt2 = new DataTable();
            sdr2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            myconnect.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                Usernametxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone_Number"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Role"].FormattedValue.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["RFID_ID"].FormattedValue.ToString();
            }
        }
    }
}
