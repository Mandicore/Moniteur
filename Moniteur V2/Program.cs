using System.Management;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;

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
        public static string GetComputerType()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");

            int format = 0;
            foreach (ManagementObject mo in mc.GetInstances())
            {
                format = (ushort)mo["PCSystemType"];
                break;
            }

            if (format == 2)
            {
                return "Laptop (Ordinateur Portable)";
            }
            else if (format == 3)
            {
                return "Desktop (Ordinateur de Bureau)";
            }
            else
            {
                return " ";
            }
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
        public static List<string> GetDiskCount()
        {
            int count = 0;
            var diskList = new List<string>();
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                count++;
                diskList.Add(d.Name.ToString());
            }

            return diskList;
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

            //Def Fonts
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 22, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font secondTitleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font informationsFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.GRAY);
            iTextSharp.text.Font explainFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.GRAY);

            //Add text
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfFilePath, FileMode.Create));
            document.Open();
            Paragraph title = new Paragraph("Informations sur votre ordinateur", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 50f;
            document.Add(title);

            Paragraph SecondTitle3 = new Paragraph("Information sur votre Système :", secondTitleFont);
            SecondTitle3.SpacingAfter = 10f;
            document.Add(SecondTitle3);

            Paragraph infoInfos1 = new Paragraph("- Version de windows : "  + Os.GetOsInfos("os") + " , " + Os.GetOsInfos("arch"), informationsFont);
            infoInfos1.SpacingAfter = 5f;
            document.Add(infoInfos1);

            Paragraph infoInfos2 = new Paragraph("- Nom de votre Ordinateur * : " + Informations.ComputerName(), informationsFont);
            infoInfos2.SpacingAfter = 5f;
            document.Add(infoInfos2);

            Paragraph explainInfo1 = new Paragraph("* Le nom de votre machine est disponible dans paramètres de windows/Système/à propos ou en cliquant sur le bouton Acceder aux paramètres de windows dans la fenêtre plus d'informations de l'application", explainFont);
            explainInfo1.SpacingAfter = 5f;
            document.Add(explainInfo1);

            Paragraph SecondTitle1 = new Paragraph("Information sur votre Processeur (CPU*):", secondTitleFont);
            SecondTitle1.SpacingAfter = 10f;
            document.Add(SecondTitle1);

            Paragraph infoCpu1 = new Paragraph("- " + InformationsCpu.CpuName(), informationsFont);
            infoCpu1.SpacingAfter = 5f;
            document.Add(infoCpu1);

            Paragraph infoCpu2 = new Paragraph("- " + InformationsCpu.NbCores(), informationsFont);
            infoCpu2.SpacingAfter = 5f;
            document.Add(infoCpu2);

            Paragraph infoCpu3 = new Paragraph("- " + InformationsCpu.NbThreads(), informationsFont);
            infoCpu3.SpacingAfter = 5f;
            document.Add(infoCpu3);

            Paragraph edxplainCpu1 = new Paragraph("* CPU : Central Proccessing Unit", explainFont);
            edxplainCpu1.SpacingAfter = 5f;
            document.Add(edxplainCpu1);

            string GraphicsTitle = TitleGpu();

            Paragraph SecondTitle2 = new Paragraph(GraphicsTitle, secondTitleFont);
            SecondTitle2.SpacingAfter = 10f;
            document.Add(SecondTitle2);

            Paragraph infoGpu1 = new Paragraph("- " + InformationsGpu.GetGpuName()[0], informationsFont);
            infoGpu1.SpacingAfter = 5f;
            document.Add(infoGpu1);

            Paragraph infoGpu4 = new Paragraph("- Vram : " + InformationsGpu.GetVram()[0], informationsFont);
            infoGpu4.SpacingAfter = 5f;
            document.Add(infoGpu4);

            if (InformationsGpu.GetGpuName().Count == 2)
            {
                Paragraph infoGpu2 = new Paragraph("- " + InformationsGpu.GetGpuName()[1], informationsFont);
                infoGpu2.SpacingAfter = 5f;
                document.Add(infoGpu2);

                Paragraph infoGpu5 = new Paragraph("- Vram : " + InformationsGpu.GetVram()[1], informationsFont);
                infoGpu5.SpacingAfter = 5f;
                document.Add(infoGpu5);
            }
            if (InformationsGpu.GetGpuName().Count == 3)
            {
                Paragraph infoGpu3 = new Paragraph("- Vram : " + InformationsGpu.GetGpuName()[2], informationsFont);
                infoGpu3.SpacingAfter = 5f;
                document.Add(infoGpu3);

                Paragraph infoGpu6 = new Paragraph("- Vram : " + InformationsGpu.GetVram()[2], informationsFont);
                infoGpu6.SpacingAfter = 5f;
                document.Add(infoGpu6);
            }

            Paragraph explainGpu1 = new Paragraph("* GPU : Graphics Processing Unit (carte graphique dédiée)", explainFont);
            explainGpu1.SpacingAfter = 5f;
            document.Add(explainGpu1);

            Paragraph explainGpu2 = new Paragraph("* APU : Accelerated Processing Unit (GPU intégré au CPU (processeur))", explainFont);
            explainGpu2.SpacingAfter = 5f;
            document.Add(explainGpu2);

            Paragraph SecondTitle4 = new Paragraph("Stockage : ", secondTitleFont);
            SecondTitle4.SpacingAfter = 10f;
            document.Add(SecondTitle4);

            Paragraph infoStockage1 = new Paragraph("- Ram installée : " + GetRamInfos.getRam() + " Go", informationsFont);
            infoStockage1.SpacingAfter = 5f;
            document.Add(infoStockage1);

            Paragraph infoStockage2 = new Paragraph("- Nombre de disques (clef usb comprise) : " + Disk.GetDiskCount().Count(), informationsFont);
            infoStockage2.SpacingAfter = 5f;
            document.Add(infoStockage2);

            foreach (string element in Disk.GetDiskCount())
            {
                Paragraph infoDiskStockage = new Paragraph("- " + element, informationsFont);
                infoDiskStockage.SpacingAfter = 5f;
                document.Add(infoDiskStockage);
            }

            Paragraph infoStockage3 = new Paragraph("- Capacité maximum de stockage (addition de capacité de chaque disque présent sur cette machine) : " + Disk.GetDiskCapacity() + " Go", informationsFont);
            infoStockage3.SpacingAfter = 5f;
            document.Add(infoStockage3);

            document.Close();

            ProcessStartInfo startInfo = new ProcessStartInfo(pdfFilePath)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(startInfo);
            

        }
        public static string TitleGpu()
        {
            string GraphicsTitle = "Information sur votre Carte Graphique (GPU/APU*)";

            if (InformationsGpu.GetGpuName().Count < 1)
            {
                GraphicsTitle = "Informations sur vos Cartes Graphiques (GPU/APU*)";
            }
            return GraphicsTitle;
        } 
    }
}