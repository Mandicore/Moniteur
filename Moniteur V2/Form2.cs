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

namespace Moniteur_V2
{
    public partial class Page2 : Form
    {
        public Page2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // maximise la fenêtre pour qu'elle prenne toute la place de l'écran
            this.FormBorderStyle = FormBorderStyle.Sizable; // définit la bordure de la fenêtre à une bordure redimensionnable


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c start https://www.intel.fr/content/www/fr/fr/products/sku/75048/intel-core-i54670k-processor-6m-cache-up-to-3-80-ghz/specifications.html");
            Process.Start(startInfo);

        }
    }
}
