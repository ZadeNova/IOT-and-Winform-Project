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
    public partial class ManageUserForm : Form
    {
        public ManageUserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ManageUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iOTProjDBDataSet1.UserAccount' table. You can move, or remove it, as needed.
            this.userAccountTableAdapter.Fill(this.iOTProjDBDataSet1.UserAccount);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Usernametxtbox.Text = row.Cells[1].Value.ToString();
                
            }
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

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard.ActiveForm.Close();
            ProfilePage ProfileForm = new ProfilePage();

            ProfileForm.Show();
        }

        private void UserSettingsbtn_Click(object sender, EventArgs e)
        {
            AdminDashboard.ActiveForm.Close();
            UserSettingsForm usersettingform = new UserSettingsForm();
            usersettingform.Show();
        }

        private void Usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Filterbtn_Click(object sender, EventArgs e)
        {
            //Type the filter code here lmao





        }
    }
}
