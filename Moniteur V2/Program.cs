using System.Management;

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
        public static ManagementObjectSearcher GetInfosCpu()
        {
            ManagementObjectSearcher CpuInfos = new ManagementObjectSearcher("select * from Win32_Processor");
            return CpuInfos;
        }
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
        public static string AppName() 
        {
            string appName = "Moniteur d'activit�s";
            return appName;
        }
        public static string CpuName()
        {
            string cpuName = null;
            ManagementObjectSearcher infos = GetInfosCpu();
            foreach (ManagementObject info in infos.Get())
            {
                cpuName = (string)info["Name"];
            }
            if (cpuName != null)
            {
                return cpuName;
            }
            else
            {
                return "ERREUR : impossible de r�cup�rer le nom du Cpu";
            }
        }
        public static string NbCores() 
        {
            string cores = null;
            ManagementObjectSearcher infos = GetInfosCpu();
            foreach (ManagementObject info in infos.Get())
            {
                cores = info["NumberOfCores"].ToString();
            }
            if (cores != null)
            {
                try
                {
                    int nbCore = int.Parse(cores);
                    if (nbCore > 1)
                    {
                        return "C�urs : " + nbCore;
                    }
                    else
                    {
                        return "C�ur : " + nbCore;
                    }
                }
                catch 
                {
                    return "C�ur(s) : " + cores;
                }

            }
            return "C�ur(s) : " + "ERREUR";
        }
    }
}