namespace Triathlon
{
    partial class FormTriathlon
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
            this.tabControlTriathlon = new System.Windows.Forms.TabControl();
            this.tabPageAffTriathlon = new System.Windows.Forms.TabPage();
            this.dataGridTriathlon = new System.Windows.Forms.DataGridView();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.txtNomTri = new System.Windows.Forms.TextBox();
            this.txtNumTri = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.numTriathlonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTriathlonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSCRIPTIONsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPETRIATHLONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriathlonBinding = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlTriathlon.SuspendLayout();
            this.tabPageAffTriathlon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTriathlon)).BeginInit();
            this.tabPageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriathlonBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTriathlon
            // 
            this.tabControlTriathlon.Controls.Add(this.tabPageAffTriathlon);
            this.tabControlTriathlon.Controls.Add(this.tabPageDetails);
            this.tabControlTriathlon.Location = new System.Drawing.Point(12, 12);
            this.tabControlTriathlon.Name = "tabControlTriathlon";
            this.tabControlTriathlon.SelectedIndex = 0;
            this.tabControlTriathlon.Size = new System.Drawing.Size(776, 426);
            this.tabControlTriathlon.TabIndex = 1;
            this.tabControlTriathlon.SelectedIndexChanged += new System.EventHandler(this.tabControlTriathlon_SelectedIndexChanged);
            // 
            // tabPageAffTriathlon
            // 
            this.tabPageAffTriathlon.Controls.Add(this.dataGridTriathlon);
            this.tabPageAffTriathlon.Location = new System.Drawing.Point(4, 25);
            this.tabPageAffTriathlon.Name = "tabPageAffTriathlon";
            this.tabPageAffTriathlon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAffTriathlon.Size = new System.Drawing.Size(768, 397);
            this.tabPageAffTriathlon.TabIndex = 0;
            this.tabPageAffTriathlon.Text = "Affichage Triathlon";
            this.tabPageAffTriathlon.UseVisualStyleBackColor = true;
            // 
            // dataGridTriathlon
            // 
            this.dataGridTriathlon.AllowUserToAddRows = false;
            this.dataGridTriathlon.AllowUserToDeleteRows = false;
            this.dataGridTriathlon.AutoGenerateColumns = false;
            this.dataGridTriathlon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTriathlon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numTriathlonDataGridViewTextBoxColumn,
            this.lieuDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.dateTriathlonDataGridViewTextBoxColumn,
            this.codeTypeDataGridViewTextBoxColumn,
            this.iNSCRIPTIONsDataGridViewTextBoxColumn,
            this.tYPETRIATHLONDataGridViewTextBoxColumn});
            this.dataGridTriathlon.DataSource = this.TriathlonBinding;
            this.dataGridTriathlon.Location = new System.Drawing.Point(6, 6);
            this.dataGridTriathlon.MultiSelect = false;
            this.dataGridTriathlon.Name = "dataGridTriathlon";
            this.dataGridTriathlon.ReadOnly = true;
            this.dataGridTriathlon.RowHeadersWidth = 51;
            this.dataGridTriathlon.RowTemplate.Height = 24;
            this.dataGridTriathlon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTriathlon.Size = new System.Drawing.Size(756, 385);
            this.dataGridTriathlon.TabIndex = 1;
            this.dataGridTriathlon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridTriathlon_CellMouseClick);
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.txtDate);
            this.tabPageDetails.Controls.Add(this.txtLieu);
            this.tabPageDetails.Controls.Add(this.txtNomTri);
            this.tabPageDetails.Controls.Add(this.txtNumTri);
            this.tabPageDetails.Controls.Add(this.btnAnnuler);
            this.tabPageDetails.Controls.Add(this.btnSupprimer);
            this.tabPageDetails.Controls.Add(this.btnValider);
            this.tabPageDetails.Controls.Add(this.lblDate);
            this.tabPageDetails.Controls.Add(this.lblLieu);
            this.tabPageDetails.Controls.Add(this.lblNom);
            this.tabPageDetails.Controls.Add(this.lblNumero);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(768, 397);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Détails";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TriathlonBinding, "dateTriathlon", true));
            this.txtDate.Location = new System.Drawing.Point(257, 181);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(188, 22);
            this.txtDate.TabIndex = 10;
            // 
            // txtLieu
            // 
            this.txtLieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TriathlonBinding, "lieu", true));
            this.txtLieu.Location = new System.Drawing.Point(257, 139);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(188, 22);
            this.txtLieu.TabIndex = 9;
            // 
            // txtNomTri
            // 
            this.txtNomTri.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TriathlonBinding, "nom", true));
            this.txtNomTri.Location = new System.Drawing.Point(257, 95);
            this.txtNomTri.Name = "txtNomTri";
            this.txtNomTri.Size = new System.Drawing.Size(256, 22);
            this.txtNomTri.TabIndex = 8;
            // 
            // txtNumTri
            // 
            this.txtNumTri.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TriathlonBinding, "numTriathlon", true));
            this.txtNumTri.Enabled = false;
            this.txtNumTri.Location = new System.Drawing.Point(257, 52);
            this.txtNumTri.Name = "txtNumTri";
            this.txtNumTri.Size = new System.Drawing.Size(64, 22);
            this.txtNumTri.TabIndex = 7;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Location = new System.Drawing.Point(357, 270);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(106, 32);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupprimer.Location = new System.Drawing.Point(540, 270);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(112, 32);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Lime;
            this.btnValider.Location = new System.Drawing.Point(206, 270);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(115, 32);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(111, 188);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(139, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date de déroulement :";
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Location = new System.Drawing.Point(124, 146);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(126, 16);
            this.lblLieu.TabIndex = 2;
            this.lblLieu.Text = "Lieu d\'organisation :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(135, 101);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(115, 16);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom du Triathlon :";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(134, 58);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(116, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numéro Triathlon :";
            // 
            // numTriathlonDataGridViewTextBoxColumn
            // 
            this.numTriathlonDataGridViewTextBoxColumn.DataPropertyName = "numTriathlon";
            this.numTriathlonDataGridViewTextBoxColumn.HeaderText = "numTriathlon";
            this.numTriathlonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numTriathlonDataGridViewTextBoxColumn.Name = "numTriathlonDataGridViewTextBoxColumn";
            this.numTriathlonDataGridViewTextBoxColumn.ReadOnly = true;
            this.numTriathlonDataGridViewTextBoxColumn.Width = 125;
            // 
            // lieuDataGridViewTextBoxColumn
            // 
            this.lieuDataGridViewTextBoxColumn.DataPropertyName = "lieu";
            this.lieuDataGridViewTextBoxColumn.HeaderText = "lieu";
            this.lieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lieuDataGridViewTextBoxColumn.Name = "lieuDataGridViewTextBoxColumn";
            this.lieuDataGridViewTextBoxColumn.ReadOnly = true;
            this.lieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateTriathlonDataGridViewTextBoxColumn
            // 
            this.dateTriathlonDataGridViewTextBoxColumn.DataPropertyName = "dateTriathlon";
            this.dateTriathlonDataGridViewTextBoxColumn.HeaderText = "dateTriathlon";
            this.dateTriathlonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateTriathlonDataGridViewTextBoxColumn.Name = "dateTriathlonDataGridViewTextBoxColumn";
            this.dateTriathlonDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTriathlonDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeTypeDataGridViewTextBoxColumn
            // 
            this.codeTypeDataGridViewTextBoxColumn.DataPropertyName = "codeType";
            this.codeTypeDataGridViewTextBoxColumn.HeaderText = "codeType";
            this.codeTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeTypeDataGridViewTextBoxColumn.Name = "codeTypeDataGridViewTextBoxColumn";
            this.codeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // iNSCRIPTIONsDataGridViewTextBoxColumn
            // 
            this.iNSCRIPTIONsDataGridViewTextBoxColumn.DataPropertyName = "INSCRIPTIONs";
            this.iNSCRIPTIONsDataGridViewTextBoxColumn.HeaderText = "INSCRIPTIONs";
            this.iNSCRIPTIONsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNSCRIPTIONsDataGridViewTextBoxColumn.Name = "iNSCRIPTIONsDataGridViewTextBoxColumn";
            this.iNSCRIPTIONsDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNSCRIPTIONsDataGridViewTextBoxColumn.Width = 125;
            // 
            // tYPETRIATHLONDataGridViewTextBoxColumn
            // 
            this.tYPETRIATHLONDataGridViewTextBoxColumn.DataPropertyName = "TYPE_TRIATHLON";
            this.tYPETRIATHLONDataGridViewTextBoxColumn.HeaderText = "TYPE_TRIATHLON";
            this.tYPETRIATHLONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tYPETRIATHLONDataGridViewTextBoxColumn.Name = "tYPETRIATHLONDataGridViewTextBoxColumn";
            this.tYPETRIATHLONDataGridViewTextBoxColumn.ReadOnly = true;
            this.tYPETRIATHLONDataGridViewTextBoxColumn.Width = 125;
            // 
            // TriathlonBinding
            // 
            this.TriathlonBinding.DataSource = typeof(Triathlon.TRIATHLON);
            // 
            // FormTriathlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlTriathlon);
            this.Name = "FormTriathlon";
            this.Text = "Gestionnaire des Triathlon";
            this.Load += new System.EventHandler(this.FormTriathlon_Load);
            this.tabControlTriathlon.ResumeLayout(false);
            this.tabPageAffTriathlon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTriathlon)).EndInit();
            this.tabPageDetails.ResumeLayout(false);
            this.tabPageDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriathlonBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTriathlon;
        private System.Windows.Forms.TabPage tabPageAffTriathlon;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.DataGridView dataGridTriathlon;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.TextBox txtNomTri;
        private System.Windows.Forms.TextBox txtNumTri;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTriathlonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTriathlonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSCRIPTIONsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPETRIATHLONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource TriathlonBinding;
    }
}