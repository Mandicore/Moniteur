namespace Moniteur_V2
{
    partial class Erreur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Erreur));
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(186, 74);
            label1.TabIndex = 0;
            label1.Text = "ERREUR : Impossible de vous redirigez vers les paramètres windows !";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Erreur
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 150);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Erreur";
            Text = "Erreur";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}