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
            label1.Text = informations.ComputerName();
            AppName.Text = informations.AppName();

            //CPU infos display
            CPUName.Text = informationsCpu.CpuName();
            Core.Text = informationsCpu.NbCores();
            Thread.Text = informationsCpu.NbThreads();
            //temp.Text = informations.GetTemp();
            //Fabriquant.Text = informations.FacturName();

            //Cpu Counter
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            timer1.Interval = 250; // mettez à jour l'utilisation du CPU toutes les 1 seconde
            timer1.Start();

            //GPU infos display

            //GpuName.Text = informations.GpuName();
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
    }
}