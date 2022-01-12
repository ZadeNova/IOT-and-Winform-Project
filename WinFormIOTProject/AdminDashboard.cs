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
            SubMenuManagement.Visible = false;
            SubmenuDataGraphs.Visible = false;
            SubmenuSettings.Visible = false;
           
         
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
        private void Hidesubmenu2()
        {
            if (SubMenuManagement.Visible == true)
                SubMenuManagement.Visible = false;

        }
        private void showSubMenu2(Panel subMenu2)
        {
            if (subMenu2.Visible == false)
            {
                //Hidesubmenu();
                subMenu2.Visible = true;
            }
            else
            {
                subMenu2.Visible = false;
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

            //openChildForm(new Settings());
            showSubMenu(SubmenuSettings);
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
            showSubMenu2(SubMenuManagement);
          
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

        private void button1_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("WATER");
            openChildForm(new watersensor());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("SOUND");
            openChildForm(new SoundSensor());
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageUserForm());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageRFID());
        }

        private void Home_Click(object sender, EventArgs e)
        {
            AdminDashboard form2 = new AdminDashboard();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AllData_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewAllData());
        }

        private void ViewDataGraphbtn_Click(object sender, EventArgs e)
        {
            showSubMenu(SubmenuDataGraphs);
        }
    }
}
