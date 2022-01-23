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
    public partial class ViewAllData : Form
    {


        string FromDatetime, ToDateTime, FilterByTime;
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;

        public ViewAllData()
        {
            InitializeComponent();
        }

        private void ViewAllData_Load(object sender, EventArgs e)
        {
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String results = "SELECT UserAccount.Id, UserAccount.Name, Manage_RFID.RFID_ID , Manage_RFID.RFID_STATUS FROM UserAccount INNER JOIN Manage_RFID ON UserAccount.RFID_ID = Manage_RFID.RFID_ID";
            SqlCommand updateCmd = new SqlCommand(results, myconnect);
            myconnect.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(updateCmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridViewA.DataSource = dt;
            myconnect.Close();


            SqlConnection myconnect1 = new SqlConnection(strConnectionString);
            String results1 = "SELECT * from Light_table";
            SqlCommand updateCmd1 = new SqlCommand(results1, myconnect1);
            myconnect1.Open();
            SqlDataAdapter sdr1 = new SqlDataAdapter(updateCmd1);
            DataTable dt1 = new DataTable();
            sdr1.Fill(dt1);
            dataGridViewL.DataSource = dt1;
            myconnect1.Close();


            SqlConnection myconnect12 = new SqlConnection(strConnectionString);
            String results12 = "SELECT * from Tem_table";
            SqlCommand updateCmd12 = new SqlCommand(results12, myconnect12);
            myconnect12.Open();
            SqlDataAdapter sdr12 = new SqlDataAdapter(updateCmd12);
            DataTable dt12 = new DataTable();
            sdr12.Fill(dt12);
            dataGridViewT.DataSource = dt12;
            myconnect1.Close();

            SqlConnection myconnect123 = new SqlConnection(strConnectionString);
            String results123 = "SELECT * from PRI_table";
            SqlCommand updateCmd123 = new SqlCommand(results123, myconnect123);
            myconnect123.Open();
            SqlDataAdapter sdr123 = new SqlDataAdapter(updateCmd123);
            DataTable dt123 = new DataTable();
            sdr123.Fill(dt123);
            dataGridViewPRI.DataSource = dt123;
            myconnect1.Close();

            SqlConnection myconnect10 = new SqlConnection(strConnectionString);
            String results10 = "SELECT * from Sound_table";
            SqlCommand updateCmd10 = new SqlCommand(results10, myconnect10);
            myconnect10.Open();
            SqlDataAdapter sdr10 = new SqlDataAdapter(updateCmd10);
            DataTable dt10 = new DataTable();
            sdr10.Fill(dt10);
            dataGridViewS.DataSource = dt10;
            myconnect10.Close();


            SqlConnection myconnect9 = new SqlConnection(strConnectionString);
            String results9 = "SELECT * from Ultra_table";
            SqlCommand updateCmd9 = new SqlCommand(results9, myconnect9);
            myconnect9.Open();
            SqlDataAdapter sdr9 = new SqlDataAdapter(updateCmd9);
            DataTable dt9 = new DataTable();
            sdr9.Fill(dt9);
            dataGridViewU.DataSource = dt9;
            myconnect9.Close();

            SqlConnection myconnect8 = new SqlConnection(strConnectionString);
            String results8 = "SELECT * from Water_table";
            SqlCommand updateCmd8 = new SqlCommand(results8, myconnect8);
            myconnect8.Open();
            SqlDataAdapter sdr8 = new SqlDataAdapter(updateCmd8);
            DataTable dt8 = new DataTable();
            sdr8.Fill(dt8);
            dataGridViewW.DataSource = dt8;
            myconnect8.Close();
        }

        private void ChangeChartProperties()
        {


        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserSettingsbtn_Click(object sender, EventArgs e)
        {
            AdminDashboard.ActiveForm.Close();
            UserSettingsForm usersettingform = new UserSettingsForm();
            usersettingform.Show();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
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

        private void Usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Filterbtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Filter_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridViewA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewA.CurrentRow.Selected = true;

                textBox1.Text = dataGridViewA.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridViewL.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewL.CurrentRow.Selected = true;

                textBox1.Text = dataGridViewL.Rows[e.RowIndex].Cells["userid"].FormattedValue.ToString();

            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridViewT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewT.CurrentRow.Selected = true;

                textBox1.Text = dataGridViewT.Rows[e.RowIndex].Cells["userid1"].FormattedValue.ToString();

            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridViewPRI.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewPRI.CurrentRow.Selected = true;

                textBox1.Text = dataGridViewPRI.Rows[e.RowIndex].Cells["userid"].FormattedValue.ToString();

            }
        }

        private void dataGridView10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridViewS.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewS.CurrentRow.Selected = true;

                textBox1.Text = dataGridViewS.Rows[e.RowIndex].Cells["userid"].FormattedValue.ToString();

            }
        }

        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridViewU.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewU.CurrentRow.Selected = true;

                textBox1.Text = dataGridViewU.Rows[e.RowIndex].Cells["userid"].FormattedValue.ToString();

            }
        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridViewW.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewW.CurrentRow.Selected = true;

                textBox1.Text = dataGridViewW.Rows[e.RowIndex].Cells["userid"].FormattedValue.ToString();

            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please enter a ID ! ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void Filterby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadSoundData()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(strConnectionString))
            {
               
              
                String results1 = "SELECT * from Light_table where DATETIME BETWEEN @StartDate AND @EndDate";
                SqlCommand updateCmd1 = new SqlCommand(results1, con);
                updateCmd1.Parameters.AddWithValue("@StartDate", FromDatetime);
                updateCmd1.Parameters.AddWithValue("@EndDate", ToDateTime);
                con.Open();
                SqlDataAdapter sdr1 = new SqlDataAdapter(updateCmd1);
                DataTable dt1 = new DataTable();
                sdr1.Fill(dt1);
                dataGridViewL.DataSource = dt1;
                con.Close();


                String results12 = "SELECT * from Tem_table WHERE DATETIME BETWEEN @StartDate AND @EndDate";
                SqlCommand updateCmd12 = new SqlCommand(results12, con);
                updateCmd12.Parameters.AddWithValue("@StartDate", FromDatetime);
                updateCmd12.Parameters.AddWithValue("@EndDate", ToDateTime);
                con.Open();
                SqlDataAdapter sdr12 = new SqlDataAdapter(updateCmd12);
                DataTable dt12 = new DataTable();
                sdr12.Fill(dt12);
                dataGridViewT.DataSource = dt12;
                con.Close();

              
                String results123 = "SELECT * from PRI_table WHERE DATETIME BETWEEN @StartDate AND @EndDate";
                SqlCommand updateCmd123 = new SqlCommand(results123, con);
                updateCmd123.Parameters.AddWithValue("@StartDate", FromDatetime);
                updateCmd123.Parameters.AddWithValue("@EndDate", ToDateTime);
                con.Open();
                SqlDataAdapter sdr123 = new SqlDataAdapter(updateCmd123);
                DataTable dt123 = new DataTable();
                sdr123.Fill(dt123);
                dataGridViewPRI.DataSource = dt123;
                con.Close();

               
                String results10 = "SELECT * from Sound_table WHERE DATETIME BETWEEN @StartDate AND @EndDate";
                SqlCommand updateCmd10 = new SqlCommand(results10, con);
                updateCmd10.Parameters.AddWithValue("@StartDate", FromDatetime);
                updateCmd10.Parameters.AddWithValue("@EndDate", ToDateTime);
                con.Open();
                SqlDataAdapter sdr10 = new SqlDataAdapter(updateCmd10);
                DataTable dt10 = new DataTable();
                sdr10.Fill(dt10);
                dataGridViewS.DataSource = dt10;
                con.Close();


               
                String results9 = "SELECT * from Ultra_table WHERE DATETIME BETWEEN @StartDate AND @EndDate";
                SqlCommand updateCmd9 = new SqlCommand(results9, con);
                updateCmd9.Parameters.AddWithValue("@StartDate", FromDatetime);
                updateCmd9.Parameters.AddWithValue("@EndDate", ToDateTime);
                con.Open();
                SqlDataAdapter sdr9 = new SqlDataAdapter(updateCmd9);
                DataTable dt9 = new DataTable();
                sdr9.Fill(dt9);
                dataGridViewU.DataSource = dt9;
                con.Close();

              
                String results8 = "SELECT * from Water_table WHERE DATETIME BETWEEN @StartDate AND @EndDate";
                SqlCommand updateCmd8 = new SqlCommand(results8, con);
                updateCmd8.Parameters.AddWithValue("@StartDate", FromDatetime);
                updateCmd8.Parameters.AddWithValue("@EndDate", ToDateTime);
                con.Open();
                SqlDataAdapter sdr8 = new SqlDataAdapter(updateCmd8);
                DataTable dt8 = new DataTable();
                sdr8.Fill(dt8);
                dataGridViewW.DataSource = dt8;
                con.Close();
            }
        }

        private void FilterBtn_Click_1(object sender, EventArgs e)
        {
           
            FromDatetime = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            ToDateTime = ToDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
          
            loadSoundData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterByTime = comboBox1.Text;

            if (FilterByTime.Equals("Active_RFID"))
            {
                labelAF.Visible = true;
                labelL.Visible = false;
                labelPRI.Visible = false;

                Temperatue.Visible = false;
                labelS.Visible = false;
                labelU.Visible = false;
                labelW.Visible = false;

                dataGridViewA.Visible = true;
                dataGridViewPRI.Visible = false;
                dataGridViewT.Visible = false;
                dataGridViewL.Visible = false;
                dataGridViewS.Visible = false;
                dataGridViewU.Visible = false;
                dataGridViewW.Visible = false;
            }
            else if (FilterByTime.Equals("Sound_Data"))
            {
                labelS.Location = new Point(5, 393);
                dataGridViewS.Location = new Point(4, 432);

                labelS.Visible = true;
                dataGridViewS.Visible = true;

                labelL.Visible = false;
                labelPRI.Visible = false;

                Temperatue.Visible = false;
                labelAF.Visible = false;
                labelU.Visible = false;
                labelW.Visible = false;

                dataGridViewPRI.Visible = false;
                dataGridViewT.Visible = false;
                dataGridViewL.Visible = false;
                dataGridViewA.Visible = false;
                dataGridViewU.Visible = false;
                dataGridViewW.Visible = false;
            }
            else if (FilterByTime.Equals("Water_Data"))
            {
                labelW.Visible = true;
                dataGridViewW.Visible = true;

                labelW.Location = new Point(5, 393);
                dataGridViewW.Location = new Point(4, 432);
                labelL.Visible = false;
                labelPRI.Visible = false;

                Temperatue.Visible = false;
                labelAF.Visible = false;
                labelS.Visible = false;
                labelL.Visible = false;


                dataGridViewPRI.Visible = false;
                dataGridViewT.Visible = false;
                dataGridViewL.Visible = false;
                dataGridViewA.Visible = false;
                dataGridViewU.Visible = false;
                dataGridViewS.Visible = false;
            }
            else if (FilterByTime.Equals("UltraSonic_Data"))
            {
                labelU.Visible = true;
                dataGridViewU.Visible = true;

                labelU.Location = new Point(5, 393);
                dataGridViewU.Location = new Point(4, 432);
                labelL.Visible = false;
                labelPRI.Visible = false;
                labelW.Visible = false;
                Temperatue.Visible = false;
                labelAF.Visible = false;
                labelW.Visible = false;


                dataGridViewPRI.Visible = false;
                dataGridViewT.Visible = false;
                dataGridViewL.Visible = false;
                dataGridViewA.Visible = false;
                dataGridViewW.Visible = false;
                dataGridViewS.Visible = false;
            }
            else if (FilterByTime.Equals("Pri_Motion_Data"))
            {
                labelPRI.Visible = true;
                dataGridViewPRI.Visible = true;

                labelPRI.Location = new Point(5, 393);
                dataGridViewPRI.Location = new Point(4, 432);

                labelL.Visible = false;
                labelU.Visible = false;
                labelW.Visible = false;
                Temperatue.Visible = false;
                labelAF.Visible = false;
                labelW.Visible = false;


                dataGridViewU.Visible = false;
                dataGridViewT.Visible = false;
                dataGridViewL.Visible = false;
                dataGridViewA.Visible = false;
                dataGridViewW.Visible = false;
                dataGridViewS.Visible = false;
            }
            else if (FilterByTime.Equals("Ligth_Data"))
            {
                labelL.Visible = true;
                dataGridViewL.Visible = true;

                labelL.Location = new Point(5, 393);
                dataGridViewL.Location = new Point(4, 432);

                labelPRI.Visible = false;
                labelU.Visible = false;
                labelW.Visible = false;
                Temperatue.Visible = false;
                labelAF.Visible = false;
                labelW.Visible = false;


                dataGridViewU.Visible = false;
                dataGridViewT.Visible = false;
                dataGridViewPRI.Visible = false;
                dataGridViewA.Visible = false;
                dataGridViewW.Visible = false;
                dataGridViewS.Visible = false;
            }
            else if (FilterByTime.Equals("Temperature_Data"))
            {
                Temperatue.Visible = true;
                dataGridViewT.Visible = true;

                Temperatue.Location = new Point(5, 393);
                dataGridViewT.Location = new Point(4, 432);

                labelPRI.Visible = false;
                labelU.Visible = false;
                labelW.Visible = false;
                labelL.Visible = false;
                labelAF.Visible = false;
                labelW.Visible = false;


                dataGridViewU.Visible = false;
                dataGridViewL.Visible = false;
                dataGridViewPRI.Visible = false;
                dataGridViewA.Visible = false;
                dataGridViewW.Visible = false;
                dataGridViewS.Visible = false;
            }
            else if (FilterByTime.Equals("ALL_Data"))
            {
                labelS.Location = new Point(5, 1091);
                dataGridViewS.Location = new Point(4, 1128);

                labelW.Location = new Point(6, 1452);
                dataGridViewW.Location = new Point(4, 1489);


                labelU.Location = new Point(510, 1091);
                dataGridViewU.Location = new Point(514, 1128);

                labelPRI.Location = new Point(501, 746);
                dataGridViewPRI.Location = new Point(514, 783);

                labelL.Location = new Point(501, 393);
                dataGridViewL.Location = new Point(514, 432);

                Temperatue.Location = new Point(3, 746);
                dataGridViewT.Location = new Point(4, 783);

                labelAF.Visible = true;
                labelL.Visible = true;
                labelPRI.Visible = true;
                labelL.Visible = true;
                Temperatue.Visible = true;
                labelS.Visible = true;
                labelU.Visible = true;
                labelW.Visible = true;

                dataGridViewA.Visible = true;
                dataGridViewPRI.Visible = true;
                dataGridViewT.Visible = true;
                dataGridViewL.Visible = true;
                dataGridViewS.Visible = true;
                dataGridViewU.Visible = true;
                dataGridViewW.Visible = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String results = "SELECT UserAccount.Id, UserAccount.Name, Manage_RFID.RFID_ID , Manage_RFID.RFID_STATUS FROM UserAccount INNER JOIN Manage_RFID ON UserAccount.RFID_ID = Manage_RFID.RFID_ID";
            SqlCommand updateCmd = new SqlCommand(results, myconnect);
            myconnect.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(updateCmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridViewA.DataSource = dt;
            myconnect.Close();


            SqlConnection myconnect1 = new SqlConnection(strConnectionString);
            String results1 = "SELECT * from Light_table";
            SqlCommand updateCmd1 = new SqlCommand(results1, myconnect1);
            myconnect1.Open();
            SqlDataAdapter sdr1 = new SqlDataAdapter(updateCmd1);
            DataTable dt1 = new DataTable();
            sdr1.Fill(dt1);
            dataGridViewL.DataSource = dt1;
            myconnect1.Close();


            SqlConnection myconnect12 = new SqlConnection(strConnectionString);
            String results12 = "SELECT * from Tem_table";
            SqlCommand updateCmd12 = new SqlCommand(results12, myconnect12);
            myconnect12.Open();
            SqlDataAdapter sdr12 = new SqlDataAdapter(updateCmd12);
            DataTable dt12 = new DataTable();
            sdr12.Fill(dt12);
            dataGridViewT.DataSource = dt12;
            myconnect1.Close();

            SqlConnection myconnect123 = new SqlConnection(strConnectionString);
            String results123 = "SELECT * from PRI_table";
            SqlCommand updateCmd123 = new SqlCommand(results123, myconnect123);
            myconnect123.Open();
            SqlDataAdapter sdr123 = new SqlDataAdapter(updateCmd123);
            DataTable dt123 = new DataTable();
            sdr123.Fill(dt123);
            dataGridViewPRI.DataSource = dt123;
            myconnect1.Close();

            SqlConnection myconnect10 = new SqlConnection(strConnectionString);
            String results10 = "SELECT * from Sound_table";
            SqlCommand updateCmd10 = new SqlCommand(results10, myconnect10);
            myconnect10.Open();
            SqlDataAdapter sdr10 = new SqlDataAdapter(updateCmd10);
            DataTable dt10 = new DataTable();
            sdr10.Fill(dt10);
            dataGridViewS.DataSource = dt10;
            myconnect10.Close();


            SqlConnection myconnect9 = new SqlConnection(strConnectionString);
            String results9 = "SELECT * from Ultra_table";
            SqlCommand updateCmd9 = new SqlCommand(results9, myconnect9);
            myconnect9.Open();
            SqlDataAdapter sdr9 = new SqlDataAdapter(updateCmd9);
            DataTable dt9 = new DataTable();
            sdr9.Fill(dt9);
            dataGridViewU.DataSource = dt9;
            myconnect9.Close();

            SqlConnection myconnect8 = new SqlConnection(strConnectionString);
            String results8 = "SELECT * from Water_table";
            SqlCommand updateCmd8 = new SqlCommand(results8, myconnect8);
            myconnect8.Open();
            SqlDataAdapter sdr8 = new SqlDataAdapter(updateCmd8);
            DataTable dt8 = new DataTable();
            sdr8.Fill(dt8);
            dataGridViewW.DataSource = dt8;
            myconnect8.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FromDatetime = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            ToDateTime = ToDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("IsEmpty");
            }
            else
            {
                SqlConnection myconnect = new SqlConnection(strConnectionString);

                string strCommandText = "SELECT * FROM UserAccount WHERE  Id=@uqqName";
                SqlCommand cmd = new SqlCommand(strCommandText, myconnect);
                //cmd.Parameters.AddWithValue("@RFID", textBox2.Text);
                cmd.Parameters.AddWithValue("@uqqName", textBox1.Text);

                try
                {
                    myconnect.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        myconnect.Close();

                        {

                            String results = "SELECT UserAccount.Id, UserAccount.Name, Manage_RFID.RFID_ID , Manage_RFID.RFID_STATUS FROM UserAccount INNER JOIN Manage_RFID ON UserAccount.RFID_ID = Manage_RFID.RFID_ID WHERE UserAccount.Id=@ID ";
                            SqlCommand updateCmd = new SqlCommand(results, myconnect);
                            updateCmd.Parameters.AddWithValue("@ID", textBox1.Text);
                            updateCmd.Parameters.AddWithValue("@StartDate", FromDatetime);
                            updateCmd.Parameters.AddWithValue("@EndDate", ToDateTime);
                            myconnect.Open();
                            SqlDataAdapter sdr = new SqlDataAdapter(updateCmd);
                            DataTable dt = new DataTable();
                            sdr.Fill(dt);
                            dataGridViewA.DataSource = dt;
                            myconnect.Close();

                            SqlConnection myconnect1 = new SqlConnection(strConnectionString);
                            String results1 = "SELECT * from Light_table where userid=@ID AND DATETIME BETWEEN @StartDate AND @EndDate";
                            SqlCommand updateCmd1 = new SqlCommand(results1, myconnect1);
                            updateCmd1.Parameters.AddWithValue("@ID", textBox1.Text);
                            updateCmd1.Parameters.AddWithValue("@StartDate", FromDatetime);
                            updateCmd1.Parameters.AddWithValue("@EndDate", ToDateTime);
                            myconnect1.Open();
                            SqlDataAdapter sdr1 = new SqlDataAdapter(updateCmd1);
                            DataTable dt1 = new DataTable();
                            sdr1.Fill(dt1);
                            dataGridViewL.DataSource = dt1;
                            myconnect1.Close();


                            SqlConnection myconnect12 = new SqlConnection(strConnectionString);
                            String results12 = "SELECT * from Tem_table WHERE userid1=@ID AND DATETIME BETWEEN @StartDate AND @EndDate";
                            SqlCommand updateCmd12 = new SqlCommand(results12, myconnect12);
                            updateCmd12.Parameters.AddWithValue("@ID", textBox1.Text);
                            updateCmd12.Parameters.AddWithValue("@StartDate", FromDatetime);
                            updateCmd12.Parameters.AddWithValue("@EndDate", ToDateTime);
                            myconnect12.Open();
                            SqlDataAdapter sdr12 = new SqlDataAdapter(updateCmd12);
                            DataTable dt12 = new DataTable();
                            sdr12.Fill(dt12);
                            dataGridViewT.DataSource = dt12;
                            myconnect1.Close();

                            SqlConnection myconnect123 = new SqlConnection(strConnectionString);
                            String results123 = "SELECT * from PRI_table WHERE userid=@ID AND DATETIME BETWEEN @StartDate AND @EndDate";
                            SqlCommand updateCmd123 = new SqlCommand(results123, myconnect123);
                            updateCmd123.Parameters.AddWithValue("@ID", textBox1.Text);
                            updateCmd123.Parameters.AddWithValue("@StartDate", FromDatetime);
                            updateCmd123.Parameters.AddWithValue("@EndDate", ToDateTime);
                            myconnect123.Open();
                            SqlDataAdapter sdr123 = new SqlDataAdapter(updateCmd123);
                            DataTable dt123 = new DataTable();
                            sdr123.Fill(dt123);
                            dataGridViewPRI.DataSource = dt123;
                            myconnect1.Close();

                            SqlConnection myconnect10 = new SqlConnection(strConnectionString);
                            String results10 = "SELECT * from Sound_table WHERE userid=@ID AND DATETIME BETWEEN @StartDate AND @EndDate";
                            SqlCommand updateCmd10 = new SqlCommand(results10, myconnect10);
                            updateCmd10.Parameters.AddWithValue("@ID", textBox1.Text);
                            updateCmd10.Parameters.AddWithValue("@StartDate", FromDatetime);
                            updateCmd10.Parameters.AddWithValue("@EndDate", ToDateTime);
                            myconnect10.Open();
                            SqlDataAdapter sdr10 = new SqlDataAdapter(updateCmd10);
                            DataTable dt10 = new DataTable();
                            sdr10.Fill(dt10);
                            dataGridViewS.DataSource = dt10;
                            myconnect10.Close();


                            SqlConnection myconnect9 = new SqlConnection(strConnectionString);
                            String results9 = "SELECT * from Ultra_table WHERE userid=@ID AND DATETIME BETWEEN @StartDate AND @EndDate";
                            SqlCommand updateCmd9 = new SqlCommand(results9, myconnect9);
                            updateCmd9.Parameters.AddWithValue("@ID", textBox1.Text);
                            updateCmd9.Parameters.AddWithValue("@StartDate", FromDatetime);
                            updateCmd9.Parameters.AddWithValue("@EndDate", ToDateTime);
                            myconnect9.Open();
                            SqlDataAdapter sdr9 = new SqlDataAdapter(updateCmd9);
                            DataTable dt9 = new DataTable();
                            sdr9.Fill(dt9);
                            dataGridViewU.DataSource = dt9;
                            myconnect9.Close();

                            SqlConnection myconnect8 = new SqlConnection(strConnectionString);
                            String results8 = "SELECT * from Water_table WHERE userid=@ID AND DATETIME BETWEEN @StartDate AND @EndDate";
                            SqlCommand updateCmd8 = new SqlCommand(results8, myconnect8);
                            updateCmd8.Parameters.AddWithValue("@ID", textBox1.Text);
                            updateCmd8.Parameters.AddWithValue("@StartDate", FromDatetime);
                            updateCmd8.Parameters.AddWithValue("@EndDate", ToDateTime);
                            myconnect8.Open();
                            SqlDataAdapter sdr8 = new SqlDataAdapter(updateCmd8);
                            DataTable dt8 = new DataTable();
                            sdr8.Fill(dt8);
                            dataGridViewW.DataSource = dt8;
                            myconnect8.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show(" ID: " + textBox1.Text + " cant be found !");
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

        private void Filter_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("IsEmpty");
            }
            else
            {
                SqlConnection myconnect = new SqlConnection(strConnectionString);

                string strCommandText = "SELECT * FROM UserAccount WHERE  Id=@uqqName";
                SqlCommand cmd = new SqlCommand(strCommandText, myconnect);
                //cmd.Parameters.AddWithValue("@RFID", textBox2.Text);
                cmd.Parameters.AddWithValue("@uqqName", textBox1.Text);

                try
                {
                    myconnect.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        myconnect.Close();

                        {

                            String results = "SELECT UserAccount.Id, UserAccount.Name, Manage_RFID.RFID_ID , Manage_RFID.RFID_STATUS FROM UserAccount INNER JOIN Manage_RFID ON UserAccount.RFID_ID = Manage_RFID.RFID_ID WHERE UserAccount.Id=@ID ";
                            SqlCommand updateCmd = new SqlCommand(results, myconnect);
                            updateCmd.Parameters.AddWithValue("@ID", textBox1.Text);
                            myconnect.Open();
                            SqlDataAdapter sdr = new SqlDataAdapter(updateCmd);
                            DataTable dt = new DataTable();
                            sdr.Fill(dt);
                            dataGridViewA.DataSource = dt;
                            myconnect.Close();

                            SqlConnection myconnect1 = new SqlConnection(strConnectionString);
                            String results1 = "SELECT * from Light_table where userid=@ID";
                            SqlCommand updateCmd1 = new SqlCommand(results1, myconnect1);
                            updateCmd1.Parameters.AddWithValue("@ID", textBox1.Text);
                            myconnect1.Open();
                            SqlDataAdapter sdr1 = new SqlDataAdapter(updateCmd1);
                            DataTable dt1 = new DataTable();
                            sdr1.Fill(dt1);
                            dataGridViewL.DataSource = dt1;
                            myconnect1.Close();


                            SqlConnection myconnect12 = new SqlConnection(strConnectionString);
                            String results12 = "SELECT * from Tem_table WHERE userid1=@ID";
                            SqlCommand updateCmd12 = new SqlCommand(results12, myconnect12);
                            updateCmd12.Parameters.AddWithValue("@ID", textBox1.Text);
                            myconnect12.Open();
                            SqlDataAdapter sdr12 = new SqlDataAdapter(updateCmd12);
                            DataTable dt12 = new DataTable();
                            sdr12.Fill(dt12);
                            dataGridViewT.DataSource = dt12;
                            myconnect1.Close();

                            SqlConnection myconnect123 = new SqlConnection(strConnectionString);
                            String results123 = "SELECT * from PRI_table WHERE userid=@ID";
                            SqlCommand updateCmd123 = new SqlCommand(results123, myconnect123);
                            updateCmd123.Parameters.AddWithValue("@ID", textBox1.Text);
                            myconnect123.Open();
                            SqlDataAdapter sdr123 = new SqlDataAdapter(updateCmd123);
                            DataTable dt123 = new DataTable();
                            sdr123.Fill(dt123);
                            dataGridViewPRI.DataSource = dt123;
                            myconnect1.Close();

                            SqlConnection myconnect10 = new SqlConnection(strConnectionString);
                            String results10 = "SELECT * from Sound_table WHERE userid=@ID";
                            SqlCommand updateCmd10 = new SqlCommand(results10, myconnect10);
                            updateCmd10.Parameters.AddWithValue("@ID", textBox1.Text);
                            myconnect10.Open();
                            SqlDataAdapter sdr10 = new SqlDataAdapter(updateCmd10);
                            DataTable dt10 = new DataTable();
                            sdr10.Fill(dt10);
                            dataGridViewS.DataSource = dt10;
                            myconnect10.Close();


                            SqlConnection myconnect9 = new SqlConnection(strConnectionString);
                            String results9 = "SELECT * from Ultra_table WHERE userid=@ID";
                            SqlCommand updateCmd9 = new SqlCommand(results9, myconnect9);
                            updateCmd9.Parameters.AddWithValue("@ID", textBox1.Text);
                            myconnect9.Open();
                            SqlDataAdapter sdr9 = new SqlDataAdapter(updateCmd9);
                            DataTable dt9 = new DataTable();
                            sdr9.Fill(dt9);
                            dataGridViewU.DataSource = dt9;
                            myconnect9.Close();

                            SqlConnection myconnect8 = new SqlConnection(strConnectionString);
                            String results8 = "SELECT * from Water_table WHERE userid=@ID";
                            SqlCommand updateCmd8 = new SqlCommand(results8, myconnect8);
                            updateCmd8.Parameters.AddWithValue("@ID", textBox1.Text);
                            myconnect8.Open();
                            SqlDataAdapter sdr8 = new SqlDataAdapter(updateCmd8);
                            DataTable dt8 = new DataTable();
                            sdr8.Fill(dt8);
                            dataGridViewW.DataSource = dt8;
                            myconnect8.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show(" ID: " + textBox1.Text + " cant be found !");
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterByTime1 = comboBox2.Text;

            if (FilterByTime1.Equals("ID"))
            {
                label4.Visible = true;
                textBox1.Visible = true;
                Filter.Visible = true;
                button2.Visible = false;



                label10.Visible = false;
                dateTimePicker1.Visible = false;
                label6.Visible = false;
                ToDateTimePicker.Visible = false;
               
                FilterBtn.Visible = false;
            }
            else if (FilterByTime1.Equals("Date_Time"))
            {

                label4.Visible = false;
                textBox1.Visible = false;
                Filter.Visible = false;
                button2.Visible = false;

                label10.Visible = true;
                dateTimePicker1.Visible = true;
                label6.Visible = true;
                ToDateTimePicker.Visible = true;
              
                FilterBtn.Visible = true;
            }
            else if (FilterByTime1.Equals("Both"))
            {
                label4.Visible = true;
                textBox1.Visible = true;
                Filter.Visible = false;
                button2.Visible = true;

                label10.Visible = true;
                dateTimePicker1.Visible = true;
                label6.Visible = true;
                ToDateTimePicker.Visible = true;
               
                FilterBtn.Visible = false;
            }
            else if (FilterByTime1.Equals("None"))
            {
                label4.Visible = false;
                textBox1.Visible = false;
                Filter.Visible = false;
                button2.Visible = false;

                label10.Visible = false;
                dateTimePicker1.Visible = false;
                label6.Visible = false;
                ToDateTimePicker.Visible = false;
               
                FilterBtn.Visible = false;
            }
        }
    }
}
  
  

