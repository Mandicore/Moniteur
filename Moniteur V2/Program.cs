namespace Moniteur_V2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class informations
    {
        public static string ComputerName()
        {
            try
            {
                string cName = Environment.MachineName;
                return cName;
            }
            catch
            {
                return "Erreur";
            }

        }
    }
}