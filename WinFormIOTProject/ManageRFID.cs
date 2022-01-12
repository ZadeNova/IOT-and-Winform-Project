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


    public partial class ManageRFID : Form
    {
        public static string dataref = "";
      
      
    public ManageRFID()
        {
            InitializeComponent();
          
        }
      
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
      

        private void ManageRFID_Load(object sender, EventArgs e)
        {
           
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String results = "SELECT UserAccount.Id, UserAccount.Name, Manage_RFID.RFID_ID , Manage_RFID.RFID_STATUS FROM UserAccount INNER JOIN Manage_RFID ON UserAccount.RFID_ID = Manage_RFID.RFID_ID";
            SqlCommand updateCmd = new SqlCommand(results, myconnect);
            myconnect.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(updateCmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            myconnect.Close();
            
            String results2 = "SELECT RFID_ID , RFID_STATUS FROM Manage_RFID WHERE RFID_STATUS !='Active'";
            SqlCommand updateCmd2 = new SqlCommand(results2, myconnect);
            myconnect.Open();
            SqlDataAdapter sdr2 = new SqlDataAdapter(updateCmd2);
            DataTable dt2 = new DataTable();
            sdr2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            myconnect.Close();

           
        }
       
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            idk.dataComms.sendData("RFIDCRUD");
            Form asign2 = new RFIDUpdate();
            asign2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("RFIDCRUD");
            Form asign1 = new RFIDRemove();
            asign1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("RFIDCRUD");
            Form asign = new RFIDAsign();
            asign.ShowDialog();
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("RFIDCRUD");
            Form asign5 = new RFIDDisable();
            asign5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("RFIDCRUD");
            Form asign6 = new RFIDEnable();
            asign6.ShowDialog();
        }
        void Reload()
        {
            this.Reload();
        }


    }
}
