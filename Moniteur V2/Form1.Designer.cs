﻿namespace Moniteur_V2
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
            label1 = new Label();
            AppName = new Label();
            label2 = new Label();
            label3 = new Label();
            CPUName = new Label();
            titleProc = new Label();
            Core = new Label();
            Thread = new Label();
            button1 = new Button();
            Fabriquant = new Label();
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
            label3.Size = new Size(10, 268);
            label3.TabIndex = 3;
            // 
            // CPUName
            // 
            CPUName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CPUName.Location = new Point(12, 224);
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
            Core.Location = new Point(12, 268);
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
            Thread.Location = new Point(173, 268);
            Thread.Name = "Thread";
            Thread.Size = new Size(59, 22);
            Thread.TabIndex = 7;
            Thread.Text = "label5";
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(160, 378);
            button1.Name = "button1";
            button1.Size = new Size(136, 33);
            button1.TabIndex = 8;
            button1.Text = "Voir plus d'info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Fabriquant
            // 
            Fabriquant.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Fabriquant.Location = new Point(13, 193);
            Fabriquant.Name = "Fabriquant";
            Fabriquant.Size = new Size(219, 23);
            Fabriquant.TabIndex = 9;
            Fabriquant.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(914, 561);
            Controls.Add(Fabriquant);
            Controls.Add(button1);
            Controls.Add(Thread);
            Controls.Add(Core);
            Controls.Add(titleProc);
            Controls.Add(CPUName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AppName);
            Controls.Add(label1);
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
        private Label Fabriquant;
    }
}