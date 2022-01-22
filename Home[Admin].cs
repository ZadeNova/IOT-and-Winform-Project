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
    public partial class Home_Admin_ : Form
    {
        public Home_Admin_()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void SubmenuData_Paint(object sender, PaintEventArgs e)
       {

       }
        private void CustomizeDesign()
        {
            SubmenuData.Visible = false;

        }

        private void Hidesubmenu()
        {
            if (SubmenuData.Visible == true)
                SubmenuData.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //Hidesubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
