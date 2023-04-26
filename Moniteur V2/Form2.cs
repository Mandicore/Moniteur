using System.Diagnostics;


namespace Moniteur_V2
{
    public partial class Page2 : Form
    {
        private PerformanceCounter cpuCounter;
        public Page2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            ComputerName.Text = Informations.ComputerName();
            OsVersion.Text = Os.GetOsInfos("os") + " , " + Os.GetOsInfos("arch");
            string RamGo = GetRamInfos.getRam() + " Go";
            RamI.Text = RamGo;
            string disk = "disque ";
            if (Disk.GetDiskCount().Count() > 1)
            {
                disk = "disques ";
            }
            Type.Text = Informations.GetComputerType();
            nbdisk.Text = "Nombre de " + disk + Disk.GetDiskCount().Count() + " Disques";
            Totalstorage.Text = "Capacitée Max : " + Disk.GetDiskCapacity() + " Go";
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            timerCpu.Interval = 600;
            timerCpu.Start();
            NameProcesseur.Text = InformationsCpu.CpuName();
            core.Text = InformationsCpu.NbCores() + " | " + InformationsCpu.NbThreads();
            string text = "Nombre de carte graphique : ";
            if (InformationsGpu.GetGpuName().Count > 1)
            {
                text = "Nombre de cartes graphiques : ";
            }
            NbGC.Text = text + InformationsGpu.GetGpuName().Count.ToString();
            GPU1.Text = InformationsGpu.GetGpuName()[0];
            if (InformationsGpu.GetGpuName().Count == 2)
            {
                GPU2.Text = InformationsGpu.GetGpuName()[1];
                GPU2T.Text = "Carte Graphique 2";
            }
            if (InformationsGpu.GetGpuName().Count == 3)
            {
                GPU2.Text = InformationsGpu.GetGpuName()[1];
                GPU2T.Text = "Carte Graphique 2";
                GPU3.Text = InformationsGpu.GetGpuName()[2];
                GPU3T.Text = "Carte Graphique 3";

            }
            Vram.Text = "Vram de la carte graphique principal : " + InformationsGpu.GetVram()[0];
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InformationsCpu.CpuName().ToLower().Contains("intel"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c start https://www.intel.fr/content/www/fr/fr/products/details/processors.html");
                Process.Start(startInfo);
            }
            else
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c start https://www.amd.com/fr.html");
                Process.Start(startInfo);
            }

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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Page3 Form3 = new Page3();
            Form3.Show();
            Pdf.CreateNewPdf();
            Form3.Hide();
        }

        private void Type_Click(object sender, EventArgs e)
        {

        }
    }
}
