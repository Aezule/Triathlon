namespace Triathlon
{
    partial class FormInscription
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlInscription = new System.Windows.Forms.TabControl();
            this.tabPageAjoutInsc = new System.Windows.Forms.TabPage();
            this.tabPageSuppInsc = new System.Windows.Forms.TabPage();
            this.tabControlInscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlInscription
            // 
            this.tabControlInscription.Controls.Add(this.tabPageAjoutInsc);
            this.tabControlInscription.Controls.Add(this.tabPageSuppInsc);
            this.tabControlInscription.Location = new System.Drawing.Point(13, 13);
            this.tabControlInscription.Name = "tabControlInscription";
            this.tabControlInscription.SelectedIndex = 0;
            this.tabControlInscription.Size = new System.Drawing.Size(775, 425);
            this.tabControlInscription.TabIndex = 0;
            // 
            // tabPageAjoutInsc
            // 
            this.tabPageAjoutInsc.Location = new System.Drawing.Point(4, 25);
            this.tabPageAjoutInsc.Name = "tabPageAjoutInsc";
            this.tabPageAjoutInsc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAjoutInsc.Size = new System.Drawing.Size(767, 396);
            this.tabPageAjoutInsc.TabIndex = 0;
            this.tabPageAjoutInsc.Text = "Ajouter une Inscription";
            this.tabPageAjoutInsc.UseVisualStyleBackColor = true;
            // 
            // tabPageSuppInsc
            // 
            this.tabPageSuppInsc.Location = new System.Drawing.Point(4, 25);
            this.tabPageSuppInsc.Name = "tabPageSuppInsc";
            this.tabPageSuppInsc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSuppInsc.Size = new System.Drawing.Size(767, 396);
            this.tabPageSuppInsc.TabIndex = 1;
            this.tabPageSuppInsc.Text = "Supprimer une Inscription";
            this.tabPageSuppInsc.UseVisualStyleBackColor = true;
            // 
            // FormInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlInscription);
            this.Name = "FormInscription";
            this.Text = "Inscription des Triathlètes";
            this.tabControlInscription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInscription;
        private System.Windows.Forms.TabPage tabPageAjoutInsc;
        private System.Windows.Forms.TabPage tabPageSuppInsc;
    }
}

