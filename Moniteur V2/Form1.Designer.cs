namespace Moniteur_V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            AppName = new Label();
            label2 = new Label();
            label3 = new Label();
            CPUName = new Label();
            titleProc = new Label();
            Core = new Label();
            Thread = new Label();
            button1 = new Button();
            timerCpu = new System.Windows.Forms.Timer(components);
            counter = new Label();
            graphiquecard = new Label();
            GpuName1 = new Label();
            Vram = new Label();
            credit = new Label();
            label = new Label();
            OsInfos = new Label();
            Arch = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(890, 59);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // AppName
            // 
            AppName.BackColor = Color.FromArgb(128, 128, 255);
            AppName.BorderStyle = BorderStyle.Fixed3D;
            AppName.Font = new Font("Verdana", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AppName.ForeColor = Color.Transparent;
            AppName.Location = new Point(12, 9);
            AppName.Name = "AppName";
            AppName.Size = new Size(890, 63);
            AppName.TabIndex = 1;
            AppName.Text = "label2";
            AppName.TextAlign = ContentAlignment.MiddleCenter;
            AppName.Click += AppName_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.DimGray;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(890, 10);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.DimGray;
            label3.Location = new Point(447, 143);
            label3.Name = "label3";
            label3.Size = new Size(10, 323);
            label3.TabIndex = 3;
            // 
            // CPUName
            // 
            CPUName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CPUName.Location = new Point(12, 187);
            CPUName.Name = "CPUName";
            CPUName.Size = new Size(429, 27);
            CPUName.TabIndex = 4;
            CPUName.Text = "CPU";
            CPUName.TextAlign = ContentAlignment.MiddleLeft;
            CPUName.Click += label4_Click;
            // 
            // titleProc
            // 
            titleProc.AutoSize = true;
            titleProc.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleProc.Location = new Point(12, 152);
            titleProc.Name = "titleProc";
            titleProc.Size = new Size(118, 22);
            titleProc.TabIndex = 5;
            titleProc.Text = "Processeur :";
            titleProc.Click += titleProc_Click;
            // 
            // Core
            // 
            Core.AutoSize = true;
            Core.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Core.Location = new Point(12, 244);
            Core.Name = "Core";
            Core.Size = new Size(59, 22);
            Core.TabIndex = 6;
            Core.Text = "label4";
            Core.Click += label4_Click_1;
            // 
            // Thread
            // 
            Thread.AutoSize = true;
            Thread.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Thread.Location = new Point(12, 310);
            Thread.Name = "Thread";
            Thread.Size = new Size(59, 22);
            Thread.TabIndex = 7;
            Thread.Text = "label5";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(386, 469);
            button1.Name = "button1";
            button1.Size = new Size(141, 33);
            button1.TabIndex = 8;
            button1.Text = "Voir plus d'infos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timerCpu
            // 
            timerCpu.Tick += timer1_Tick;
            // 
            // counter
            // 
            counter.AutoSize = true;
            counter.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            counter.Location = new Point(12, 374);
            counter.Name = "counter";
            counter.Size = new Size(59, 22);
            counter.TabIndex = 10;
            counter.Text = "label4";
            counter.Click += label4_Click_2;
            // 
            // graphiquecard
            // 
            graphiquecard.AutoSize = true;
            graphiquecard.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            graphiquecard.Location = new Point(463, 152);
            graphiquecard.Name = "graphiquecard";
            graphiquecard.Size = new Size(254, 22);
            graphiquecard.TabIndex = 11;
            graphiquecard.Text = "Carte Graphique principale :";
            graphiquecard.Click += label4_Click_3;
            // 
            // GpuName1
            // 
            GpuName1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GpuName1.Location = new Point(463, 202);
            GpuName1.Name = "GpuName1";
            GpuName1.Size = new Size(432, 23);
            GpuName1.TabIndex = 12;
            GpuName1.Text = "label4";
            GpuName1.Click += label4_Click_4;
            // 
            // Vram
            // 
            Vram.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Vram.Location = new Point(463, 248);
            Vram.Name = "Vram";
            Vram.Size = new Size(432, 18);
            Vram.TabIndex = 15;
            Vram.Text = "vram";
            Vram.Click += Vram_Click;
            // 
            // credit
            // 
            credit.BackColor = Color.FromArgb(128, 128, 255);
            credit.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            credit.ForeColor = Color.White;
            credit.Location = new Point(12, 521);
            credit.Name = "credit";
            credit.Size = new Size(890, 31);
            credit.TabIndex = 16;
            credit.Text = "Créé par FIGUEIRAS Jossua en 2023";
            credit.TextAlign = ContentAlignment.MiddleRight;
            credit.Click += credit_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(463, 310);
            label.Name = "label";
            label.Size = new Size(160, 22);
            label.TabIndex = 17;
            label.Text = "Informations Os :";
            // 
            // OsInfos
            // 
            OsInfos.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OsInfos.Location = new Point(470, 374);
            OsInfos.Name = "OsInfos";
            OsInfos.Size = new Size(432, 23);
            OsInfos.TabIndex = 18;
            OsInfos.Text = "label4";
            OsInfos.Click += label4_Click_5;
            // 
            // Arch
            // 
            Arch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Arch.Location = new Point(470, 421);
            Arch.Name = "Arch";
            Arch.Size = new Size(425, 23);
            Arch.TabIndex = 19;
            Arch.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(914, 561);
            Controls.Add(Arch);
            Controls.Add(OsInfos);
            Controls.Add(label);
            Controls.Add(credit);
            Controls.Add(Vram);
            Controls.Add(GpuName1);
            Controls.Add(graphiquecard);
            Controls.Add(counter);
            Controls.Add(button1);
            Controls.Add(Thread);
            Controls.Add(Core);
            Controls.Add(titleProc);
            Controls.Add(CPUName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AppName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(930, 600);
            MinimumSize = new Size(930, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Moniteur V2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label AppName;
        private Label label2;
        private Label label3;
        private Label CPUName;
        private Label titleProc;
        private Label Core;
        private Label Thread;
        private Button button1;
        private System.Windows.Forms.Timer timerCpu;
        private Label counter;
        private Label graphiquecard;
        private Label GpuName1;
        private Label Vram;
        private Label credit;
        private Label label;
        private Label OsInfos;
        private Label Arch;
    }
}