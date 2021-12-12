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




namespace WinFormIOTProject
{
    public partial class Settings : Form
    {

        //Email stuff
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;



        public Settings()
        {
            InitializeComponent();
        }

       

      
     
      

        private void Home_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
