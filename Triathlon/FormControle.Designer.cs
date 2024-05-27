namespace Triathlon
{
    partial class FormControle
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
            this.components = new System.ComponentModel.Container();
            this.tabControleDopage = new System.Windows.Forms.TabControl();
            this.tabPageAffDopage = new System.Windows.Forms.TabPage();
            this.dataGridDopage = new System.Windows.Forms.DataGridView();
            this.numDossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prelevement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.comboTriathlete = new System.Windows.Forms.ComboBox();
            this.comboTriathlon = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtBoxCodeProduit = new System.Windows.Forms.TextBox();
            this.txtboxTauxPrelev = new System.Windows.Forms.TextBox();
            this.lblCodeProduit = new System.Windows.Forms.Label();
            this.lblNumTriathlon = new System.Windows.Forms.Label();
            this.lblNumTriathlete = new System.Windows.Forms.Label();
            this.lblPrélèvement = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjoutCT = new System.Windows.Forms.Button();
            this.numTriathlonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerifBinding = new System.Windows.Forms.BindingSource(this.components);
            this.tabControleDopage.SuspendLayout();
            this.tabPageAffDopage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDopage)).BeginInit();
            this.tabPageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerifBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControleDopage
            // 
            this.tabControleDopage.Controls.Add(this.tabPageAffDopage);
            this.tabControleDopage.Controls.Add(this.tabPageDetails);
            this.tabControleDopage.Location = new System.Drawing.Point(14, 15);
            this.tabControleDopage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControleDopage.Name = "tabControleDopage";
            this.tabControleDopage.SelectedIndex = 0;
            this.tabControleDopage.Size = new System.Drawing.Size(873, 485);
            this.tabControleDopage.TabIndex = 0;
            this.tabControleDopage.SelectedIndexChanged += new System.EventHandler(this.tabControleDopage_SelectedIndexChanged);
            // 
            // tabPageAffDopage
            // 
            this.tabPageAffDopage.Controls.Add(this.dataGridDopage);
            this.tabPageAffDopage.Location = new System.Drawing.Point(4, 29);
            this.tabPageAffDopage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAffDopage.Name = "tabPageAffDopage";
            this.tabPageAffDopage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAffDopage.Size = new System.Drawing.Size(865, 452);
            this.tabPageAffDopage.TabIndex = 0;
            this.tabPageAffDopage.Text = "Affichage Contrôle";
            this.tabPageAffDopage.UseVisualStyleBackColor = true;
            // 
            // dataGridDopage
            // 
            this.dataGridDopage.AllowUserToAddRows = false;
            this.dataGridDopage.AllowUserToDeleteRows = false;
            this.dataGridDopage.AutoGenerateColumns = false;
            this.dataGridDopage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDopage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDossard,
            this.numTriathlonDataGridViewTextBoxColumn,
            this.codeProduit,
            this.prelevement});
            this.dataGridDopage.DataSource = this.VerifBinding;
            this.dataGridDopage.Location = new System.Drawing.Point(7, 9);
            this.dataGridDopage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridDopage.Name = "dataGridDopage";
            this.dataGridDopage.RowHeadersWidth = 51;
            this.dataGridDopage.RowTemplate.Height = 24;
            this.dataGridDopage.Size = new System.Drawing.Size(849, 480);
            this.dataGridDopage.TabIndex = 0;
            // 
            // numDossard
            // 
            this.numDossard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numDossard.DataPropertyName = "numDossard";
            this.numDossard.HeaderText = "Dossard";
            this.numDossard.MinimumWidth = 6;
            this.numDossard.Name = "numDossard";
            this.numDossard.Width = 105;
            // 
            // codeProduit
            // 
            this.codeProduit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codeProduit.DataPropertyName = "codeProduit";
            this.codeProduit.HeaderText = "Produit";
            this.codeProduit.MinimumWidth = 6;
            this.codeProduit.Name = "codeProduit";
            this.codeProduit.Width = 95;
            // 
            // prelevement
            // 
            this.prelevement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prelevement.DataPropertyName = "prelevement";
            this.prelevement.HeaderText = "Prelevement";
            this.prelevement.MinimumWidth = 6;
            this.prelevement.Name = "prelevement";
            this.prelevement.Width = 133;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.comboTriathlete);
            this.tabPageDetails.Controls.Add(this.comboTriathlon);
            this.tabPageDetails.Controls.Add(this.btnSupprimer);
            this.tabPageDetails.Controls.Add(this.btnAnnuler);
            this.tabPageDetails.Controls.Add(this.btnValider);
            this.tabPageDetails.Controls.Add(this.txtBoxCodeProduit);
            this.tabPageDetails.Controls.Add(this.txtboxTauxPrelev);
            this.tabPageDetails.Controls.Add(this.lblCodeProduit);
            this.tabPageDetails.Controls.Add(this.lblNumTriathlon);
            this.tabPageDetails.Controls.Add(this.lblNumTriathlete);
            this.tabPageDetails.Controls.Add(this.lblPrélèvement);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 29);
            this.tabPageDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageDetails.Size = new System.Drawing.Size(865, 452);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Détails";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // comboTriathlete
            // 
            this.comboTriathlete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VerifBinding, "numDossard", true));
            this.comboTriathlete.Enabled = false;
            this.comboTriathlete.FormattingEnabled = true;
            this.comboTriathlete.Location = new System.Drawing.Point(332, 172);
            this.comboTriathlete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboTriathlete.Name = "comboTriathlete";
            this.comboTriathlete.Size = new System.Drawing.Size(111, 28);
            this.comboTriathlete.TabIndex = 18;
            this.comboTriathlete.SelectedIndexChanged += new System.EventHandler(this.comboTriathlete_SelectedIndexChanged);
            // 
            // comboTriathlon
            // 
            this.comboTriathlon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VerifBinding, "numTriathlon", true));
            this.comboTriathlon.Enabled = false;
            this.comboTriathlon.FormattingEnabled = true;
            this.comboTriathlon.Location = new System.Drawing.Point(332, 210);
            this.comboTriathlon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboTriathlon.Name = "comboTriathlon";
            this.comboTriathlon.Size = new System.Drawing.Size(244, 28);
            this.comboTriathlon.TabIndex = 17;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimer.Location = new System.Drawing.Point(631, 139);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(110, 65);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Location = new System.Drawing.Point(699, 55);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(104, 64);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.PaleGreen;
            this.btnValider.Location = new System.Drawing.Point(564, 56);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(108, 62);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtBoxCodeProduit
            // 
            this.txtBoxCodeProduit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VerifBinding, "codeProduit", true));
            this.txtBoxCodeProduit.Location = new System.Drawing.Point(331, 251);
            this.txtBoxCodeProduit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCodeProduit.MaxLength = 6;
            this.txtBoxCodeProduit.Name = "txtBoxCodeProduit";
            this.txtBoxCodeProduit.Size = new System.Drawing.Size(112, 26);
            this.txtBoxCodeProduit.TabIndex = 13;
            // 
            // txtboxTauxPrelev
            // 
            this.txtboxTauxPrelev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VerifBinding, "prelevement", true));
            this.txtboxTauxPrelev.Location = new System.Drawing.Point(331, 286);
            this.txtboxTauxPrelev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxTauxPrelev.MaxLength = 2;
            this.txtboxTauxPrelev.Name = "txtboxTauxPrelev";
            this.txtboxTauxPrelev.Size = new System.Drawing.Size(112, 26);
            this.txtboxTauxPrelev.TabIndex = 8;
            // 
            // lblCodeProduit
            // 
            this.lblCodeProduit.AutoSize = true;
            this.lblCodeProduit.Location = new System.Drawing.Point(169, 255);
            this.lblCodeProduit.Name = "lblCodeProduit";
            this.lblCodeProduit.Size = new System.Drawing.Size(164, 20);
            this.lblCodeProduit.TabIndex = 6;
            this.lblCodeProduit.Text = "Code produit dépisté :";
            // 
            // lblNumTriathlon
            // 
            this.lblNumTriathlon.AutoSize = true;
            this.lblNumTriathlon.Location = new System.Drawing.Point(172, 220);
            this.lblNumTriathlon.Name = "lblNumTriathlon";
            this.lblNumTriathlon.Size = new System.Drawing.Size(160, 20);
            this.lblNumTriathlon.TabIndex = 4;
            this.lblNumTriathlon.Text = "Numéro de Triathlon :";
            // 
            // lblNumTriathlete
            // 
            this.lblNumTriathlete.AutoSize = true;
            this.lblNumTriathlete.Location = new System.Drawing.Point(86, 184);
            this.lblNumTriathlete.Name = "lblNumTriathlete";
            this.lblNumTriathlete.Size = new System.Drawing.Size(251, 20);
            this.lblNumTriathlete.TabIndex = 3;
            this.lblNumTriathlete.Text = "Numéro de Dossard du Triathlète :";
            // 
            // lblPrélèvement
            // 
            this.lblPrélèvement.AutoSize = true;
            this.lblPrélèvement.Location = new System.Drawing.Point(165, 290);
            this.lblPrélèvement.Name = "lblPrélèvement";
            this.lblPrélèvement.Size = new System.Drawing.Size(165, 20);
            this.lblPrélèvement.TabIndex = 2;
            this.lblPrélèvement.Text = "Taux de Prélèvement :";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "INSCRIPTION";
            this.dataGridViewTextBoxColumn1.HeaderText = "Triathlète";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PRODUIT";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produit";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // btnAjoutCT
            // 
            this.btnAjoutCT.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAjoutCT.Location = new System.Drawing.Point(280, 509);
            this.btnAjoutCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjoutCT.Name = "btnAjoutCT";
            this.btnAjoutCT.Size = new System.Drawing.Size(332, 39);
            this.btnAjoutCT.TabIndex = 1;
            this.btnAjoutCT.Text = "Ajouter un nouveau Controle";
            this.btnAjoutCT.UseVisualStyleBackColor = false;
            this.btnAjoutCT.Click += new System.EventHandler(this.btnAjoutCT_Click);
            // 
            // numTriathlonDataGridViewTextBoxColumn
            // 
            this.numTriathlonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numTriathlonDataGridViewTextBoxColumn.DataPropertyName = "numTriathlon";
            this.numTriathlonDataGridViewTextBoxColumn.HeaderText = "Triathlon";
            this.numTriathlonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numTriathlonDataGridViewTextBoxColumn.Name = "numTriathlonDataGridViewTextBoxColumn";
            this.numTriathlonDataGridViewTextBoxColumn.Width = 106;
            // 
            // VerifBinding
            // 
            this.VerifBinding.DataSource = typeof(Triathlon.VERIFIER);
            // 
            // FormControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnAjoutCT);
            this.Controls.Add(this.tabControleDopage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormControle";
            this.Text = "Contrôle Anti-Dopage";
            this.Load += new System.EventHandler(this.FormControle_Load);
            this.tabControleDopage.ResumeLayout(false);
            this.tabPageAffDopage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDopage)).EndInit();
            this.tabPageDetails.ResumeLayout(false);
            this.tabPageDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerifBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControleDopage;
        private System.Windows.Forms.TabPage tabPageAffDopage;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.DataGridView dataGridDopage;
        private System.Windows.Forms.Label lblNumTriathlete;
        private System.Windows.Forms.Label lblPrélèvement;
        private System.Windows.Forms.Label lblCodeProduit;
        private System.Windows.Forms.Label lblNumTriathlon;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtBoxCodeProduit;
        private System.Windows.Forms.TextBox txtboxTauxPrelev;
        private System.Windows.Forms.BindingSource VerifBinding;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnAjoutCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTriathlonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prelevement;
        private System.Windows.Forms.ComboBox comboTriathlon;
        private System.Windows.Forms.ComboBox comboTriathlete;
    }
}