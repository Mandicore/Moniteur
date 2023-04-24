using System.Management;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;


namespace Moniteur_V2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
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
    public class Os
    {
        public static string GetOsInfos(string param)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            foreach (ManagementObject mo in mos.Get())
            {
                switch (param)
                {
                    case "os":
                        return mo["Caption"].ToString();
                    case "arch":
                        return mo["OSArchitecture"].ToString();
                    case "osv":
                        return mo["CSDVersion"].ToString();


                }
            }
            return "";
        }
    }
    public class GetRamInfos
    {
        public static int getRam()
        {
            int totalMemoryMB = 0;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject item in searcher.Get())
            {
                long totalMemoryBytes = Convert.ToInt64(item["TotalPhysicalMemory"]);
                totalMemoryMB = Convert.ToInt32(totalMemoryBytes / (1024 * 1024));
            }
            return totalMemoryMB / 1000;
        }
    }
    public class Disk
    {
        public static int GetDiskCount()
        {
            int count = 0;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");

            foreach (ManagementObject drive in searcher.Get())
            {
                count++;
            }

            return count;
        }
        public static float GetDiskCapacity()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            float allDrivesCapacity = 0;
            foreach (DriveInfo drive in allDrives)
            {
                if (drive.IsReady)
                {
                    allDrivesCapacity = allDrivesCapacity + drive.TotalSize / (1024 * 1024 * 1024);
                }
                else
                {
                    allDrivesCapacity = allDrivesCapacity;
                }
            }
            return allDrivesCapacity;
        }
    }
    public class Pdf
    {
        public static void CreateNewPdf()
        {

            string downloadFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string pdfFilePath = Path.Combine(downloadFolderPath, "InformationsMachine.pdf");

            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfFilePath, FileMode.Create));
            document.Open();
            Paragraph paragraph = new Paragraph("Bonjour, ceci est un exemple de document PDF créé en C# !");
            document.Add(paragraph);
            document.Close();

            ProcessStartInfo startInfo = new ProcessStartInfo(pdfFilePath)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(startInfo);
            

        }
        }
}