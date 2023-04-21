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
            string appName = "Moniteur d'activités";
            return appName;
        }
        public static string CpuName()
        {
            return GetNames("Name", "Processeur");
        }
        public static string FacturName()
        {
            return GetNames("Manufacturer", "Fabriquant");
        }
        public static string NbCores() 
        {
            return GetCandT("NumberOfCores", "Cœur");
        }
        public static string NbThreads()
        {
            return GetCandT("NumberOfLogicalProcessors", "Thread");
        }
        public static String GetCandT(string Element, string name)
        {
            string reponse = null;
            ManagementObjectSearcher infos = GetInfosCpu();
            foreach (ManagementObject info in infos.Get())
            {
                reponse = info[Element].ToString();
            }
            if (reponse != null)
            {
                try
                {
                    int reponseInt = int.Parse(reponse);
                    if (reponseInt > 1)
                    {
                        return name + "s : " + reponseInt;
                    }
                    else
                    {
                        return name + " : " + reponseInt;
                    }
                }
                catch
                {
                    return name + "(s) : " + reponse;
                }

            }
            return name + "(s) : " + "ERREUR";
        }
        public static string GetNames(string element, string name)
        {
            string cpuName = null;
            ManagementObjectSearcher infos = GetInfosCpu();
            foreach (ManagementObject info in infos.Get())
            {
                cpuName = (string)info[element];
            }
            if (cpuName != null)
            {
                return cpuName;
            }
            else
            {
                return "ERREUR : impossible de récupérer le nom du " + name;
            }
        }
    }
}