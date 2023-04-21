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
            label1 = new Label();
            AppName = new Label();
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(914, 561);
            Controls.Add(AppName);
            Controls.Add(label1);
            MaximumSize = new Size(930, 600);
            MinimumSize = new Size(930, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Moniteur V2";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label AppName;
    }
}