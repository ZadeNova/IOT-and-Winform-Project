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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        // Copy this for every admin page [submenu code]
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
        //end of submenu code

        private void Data_Click(object sender, EventArgs e)
        {
            showSubMenu(SubmenuData);
           
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForms.Controls.Add(childForm);
            panelChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        

        

        

       

        

       

        

        private void Settings_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Settings());
        }

        private void Notification_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Notification());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new GenerateReport());
        }

        private void Createuser_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CreateUserForm());
        }

        private void ManageUserBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageUserForm());
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            ProfilePage ProfileForm = new ProfilePage();
            this.Hide();
            ProfileForm.ShowDialog();
        }

        private void DataGraphBtn_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("LNT");
            openChildForm(new DataVisualisationForm());
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logform = new LoginForm();
            logform.ShowDialog();
            User.AccountEmail = "";
            User.AccountID = 0;
            User.AccountRole = "";
            User.AccountRole = "";

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void UserSettingsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSettingsForm usersettingform = new UserSettingsForm();
            usersettingform.ShowDialog();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("RFIDCRUD");
            openChildForm(new RIFDCRUD());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("ULTRASONIC");
            openChildForm(new UltraSonic());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("PRIMO");
            openChildForm(new PRIMotion());
        }
    }
}
