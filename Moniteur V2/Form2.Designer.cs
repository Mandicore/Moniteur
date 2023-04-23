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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page2));
            button1 = new Button();
            Title = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ComputerName = new Label();
            button2 = new Button();
            OsVersion = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(626, 488);
            button1.Name = "button1";
            button1.Size = new Size(106, 44);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Title
            // 
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Verdana", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Title.ForeColor = Color.FromArgb(128, 128, 255);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(1340, 59);
            Title.TabIndex = 1;
            Title.Text = "Moniteur d'activités";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += label1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(331, 560);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(1021, 112);
            label2.Name = "label2";
            label2.Size = new Size(331, 560);
            label2.TabIndex = 3;
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 126);
            label3.Name = "label3";
            label3.Size = new Size(298, 27);
            label3.TabIndex = 4;
            label3.Text = "Informations Système : ";
            // 
            // ComputerName
            // 
            ComputerName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComputerName.Location = new Point(23, 226);
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
            OsVersion.Location = new Point(23, 338);
            OsVersion.Name = "OsVersion";
            OsVersion.Size = new Size(298, 51);
            OsVersion.TabIndex = 7;
            OsVersion.Text = "label4";
            OsVersion.Click += OsVersion_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(23, 178);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 8;
            label4.Text = "Nom de la machine :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Cambria", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(23, 285);
            label5.Name = "label5";
            label5.Size = new Size(173, 23);
            label5.TabIndex = 9;
            label5.Text = "Version de l'Os :";
            // 
            // Page2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1364, 749);
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
        }

        #endregion

        private Button button1;
        private Label Title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label ComputerName;
        private Button button2;
        private Label OsVersion;
        private Label label4;
        private Label label5;
    }
}