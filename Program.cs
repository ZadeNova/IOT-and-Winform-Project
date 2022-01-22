using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormIOTProject
{

    public static class idk {
       //hj code dont remove lol idk
        public static DataComms dataComms = new DataComms();
    }
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
            Application.Run(new LoginForm());
           // Application.Run(new GraphData());
            //Application.Run(new SignUpForm());
            //Application.Run(new Home_Admin_());
            //Application.Run(new AdminDashboard());
            //Application.Run(new DataVisualisationForm());
            //Application.Run(new RFIDLoginForm());
            //Application.Run(new Settings());
            //Application.Run(new Notification());
            //Application.Run(new ForgotPasswordForm());
            //Application.Run(new RFIDLoginForm());
            //Application.Run(new CreateUserForm());
            //Application.Run(new UpdatePassword());
           
        }

    }
   
   

    // Session 
    static class User
    {
        public static string AccountUsername;
        public static string AccountRole;
        public static string AccountEmail;
        public static int AccountID;
    }


    




}
