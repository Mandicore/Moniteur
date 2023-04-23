namespace Moniteur_V2
{
    partial class Page2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page2));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ComputerName = new Label();
            button2 = new Button();
            OsVersion = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            RamI = new Label();
            label7 = new Label();
            nbdisk = new Label();
            Totalstorage = new Label();
            label8 = new Label();
            Title = new Label();
            timerCpu = new System.Windows.Forms.Timer(components);
            label9 = new Label();
            pourcentcpu = new Label();
            label10 = new Label();
            NameProcesseur = new Label();
            core = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(586, 659);
            button1.Name = "button1";
            button1.Size = new Size(106, 44);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 145);
            label1.Name = "label1";
            label1.Size = new Size(331, 527);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(1005, 145);
            label2.Name = "label2";
            label2.Size = new Size(331, 527);
            label2.TabIndex = 3;
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 154);
            label3.Name = "label3";
            label3.Size = new Size(298, 27);
            label3.TabIndex = 4;
            label3.Text = "Informations Système : ";
            // 
            // ComputerName
            // 
            ComputerName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComputerName.Location = new Point(23, 231);
            ComputerName.Name = "ComputerName";
            ComputerName.Size = new Size(298, 48);
            ComputerName.TabIndex = 5;
            ComputerName.Text = "label4";
            ComputerName.Click += ComputerName_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Location = new Point(56, 611);
            button2.Name = "button2";
            button2.Size = new Size(207, 39);
            button2.TabIndex = 6;
            button2.Text = "Accéder aux paramètres de windows";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // OsVersion
            // 
            OsVersion.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OsVersion.Location = new Point(23, 325);
            OsVersion.Name = "OsVersion";
            OsVersion.Size = new Size(298, 51);
            OsVersion.TabIndex = 7;
            OsVersion.Text = "label4";
            OsVersion.Click += OsVersion_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 194);
            label4.Name = "label4";
            label4.Size = new Size(202, 23);
            label4.TabIndex = 8;
            label4.Text = "Nom de la machine :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 292);
            label5.Name = "label5";
            label5.Size = new Size(173, 23);
            label5.TabIndex = 9;
            label5.Text = "Version de l'Os :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 393);
            label6.Name = "label6";
            label6.Size = new Size(173, 23);
            label6.TabIndex = 10;
            label6.Text = "Ram installée: ";
            // 
            // RamI
            // 
            RamI.AutoSize = true;
            RamI.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RamI.Location = new Point(23, 426);
            RamI.Name = "RamI";
            RamI.Size = new Size(58, 18);
            RamI.TabIndex = 11;
            RamI.Text = "label7";
            RamI.Click += RamI_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(23, 478);
            label7.Name = "label7";
            label7.Size = new Size(173, 23);
            label7.TabIndex = 12;
            label7.Text = "Stockage :";
            label7.Click += label7_Click;
            // 
            // nbdisk
            // 
            nbdisk.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nbdisk.Location = new Point(23, 509);
            nbdisk.Name = "nbdisk";
            nbdisk.Size = new Size(298, 23);
            nbdisk.TabIndex = 13;
            nbdisk.Text = "label8";
            nbdisk.Click += nbdisk_Click;
            // 
            // Totalstorage
            // 
            Totalstorage.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Totalstorage.Location = new Point(23, 544);
            Totalstorage.Name = "Totalstorage";
            Totalstorage.Size = new Size(298, 23);
            Totalstorage.TabIndex = 14;
            Totalstorage.Text = "label8";
            Totalstorage.Click += Totalstorage_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(39, 567);
            label8.Name = "label8";
            label8.Size = new Size(282, 23);
            label8.TabIndex = 15;
            label8.Text = "* Addition capacitée de tous les disques ";
            // 
            // Title
            // 
            Title.BackColor = Color.FromArgb(128, 128, 255);
            Title.Font = new Font("Verdana", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(12, 26);
            Title.Name = "Title";
            Title.Size = new Size(1340, 59);
            Title.TabIndex = 1;
            Title.Text = "Moniteur d'activités";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += label1_Click;
            // 
            // timerCpu
            // 
            timerCpu.Tick += timerCpu_Tick;
            // 
            // label9
            // 
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.Location = new Point(411, 231);
            label9.Name = "label9";
            label9.Size = new Size(521, 407);
            label9.TabIndex = 19;
            label9.Click += label9_Click;
            // 
            // pourcentcpu
            // 
            pourcentcpu.BackColor = Color.FromArgb(128, 128, 255);
            pourcentcpu.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pourcentcpu.ForeColor = Color.White;
            pourcentcpu.Location = new Point(614, 478);
            pourcentcpu.Name = "pourcentcpu";
            pourcentcpu.Size = new Size(106, 33);
            pourcentcpu.TabIndex = 20;
            pourcentcpu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Verdana", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(128, 128, 255);
            label10.Location = new Point(431, 105);
            label10.Name = "label10";
            label10.Size = new Size(480, 46);
            label10.TabIndex = 21;
            label10.Text = "Mon Processeur";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += label10_Click_1;
            // 
            // NameProcesseur
            // 
            NameProcesseur.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NameProcesseur.Location = new Point(460, 194);
            NameProcesseur.Name = "NameProcesseur";
            NameProcesseur.Size = new Size(407, 37);
            NameProcesseur.TabIndex = 22;
            NameProcesseur.Text = "label11";
            NameProcesseur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // core
            // 
            core.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            core.Location = new Point(460, 256);
            core.Name = "core";
            core.Size = new Size(407, 35);
            core.TabIndex = 23;
            core.Text = "label11";
            core.TextAlign = ContentAlignment.MiddleCenter;
            core.Click += label11_Click;
            // 
            // Page2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1364, 749);
            Controls.Add(core);
            Controls.Add(NameProcesseur);
            Controls.Add(label10);
            Controls.Add(pourcentcpu);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(Totalstorage);
            Controls.Add(nbdisk);
            Controls.Add(label7);
            Controls.Add(RamI);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(OsVersion);
            Controls.Add(button2);
            Controls.Add(ComputerName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Page2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Moniteur d'activités";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label ComputerName;
        private Button button2;
        private Label OsVersion;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label RamI;
        private Label label7;
        private Label nbdisk;
        private Label Totalstorage;
        private Label label8;
        private Label Title;
        private System.Windows.Forms.Timer timerCpu;
        private Label label9;
        private Label pourcentcpu;
        private Label label10;
        private Label NameProcesseur;
        private Label core;
    }
}