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
            this.lblTriathlon = new System.Windows.Forms.Label();
            this.tabPageSuppInsc = new System.Windows.Forms.TabPage();
            this.lbltriathlète = new System.Windows.Forms.Label();
            this.dtPickerDate = new System.Windows.Forms.DateTimePicker();
            this.txtTriathlon = new System.Windows.Forms.MaskedTextBox();
            this.txtTriathlète = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tabControlInscription.SuspendLayout();
            this.tabPageAjoutInsc.SuspendLayout();
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
            this.tabPageAjoutInsc.Controls.Add(this.btnAjouter);
            this.tabPageAjoutInsc.Controls.Add(this.lblDate);
            this.tabPageAjoutInsc.Controls.Add(this.txtTriathlète);
            this.tabPageAjoutInsc.Controls.Add(this.txtTriathlon);
            this.tabPageAjoutInsc.Controls.Add(this.dtPickerDate);
            this.tabPageAjoutInsc.Controls.Add(this.lbltriathlète);
            this.tabPageAjoutInsc.Controls.Add(this.lblTriathlon);
            this.tabPageAjoutInsc.Location = new System.Drawing.Point(4, 25);
            this.tabPageAjoutInsc.Name = "tabPageAjoutInsc";
            this.tabPageAjoutInsc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAjoutInsc.Size = new System.Drawing.Size(767, 396);
            this.tabPageAjoutInsc.TabIndex = 0;
            this.tabPageAjoutInsc.Text = "Ajouter une Inscription";
            this.tabPageAjoutInsc.UseVisualStyleBackColor = true;
            // 
            // lblTriathlon
            // 
            this.lblTriathlon.AutoSize = true;
            this.lblTriathlon.Location = new System.Drawing.Point(61, 35);
            this.lblTriathlon.Name = "lblTriathlon";
            this.lblTriathlon.Size = new System.Drawing.Size(128, 16);
            this.lblTriathlon.TabIndex = 0;
            this.lblTriathlon.Text = "Numéro du triathlon :";
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
            // lbltriathlète
            // 
            this.lbltriathlète.AutoSize = true;
            this.lbltriathlète.Location = new System.Drawing.Point(61, 84);
            this.lbltriathlète.Name = "lbltriathlète";
            this.lbltriathlète.Size = new System.Drawing.Size(132, 16);
            this.lbltriathlète.TabIndex = 1;
            this.lbltriathlète.Text = "Numéro du triathlète :";
            // 
            // dtPickerDate
            // 
            this.dtPickerDate.Location = new System.Drawing.Point(200, 154);
            this.dtPickerDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtPickerDate.Name = "dtPickerDate";
            this.dtPickerDate.Size = new System.Drawing.Size(200, 22);
            this.dtPickerDate.TabIndex = 2;
            // 
            // txtTriathlon
            // 
            this.txtTriathlon.Location = new System.Drawing.Point(200, 32);
            this.txtTriathlon.Mask = "9999";
            this.txtTriathlon.Name = "txtTriathlon";
            this.txtTriathlon.Size = new System.Drawing.Size(100, 22);
            this.txtTriathlon.TabIndex = 3;
            // 
            // txtTriathlète
            // 
            this.txtTriathlète.Location = new System.Drawing.Point(200, 81);
            this.txtTriathlète.Mask = "9999";
            this.txtTriathlète.Name = "txtTriathlète";
            this.txtTriathlète.Size = new System.Drawing.Size(100, 22);
            this.txtTriathlète.TabIndex = 4;
            this.txtTriathlète.ValidatingType = typeof(int);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(61, 159);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(116, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date d\'inscription :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAjouter.Location = new System.Drawing.Point(257, 286);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(270, 57);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter :)";
            this.btnAjouter.UseVisualStyleBackColor = false;
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
            this.tabPageAjoutInsc.ResumeLayout(false);
            this.tabPageAjoutInsc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInscription;
        private System.Windows.Forms.TabPage tabPageAjoutInsc;
        private System.Windows.Forms.TabPage tabPageSuppInsc;
        private System.Windows.Forms.Label lblTriathlon;
        private System.Windows.Forms.Label lbltriathlète;
        private System.Windows.Forms.MaskedTextBox txtTriathlon;
        private System.Windows.Forms.DateTimePicker dtPickerDate;
        private System.Windows.Forms.MaskedTextBox txtTriathlète;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAjouter;
    }
}

