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


using System.Configuration;
using System.Data.SqlClient;

namespace WinFormIOTProject
{
    public partial class Ras_Pie_Setting : Form
    {

        //Email stuff
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;



        public Ras_Pie_Setting()
        {
            InitializeComponent();
        }

       

      
     
      

        private void Home_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserSettingsbtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            AdminDashboard.ActiveForm.Close();
            UserSettingsForm usersettingform = new UserSettingsForm();
            usersettingform.Show();
            
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            AdminDashboard.ActiveForm.Close();
            ProfilePage ProfileForm = new ProfilePage();
            
            ProfileForm.Show();
            
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
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection1"].ConnectionString;
        private void Settings_Load(object sender, EventArgs e)
        {
           

            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String results = "SELECT * FROM RasPiSetting";
            SqlCommand updateCmd = new SqlCommand(results, myconnect);
            myconnect.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(updateCmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            myconnect.Close();

        }

        private void Useless_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Application.OpenForms);
            foreach (Form x in Application.OpenForms)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(AdminDashboard.ActiveForm);
            AdminDashboard.ActiveForm.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RaspBoxGrp_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) {
                dataGridView1.CurrentRow.Selected = true;
            
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Sleeptime"].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["lightAdcValue"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["iPrevAdcValue"].FormattedValue.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells["tempdefaultvale"].FormattedValue.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells["ultradistance"].FormattedValue.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["moistureAdcValue"].FormattedValue.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox7.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBox2.Text))
            //{
              
              
            //    MessageBox.Show("Please click on any column from the above database ! ");
            //}
            //else if (string.IsNullOrWhiteSpace(textBox3.Text))
            //{
               
               
            //    MessageBox.Show("Please enter a value on avgsoundvalue ! ");
            //}
            //else if (string.IsNullOrWhiteSpace(textBox5.Text))
            //{
               
            //    MessageBox.Show("Please enter a value on soundstatus ! ");
            //}
            //else if (string.IsNullOrWhiteSpace(textBox4.Text))
            //{
               
            //    MessageBox.Show("Please enter a value on soundstatus1 ! ");
            //}
            //else if (string.IsNullOrWhiteSpace(textBox9.Text))
            //{
                
            //    MessageBox.Show("Please enter a value on watervalue ! ");
            //}
            //else if (string.IsNullOrWhiteSpace(textBox8.Text))
            //{
              
            //    MessageBox.Show("Please enter a value on waterstatus ! ");
            //}
            //else if (string.IsNullOrWhiteSpace(textBox7.Text))
            //{
               
            //    MessageBox.Show("Please enter a value on waterstatus1 ! ");
            //}


         
            //else {
            //    try
            //    {
            //        MessageBox.Show("Updating");
            //        string update = "UPDATE WinformPieSetting SET  ultrastatus1=@us1,ultrastatus=@us,ultravalue=@uv,temstatus1=@ts1,temstatus=@ts,temvalue=@tv,ligtstatus1=@ls1,ligtstatus=@ls,lightvalue=@lv,waterstatus1=@ws1,watervalue=@wv,waterstatus=@ws, avgsoundvalue=@avgsound ,soundstatus=@ss , soundstatus1=@ss1 WHERE userid=@Id ";
            //        SqlConnection myconnect = new SqlConnection(strConnectionString);
            //        myconnect.Open();
            //        SqlCommand cmd12 = new SqlCommand(update, myconnect);
            //        cmd12.Parameters.AddWithValue("@Id", textBox2.Text);
            //        cmd12.Parameters.AddWithValue("@avgsound", textBox3.Text);
            //        cmd12.Parameters.AddWithValue("@ss", textBox5.Text);
            //        cmd12.Parameters.AddWithValue("@ss1", textBox4.Text);
            //        cmd12.Parameters.AddWithValue("@wv", textBox9.Text);
            //        cmd12.Parameters.AddWithValue("@ws", textBox8.Text);
            //        cmd12.Parameters.AddWithValue("@ws1", textBox7.Text);
                  


            //        cmd12.ExecuteNonQuery(); // It executes the sql command

            //        myconnect.Close();
            //        MessageBox.Show("Updated ! ");
            //        MessageBox.Show("Updated ! ");
            //        SqlConnection myconnect1 = new SqlConnection(strConnectionString);
            //        String results = "SELECT * FROM WinformPieSetting";
            //        SqlCommand updateCmd = new SqlCommand(results, myconnect1);
            //        myconnect1.Open();
            //        SqlDataAdapter sdr = new SqlDataAdapter(updateCmd);
            //        DataTable dt = new DataTable();
            //        sdr.Fill(dt);
            //        dataGridView1.DataSource = dt;
            //        myconnect1.Close();
            //    }
            //    catch (SqlException ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message.ToString());
            //    }
            //}
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Please enter a value on avgsoundvalue ! ");
            }
            else {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Please enter a value on avgsoundvalue ! ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider1.SetError(textBox5, "Please enter a value on soundstatus ! ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox5, "");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider1.SetError(textBox4, "Please enter a value on soundstatus1 ! ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox4, "");
            }
        }

        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                e.Cancel = true;
                textBox9.Focus();
                errorProvider1.SetError(textBox9, "Please enter a value on watervalue ! ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox9, "");
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                e.Cancel = true;
                textBox8.Focus();
                errorProvider1.SetError(textBox8, "Please enter a value on waterstatus ! ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox8, "");
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                e.Cancel = true;
                textBox7.Focus();
                errorProvider1.SetError(textBox7, "Please enter a value on waterstatus1 ! ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox7, "");
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void textBox12_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void textBox14_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void textBox15_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void textBox13_Validating(object sender, CancelEventArgs e)
        {
        
        }

        private void textBox11_Validating(object sender, CancelEventArgs e)
        {
        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textBox17_Validating(object sender, CancelEventArgs e)
        {
           

        }

        private void textBox16_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
