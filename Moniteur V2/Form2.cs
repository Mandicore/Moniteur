using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Moniteur_V2
{
    public partial class Page2 : Form
    {
        private PerformanceCounter _ramCounter;
        private PerformanceCounter cpuCounter;
        public Page2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // maximise la fenêtre pour qu'elle prenne toute la place de l'écran
            this.FormBorderStyle = FormBorderStyle.Sizable; // définit la bordure de la fenêtre à une bordure redimensionnable

            ComputerName.Text = Informations.ComputerName();
            OsVersion.Text = Os.GetOsInfos("os") + " , " + Os.GetOsInfos("arch");
            string RamGo = GetRamInfos.getRam() + " Go";
            RamI.Text = RamGo;
            string disk = "disque ";
            if (Disk.GetDiskCount() > 1)
            {
                disk = "disques ";
            }
            nbdisk.Text = "Nombre de " + disk + Disk.GetDiskCount() + " Disques";
            Totalstorage.Text = "Capacitée Max : " + Disk.GetDiskCapacity() + " Go";
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            timerCpu.Interval = 600; // mettez à jour l'utilisation du CPU toutes les 1 seconde
            timerCpu.Start();
            NameProcesseur.Text = InformationsCpu.CpuName();
            core.Text = InformationsCpu.NbCores() + " | " + InformationsCpu.NbThreads(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c start https://www.intel.fr/content/www/fr/fr/products/sku/75048/intel-core-i54670k-processor-6m-cache-up-to-3-80-ghz/specifications.html");
            Process.Start(startInfo);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComputerName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ms-settings:about");
            }
            catch
            {
                try
                {
                    Process.Start("explorer.exe", "ms-settings:about");
                }
                catch
                {
                    Erreur Erreur = new Erreur();
                    Erreur.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void OsVersion_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RamI_Click(object sender, EventArgs e)
        {

        }

        private void timerRam_Tick(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nbdisk_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Totalstorage_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void timerCpu_Tick(object sender, EventArgs e)
        {
            float cpuUsage = cpuCounter.NextValue();
            pourcentcpu.Text = $"{cpuUsage:F1}%";

            if (cpuUsage < 20)
            {
                pourcentcpu.BackColor = Color.White;
                pourcentcpu.ForeColor = Color.Black;
            }
            else if ((cpuUsage > 20) && (cpuUsage < 40))
            {
                pourcentcpu.BackColor = Color.Green;
                pourcentcpu.ForeColor = Color.White;
            }
            else if ((cpuUsage > 40) && (cpuUsage < 60))
            {
                pourcentcpu.BackColor = Color.Yellow;
                pourcentcpu.ForeColor = Color.Black;
            }
            else if ((cpuUsage > 60) && (cpuUsage < 80))
            {
                pourcentcpu.BackColor = Color.Orange;
                pourcentcpu.ForeColor = Color.Black;
            }
            else if ((cpuUsage > 80) && (cpuUsage < 90))
            {
                pourcentcpu.BackColor = Color.OrangeRed;
                pourcentcpu.ForeColor = Color.White;
            }
            else if (cpuUsage > 90)
            {
                pourcentcpu.BackColor = Color.Red;
                pourcentcpu.ForeColor = Color.White;
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
