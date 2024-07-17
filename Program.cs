using System.Diagnostics;

namespace KursDBWinForms
{
    static class LastLogin
    {
        public static string lastLogin = "";
    }

    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
            
           
        }
    }
}