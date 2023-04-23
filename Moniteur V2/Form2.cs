using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            nbdisk.Text = "Nombre de "  + disk + Disk.GetDiskCount() + " Disques";

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
    }
}
