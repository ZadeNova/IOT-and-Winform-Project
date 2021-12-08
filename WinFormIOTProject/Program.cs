using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormIOTProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //Application.Run(new SignUpForm());
            //Application.Run(new Home_Admin_());
            //Application.Run(new AdminDashboard());
            //Application.Run(new DataVisualisationForm());
            //Application.Run(new RFIDLoginForm());
            Application.Run(new Settings());
        }

    }



    // Session 
    static class User
    {
        public static string Username;
        public static string Role;
        
    }


    




}
