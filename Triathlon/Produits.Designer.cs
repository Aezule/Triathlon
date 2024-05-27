namespace Triathlon
{
    partial class Produits
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tauxMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceProduits = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddProduit = new System.Windows.Forms.Button();
            this.btnSuppProduit = new System.Windows.Forms.Button();
            this.tabControlProduits = new System.Windows.Forms.TabControl();
            this.tabPageProduits = new System.Windows.Forms.TabPage();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTaux = new System.Windows.Forms.TextBox();
            this.textBoxLib = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduits)).BeginInit();
            this.tabControlProduits.SuspendLayout();
            this.tabPageProduits.SuspendLayout();
            this.tabPageDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeProduitDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.tauxMaxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceProduits;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(537, 521);
            this.dataGridView1.TabIndex = 0;
            // 
            // codeProduitDataGridViewTextBoxColumn
            // 
            this.codeProduitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeProduitDataGridViewTextBoxColumn.DataPropertyName = "codeProduit";
            this.codeProduitDataGridViewTextBoxColumn.HeaderText = "codeProduit";
            this.codeProduitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeProduitDataGridViewTextBoxColumn.Name = "codeProduitDataGridViewTextBoxColumn";
            this.codeProduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "libelle";
            this.libelleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tauxMaxDataGridViewTextBoxColumn
            // 
            this.tauxMaxDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tauxMaxDataGridViewTextBoxColumn.DataPropertyName = "tauxMax";
            this.tauxMaxDataGridViewTextBoxColumn.HeaderText = "tauxMax";
            this.tauxMaxDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tauxMaxDataGridViewTextBoxColumn.Name = "tauxMaxDataGridViewTextBoxColumn";
            this.tauxMaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceProduits
            // 
            this.bindingSourceProduits.DataSource = typeof(Triathlon.PRODUIT);
            // 
            // btnAddProduit
            // 
            this.btnAddProduit.Location = new System.Drawing.Point(563, 21);
            this.btnAddProduit.Name = "btnAddProduit";
            this.btnAddProduit.Size = new System.Drawing.Size(159, 45);
            this.btnAddProduit.TabIndex = 1;
            this.btnAddProduit.Text = "Ajouter";
            this.btnAddProduit.UseVisualStyleBackColor = true;
            this.btnAddProduit.Click += new System.EventHandler(this.btnAddProduit_Click);
            // 
            // btnSuppProduit
            // 
            this.btnSuppProduit.Location = new System.Drawing.Point(563, 87);
            this.btnSuppProduit.Name = "btnSuppProduit";
            this.btnSuppProduit.Size = new System.Drawing.Size(159, 48);
            this.btnSuppProduit.TabIndex = 2;
            this.btnSuppProduit.Text = "Supprimer";
            this.btnSuppProduit.UseVisualStyleBackColor = true;
            this.btnSuppProduit.Click += new System.EventHandler(this.btnSuppProduit_Click);
            // 
            // tabControlProduits
            // 
            this.tabControlProduits.Controls.Add(this.tabPageProduits);
            this.tabControlProduits.Controls.Add(this.tabPageDetails);
            this.tabControlProduits.Location = new System.Drawing.Point(12, 12);
            this.tabControlProduits.Name = "tabControlProduits";
            this.tabControlProduits.SelectedIndex = 0;
            this.tabControlProduits.Size = new System.Drawing.Size(1060, 626);
            this.tabControlProduits.TabIndex = 3;
            this.tabControlProduits.TabIndexChanged += new System.EventHandler(this.tabControlProduits_TabIndexChanged);
            // 
            // tabPageProduits
            // 
            this.tabPageProduits.Controls.Add(this.dataGridView1);
            this.tabPageProduits.Controls.Add(this.btnSuppProduit);
            this.tabPageProduits.Controls.Add(this.btnAddProduit);
            this.tabPageProduits.Location = new System.Drawing.Point(4, 29);
            this.tabPageProduits.Name = "tabPageProduits";
            this.tabPageProduits.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduits.Size = new System.Drawing.Size(1052, 593);
            this.tabPageProduits.TabIndex = 0;
            this.tabPageProduits.Text = "Produits";
            this.tabPageProduits.UseVisualStyleBackColor = true;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.btnModifier);
            this.tabPageDetails.Controls.Add(this.btnValider);
            this.tabPageDetails.Controls.Add(this.btnAnnuler);
            this.tabPageDetails.Controls.Add(this.label3);
            this.tabPageDetails.Controls.Add(this.label2);
            this.tabPageDetails.Controls.Add(this.label1);
            this.tabPageDetails.Controls.Add(this.textBoxTaux);
            this.tabPageDetails.Controls.Add(this.textBoxLib);
            this.tabPageDetails.Controls.Add(this.textBoxCode);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 29);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(1052, 593);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Détails";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(437, 188);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(151, 47);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(437, 248);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(151, 47);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(437, 310);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(150, 47);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taux Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Libelle";
            // 
            // textBoxTaux
            // 
            this.textBoxTaux.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProduits, "tauxMax", true));
            this.textBoxTaux.Location = new System.Drawing.Point(136, 331);
            this.textBoxTaux.Name = "textBoxTaux";
            this.textBoxTaux.Size = new System.Drawing.Size(250, 26);
            this.textBoxTaux.TabIndex = 2;
            // 
            // textBoxLib
            // 
            this.textBoxLib.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProduits, "libelle", true));
            this.textBoxLib.Location = new System.Drawing.Point(136, 269);
            this.textBoxLib.Name = "textBoxLib";
            this.textBoxLib.Size = new System.Drawing.Size(250, 26);
            this.textBoxLib.TabIndex = 1;
            // 
            // textBoxCode
            // 
            this.textBoxCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProduits, "codeProduit", true));
            this.textBoxCode.Location = new System.Drawing.Point(136, 209);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(250, 26);
            this.textBoxCode.TabIndex = 0;
            // 
            // Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 650);
            this.Controls.Add(this.tabControlProduits);
            this.Name = "Produits";
            this.Text = "Produits";
            this.Load += new System.EventHandler(this.Produits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduits)).EndInit();
            this.tabControlProduits.ResumeLayout(false);
            this.tabPageProduits.ResumeLayout(false);
            this.tabPageDetails.ResumeLayout(false);
            this.tabPageDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeProduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tauxMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceProduits;
        private System.Windows.Forms.Button btnAddProduit;
        private System.Windows.Forms.Button btnSuppProduit;
        private System.Windows.Forms.TabControl tabControlProduits;
        private System.Windows.Forms.TabPage tabPageProduits;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.TextBox textBoxTaux;
        private System.Windows.Forms.TextBox textBoxLib;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
    }
}