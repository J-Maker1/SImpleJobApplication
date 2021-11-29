using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_App
{
    static class Program
    {
        public static Form2 userPage;
        public static Login login;
        public static PopupEmployer popupEmployer;
        public static PopupUser popupUserPage;
        public static String jobIDViewed;
        public static String jobTitleViewed;
        public static String jobAvgViewed;
        public static String jobMaxViewed;
        public static String jobStateViewed;
        public static String jobREgionViewed;
        public static String jobGrowthViewed;
        public static Form1 employerPage;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            userPage = new Form2();
            login = new Login();
            employerPage = new Form1("");
            popupUserPage = new PopupUser();
            popupEmployer = new PopupEmployer();
            Application.Run(login);   
        }
    }
}
