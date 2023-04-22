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
    public class Informations
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
        public static string AppName() 
        {
            string appName = "Moniteur d'activités";
            return appName;
        }
    }
    public class InformationsCpu
    {
        public static ManagementObjectSearcher GetInfosCpu()
        {
            ManagementObjectSearcher CpuInfos = new ManagementObjectSearcher("select * from Win32_Processor");
            return CpuInfos;
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
                        return "Nombre de " + name + "s : " + reponseInt;
                    }
                    else
                    {
                        return "Nombre de " + name + " : " + reponseInt;
                    }
                }
                catch
                {
                    return "Nombre de " + name + "(s) : " + reponse;
                }

            }
            return "Nombre de " + name + "(s) : " + "ERREUR";
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
    public class InformationsGpu
    {
        public static List<string> GetGpuName()
        {
            var gpuNames = new List<string>();
            ManagementObjectSearcher infos = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject info in infos.Get())
            {
                string gpuName = info["Name"].ToString();
                gpuNames.Add(gpuName);
            }
            return gpuNames;
        } 
        public static List<string> GetVram()
        {
            List<ulong> vramSizes = new List<ulong>();
            ulong vramSize = 0;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject obj in searcher.Get())
            {
                vramSize = Convert.ToUInt64(obj["AdapterRAM"]);
                vramSizes.Add(vramSize);
            }
            var vramInt = new List<float>();
            try
            {
                foreach (ulong i in vramSizes)
                {
                    int j = Convert.ToInt32(i);
                    float t = j / (1024 * 1024);
                    float r = t / 1000;
                    vramInt.Add(r);
                }

                var vramString = new List<string>();

                foreach(float Elements in vramInt)
                {
                    string reponse = Elements.ToString("0.##") + " Go";
                    vramString.Add(reponse);
                }
                return vramString;
            }
            catch
            {
                return new List<string>{ "ERREUR" };
            }
        }
    }
}