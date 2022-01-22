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
            dataGridView1.DataSource = dt;
            myconnect.Close();
        }
    }
}
