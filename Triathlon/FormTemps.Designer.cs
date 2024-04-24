namespace Triathlon
{
    partial class FormTemps
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
            this.tabControlTemps = new System.Windows.Forms.TabControl();
            this.tabPageAffTemps = new System.Windows.Forms.TabPage();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.tabControlTemps.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTemps
            // 
            this.tabControlTemps.Controls.Add(this.tabPageAffTemps);
            this.tabControlTemps.Controls.Add(this.tabPageDetails);
            this.tabControlTemps.Location = new System.Drawing.Point(12, 12);
            this.tabControlTemps.Name = "tabControlTemps";
            this.tabControlTemps.SelectedIndex = 0;
            this.tabControlTemps.Size = new System.Drawing.Size(776, 426);
            this.tabControlTemps.TabIndex = 2;
            // 
            // tabPageAffTemps
            // 
            this.tabPageAffTemps.Location = new System.Drawing.Point(4, 25);
            this.tabPageAffTemps.Name = "tabPageAffTemps";
            this.tabPageAffTemps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAffTemps.Size = new System.Drawing.Size(768, 397);
            this.tabPageAffTemps.TabIndex = 0;
            this.tabPageAffTemps.Text = "Affichage Temps";
            this.tabPageAffTemps.UseVisualStyleBackColor = true;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(768, 397);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Détails";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // FormTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlTemps);
            this.Name = "FormTemps";
            this.Text = "Formulaire de saisie du temps des Triathlètes";
            this.Load += new System.EventHandler(this.FormTemps_Load);
            this.tabControlTemps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTemps;
        private System.Windows.Forms.TabPage tabPageAffTemps;
        private System.Windows.Forms.TabPage tabPageDetails;
    }
}