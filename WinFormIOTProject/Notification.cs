using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormIOTProject
{
    public partial class Notification : Form
    {
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
    }
}
