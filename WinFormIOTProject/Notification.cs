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

       

        private void Notification_Load(object sender, EventArgs e)
        {

            
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
