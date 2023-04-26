namespace Moniteur_V2
{
    partial class chargement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chargement));
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(277, 44);
            label1.TabIndex = 0;
            label1.Text = "Chargement ...";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chargement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(301, 110);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "chargement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "chargement";
            Load += chargement_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}