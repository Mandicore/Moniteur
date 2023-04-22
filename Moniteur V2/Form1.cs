using System.Diagnostics;

namespace Moniteur_V2
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        public Form1()
        {
            InitializeComponent();

            //Computer infos display
            label1.Text = Informations.ComputerName();
            AppName.Text = Informations.AppName();

            //CPU infos display
            CPUName.Text = InformationsCpu.CpuName();
            Core.Text = InformationsCpu.NbCores();
            Thread.Text = InformationsCpu.NbThreads();
            //temp.Text = InformationsCpu.GetTemp();
            //Fabriquant.Text = InformationsCpu.FacturName();

            //Cpu Counter
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            timerCpu.Interval = 250; // mettez à jour l'utilisation du CPU toutes les 1 seconde
            timerCpu.Start();

            //GPU infos display

            var gpuList = InformationsGpu.GetGpuName();
            if (gpuList.Count == 1)
            {
                GpuName1.Text = gpuList[0];
            }
            else if (gpuList.Count == 2)
            {
                GpuName1.Text = gpuList[0];
                GpuName2.Text = gpuList[1];
            }
            else
            {
                GpuName1.Text = gpuList[0];
                GpuName2.Text = gpuList[1];
                GpuName3.Text = gpuList[2];
            }
            string vram = "Vram de la carte graphique principal : " + InformationsGpu.GetVram()[0];
            Vram.Text = vram;

            //string GhzGpu = InformationsGpu.GetMaxClockSpeed()[0].ToString();
            //GpuGhz.Text = GhzGpu;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AppName_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void titleProc_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LienSite Form2 = new LienSite();
            Form2.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            float cpuUsage = cpuCounter.NextValue();
            counter.Text = $"Utilisation du Processeur : {cpuUsage:F1}%";
        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click_3(object sender, EventArgs e)
        {

        }

        private void label4_Click_4(object sender, EventArgs e)
        {

        }

        private void GpuName2_Click(object sender, EventArgs e)
        {

        }

        private void Vram_Click(object sender, EventArgs e)
        {

        }

        private void credit_Click(object sender, EventArgs e)
        {

        }
    }
}