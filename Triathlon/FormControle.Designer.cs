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
            this.numTriathlonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prelevement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerifBinding = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtBoxCodeProduit = new System.Windows.Forms.TextBox();
            this.txtBoxIdLabo = new System.Windows.Forms.TextBox();
            this.txtBoxNumTriathlon = new System.Windows.Forms.TextBox();
            this.txtboxPositif = new System.Windows.Forms.TextBox();
            this.txtboxNumTriathlete = new System.Windows.Forms.TextBox();
            this.txtboxTauxPrelev = new System.Windows.Forms.TextBox();
            this.txtboxIdControle = new System.Windows.Forms.TextBox();
            this.lblCodeProduit = new System.Windows.Forms.Label();
            this.lblIdLabo = new System.Windows.Forms.Label();
            this.lblNumTriathlon = new System.Windows.Forms.Label();
            this.lblNumTriathlete = new System.Windows.Forms.Label();
            this.lblPrélèvement = new System.Windows.Forms.Label();
            this.lblVerif = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControleDopage.SuspendLayout();
            this.tabPageAffDopage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDopage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerifBinding)).BeginInit();
            this.tabPageDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControleDopage
            // 
            this.tabControleDopage.Controls.Add(this.tabPageAffDopage);
            this.tabControleDopage.Controls.Add(this.tabPageDetails);
            this.tabControleDopage.Location = new System.Drawing.Point(12, 12);
            this.tabControleDopage.Name = "tabControleDopage";
            this.tabControleDopage.SelectedIndex = 0;
            this.tabControleDopage.Size = new System.Drawing.Size(776, 426);
            this.tabControleDopage.TabIndex = 0;
            // 
            // tabPageAffDopage
            // 
            this.tabPageAffDopage.Controls.Add(this.dataGridDopage);
            this.tabPageAffDopage.Location = new System.Drawing.Point(4, 25);
            this.tabPageAffDopage.Name = "tabPageAffDopage";
            this.tabPageAffDopage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAffDopage.Size = new System.Drawing.Size(768, 397);
            this.tabPageAffDopage.TabIndex = 0;
            this.tabPageAffDopage.Text = "Affichage Contrôle";
            this.tabPageAffDopage.UseVisualStyleBackColor = true;
            // 
            // dataGridDopage
            // 
            this.dataGridDopage.AutoGenerateColumns = false;
            this.dataGridDopage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDopage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numTriathlonDataGridViewTextBoxColumn,
            this.INSCRIPTION,
            this.numDossard,
            this.codeProduit,
            this.prelevement,
            this.PRODUIT});
            this.dataGridDopage.DataSource = this.VerifBinding;
            this.dataGridDopage.Location = new System.Drawing.Point(6, 7);
            this.dataGridDopage.Name = "dataGridDopage";
            this.dataGridDopage.RowHeadersWidth = 51;
            this.dataGridDopage.RowTemplate.Height = 24;
            this.dataGridDopage.Size = new System.Drawing.Size(755, 384);
            this.dataGridDopage.TabIndex = 0;
            // 
            // numTriathlonDataGridViewTextBoxColumn
            // 
            this.numTriathlonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numTriathlonDataGridViewTextBoxColumn.DataPropertyName = "numTriathlon";
            this.numTriathlonDataGridViewTextBoxColumn.HeaderText = "Triathlon";
            this.numTriathlonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numTriathlonDataGridViewTextBoxColumn.Name = "numTriathlonDataGridViewTextBoxColumn";
            this.numTriathlonDataGridViewTextBoxColumn.Width = 88;
            // 
            // INSCRIPTION
            // 
            this.INSCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.INSCRIPTION.DataPropertyName = "INSCRIPTION";
            this.INSCRIPTION.HeaderText = "Triathlète";
            this.INSCRIPTION.MinimumWidth = 6;
            this.INSCRIPTION.Name = "INSCRIPTION";
            this.INSCRIPTION.Width = 92;
            // 
            // numDossard
            // 
            this.numDossard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numDossard.DataPropertyName = "numDossard";
            this.numDossard.HeaderText = "Dossard";
            this.numDossard.MinimumWidth = 6;
            this.numDossard.Name = "numDossard";
            this.numDossard.Width = 88;
            // 
            // codeProduit
            // 
            this.codeProduit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codeProduit.DataPropertyName = "codeProduit";
            this.codeProduit.HeaderText = "Produit";
            this.codeProduit.MinimumWidth = 6;
            this.codeProduit.Name = "codeProduit";
            this.codeProduit.Width = 78;
            // 
            // prelevement
            // 
            this.prelevement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prelevement.DataPropertyName = "prelevement";
            this.prelevement.HeaderText = "Prelevement";
            this.prelevement.MinimumWidth = 6;
            this.prelevement.Name = "prelevement";
            this.prelevement.Width = 112;
            // 
            // PRODUIT
            // 
            this.PRODUIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PRODUIT.DataPropertyName = "PRODUIT";
            this.PRODUIT.HeaderText = "Produit";
            this.PRODUIT.MinimumWidth = 6;
            this.PRODUIT.Name = "PRODUIT";
            this.PRODUIT.Width = 78;
            // 
            // VerifBinding
            // 
            this.VerifBinding.DataSource = typeof(Triathlon.VERIFIER);
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.btnSupprimer);
            this.tabPageDetails.Controls.Add(this.btnAnnuler);
            this.tabPageDetails.Controls.Add(this.btnValider);
            this.tabPageDetails.Controls.Add(this.txtBoxCodeProduit);
            this.tabPageDetails.Controls.Add(this.txtBoxIdLabo);
            this.tabPageDetails.Controls.Add(this.txtBoxNumTriathlon);
            this.tabPageDetails.Controls.Add(this.txtboxPositif);
            this.tabPageDetails.Controls.Add(this.txtboxNumTriathlete);
            this.tabPageDetails.Controls.Add(this.txtboxTauxPrelev);
            this.tabPageDetails.Controls.Add(this.txtboxIdControle);
            this.tabPageDetails.Controls.Add(this.lblCodeProduit);
            this.tabPageDetails.Controls.Add(this.lblIdLabo);
            this.tabPageDetails.Controls.Add(this.lblNumTriathlon);
            this.tabPageDetails.Controls.Add(this.lblNumTriathlete);
            this.tabPageDetails.Controls.Add(this.lblPrélèvement);
            this.tabPageDetails.Controls.Add(this.lblVerif);
            this.tabPageDetails.Controls.Add(this.lblId);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(768, 397);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Détails";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimer.Location = new System.Drawing.Point(561, 111);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 52);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Location = new System.Drawing.Point(621, 44);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(92, 51);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.PaleGreen;
            this.btnValider.Location = new System.Drawing.Point(501, 45);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(96, 50);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // txtBoxCodeProduit
            // 
            this.txtBoxCodeProduit.Location = new System.Drawing.Point(294, 247);
            this.txtBoxCodeProduit.Name = "txtBoxCodeProduit";
            this.txtBoxCodeProduit.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCodeProduit.TabIndex = 13;
            // 
            // txtBoxIdLabo
            // 
            this.txtBoxIdLabo.Location = new System.Drawing.Point(294, 208);
            this.txtBoxIdLabo.Name = "txtBoxIdLabo";
            this.txtBoxIdLabo.Size = new System.Drawing.Size(100, 22);
            this.txtBoxIdLabo.TabIndex = 12;
            // 
            // txtBoxNumTriathlon
            // 
            this.txtBoxNumTriathlon.Location = new System.Drawing.Point(294, 173);
            this.txtBoxNumTriathlon.Name = "txtBoxNumTriathlon";
            this.txtBoxNumTriathlon.Size = new System.Drawing.Size(100, 22);
            this.txtBoxNumTriathlon.TabIndex = 11;
            // 
            // txtboxPositif
            // 
            this.txtboxPositif.Location = new System.Drawing.Point(294, 112);
            this.txtboxPositif.Name = "txtboxPositif";
            this.txtboxPositif.Size = new System.Drawing.Size(100, 22);
            this.txtboxPositif.TabIndex = 10;
            // 
            // txtboxNumTriathlete
            // 
            this.txtboxNumTriathlete.Location = new System.Drawing.Point(294, 144);
            this.txtboxNumTriathlete.Name = "txtboxNumTriathlete";
            this.txtboxNumTriathlete.Size = new System.Drawing.Size(100, 22);
            this.txtboxNumTriathlete.TabIndex = 9;
            // 
            // txtboxTauxPrelev
            // 
            this.txtboxTauxPrelev.Location = new System.Drawing.Point(294, 76);
            this.txtboxTauxPrelev.Name = "txtboxTauxPrelev";
            this.txtboxTauxPrelev.Size = new System.Drawing.Size(100, 22);
            this.txtboxTauxPrelev.TabIndex = 8;
            // 
            // txtboxIdControle
            // 
            this.txtboxIdControle.Location = new System.Drawing.Point(294, 42);
            this.txtboxIdControle.Name = "txtboxIdControle";
            this.txtboxIdControle.Size = new System.Drawing.Size(100, 22);
            this.txtboxIdControle.TabIndex = 7;
            // 
            // lblCodeProduit
            // 
            this.lblCodeProduit.AutoSize = true;
            this.lblCodeProduit.Location = new System.Drawing.Point(150, 250);
            this.lblCodeProduit.Name = "lblCodeProduit";
            this.lblCodeProduit.Size = new System.Drawing.Size(138, 16);
            this.lblCodeProduit.TabIndex = 6;
            this.lblCodeProduit.Text = "Code produit dépisté :";
            // 
            // lblIdLabo
            // 
            this.lblIdLabo.AutoSize = true;
            this.lblIdLabo.Location = new System.Drawing.Point(192, 211);
            this.lblIdLabo.Name = "lblIdLabo";
            this.lblIdLabo.Size = new System.Drawing.Size(96, 16);
            this.lblIdLabo.TabIndex = 5;
            this.lblIdLabo.Text = "Id Laboratoire :";
            // 
            // lblNumTriathlon
            // 
            this.lblNumTriathlon.AutoSize = true;
            this.lblNumTriathlon.Location = new System.Drawing.Point(153, 176);
            this.lblNumTriathlon.Name = "lblNumTriathlon";
            this.lblNumTriathlon.Size = new System.Drawing.Size(135, 16);
            this.lblNumTriathlon.TabIndex = 4;
            this.lblNumTriathlon.Text = "Numéro de Triathlon :";
            // 
            // lblNumTriathlete
            // 
            this.lblNumTriathlete.AutoSize = true;
            this.lblNumTriathlete.Location = new System.Drawing.Point(149, 147);
            this.lblNumTriathlete.Name = "lblNumTriathlete";
            this.lblNumTriathlete.Size = new System.Drawing.Size(139, 16);
            this.lblNumTriathlete.TabIndex = 3;
            this.lblNumTriathlete.Text = "Numéro de Triathlète :";
            // 
            // lblPrélèvement
            // 
            this.lblPrélèvement.AutoSize = true;
            this.lblPrélèvement.Location = new System.Drawing.Point(147, 79);
            this.lblPrélèvement.Name = "lblPrélèvement";
            this.lblPrélèvement.Size = new System.Drawing.Size(141, 16);
            this.lblPrélèvement.TabIndex = 2;
            this.lblPrélèvement.Text = "Taux de Prélèvement :";
            // 
            // lblVerif
            // 
            this.lblVerif.AutoSize = true;
            this.lblVerif.Location = new System.Drawing.Point(239, 115);
            this.lblVerif.Name = "lblVerif";
            this.lblVerif.Size = new System.Drawing.Size(49, 16);
            this.lblVerif.TabIndex = 1;
            this.lblVerif.Text = "Positif :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(211, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(77, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id Contrôle :";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "INSCRIPTION";
            this.dataGridViewTextBoxColumn1.HeaderText = "Triathlète";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PRODUIT";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produit";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // FormControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControleDopage);
            this.Name = "FormControle";
            this.Text = "Contrôle Anti-Dopage";
            this.Load += new System.EventHandler(this.FormControle_Load);
            this.tabControleDopage.ResumeLayout(false);
            this.tabPageAffDopage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDopage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerifBinding)).EndInit();
            this.tabPageDetails.ResumeLayout(false);
            this.tabPageDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControleDopage;
        private System.Windows.Forms.TabPage tabPageAffDopage;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.DataGridView dataGridDopage;
        private System.Windows.Forms.Label lblNumTriathlete;
        private System.Windows.Forms.Label lblPrélèvement;
        private System.Windows.Forms.Label lblVerif;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCodeProduit;
        private System.Windows.Forms.Label lblIdLabo;
        private System.Windows.Forms.Label lblNumTriathlon;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtBoxCodeProduit;
        private System.Windows.Forms.TextBox txtBoxIdLabo;
        private System.Windows.Forms.TextBox txtBoxNumTriathlon;
        private System.Windows.Forms.TextBox txtboxPositif;
        private System.Windows.Forms.TextBox txtboxNumTriathlete;
        private System.Windows.Forms.TextBox txtboxTauxPrelev;
        private System.Windows.Forms.TextBox txtboxIdControle;
        private System.Windows.Forms.BindingSource VerifBinding;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTriathlonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prelevement;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}