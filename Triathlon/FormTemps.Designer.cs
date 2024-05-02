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
            this.components = new System.ComponentModel.Container();
            this.tabControlTemps = new System.Windows.Forms.TabControl();
            this.tabPageAffTemps = new System.Windows.Forms.TabPage();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.lblTriatlhète = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TriathleteBinding = new System.Windows.Forms.BindingSource(this.components);
            this.TempsDataGrid = new System.Windows.Forms.DataGridView();
            this.numTriathlonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDossardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsCourseCysclisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsNatationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTriathleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRIATHLETEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vERIFIERsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRIATHLONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempsBinding = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNat = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.tabControlTemps.SuspendLayout();
            this.tabPageAffTemps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriathleteBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempsBinding)).BeginInit();
            this.tabPageDetails.SuspendLayout();
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
            this.tabPageAffTemps.Controls.Add(this.btnAjouter);
            this.tabPageAffTemps.Controls.Add(this.btnSupp);
            this.tabPageAffTemps.Controls.Add(this.lblTriatlhète);
            this.tabPageAffTemps.Controls.Add(this.comboBox1);
            this.tabPageAffTemps.Controls.Add(this.TempsDataGrid);
            this.tabPageAffTemps.Location = new System.Drawing.Point(4, 25);
            this.tabPageAffTemps.Name = "tabPageAffTemps";
            this.tabPageAffTemps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAffTemps.Size = new System.Drawing.Size(768, 397);
            this.tabPageAffTemps.TabIndex = 0;
            this.tabPageAffTemps.Text = "Affichage Temps";
            this.tabPageAffTemps.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAjouter.Location = new System.Drawing.Point(62, 351);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(274, 40);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter un temps";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupp.Location = new System.Drawing.Point(367, 350);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(274, 40);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = false;
            // 
            // lblTriatlhète
            // 
            this.lblTriatlhète.AutoSize = true;
            this.lblTriatlhète.Location = new System.Drawing.Point(26, 16);
            this.lblTriatlhète.Name = "lblTriatlhète";
            this.lblTriatlhète.Size = new System.Drawing.Size(155, 16);
            this.lblTriatlhète.TabIndex = 2;
            this.lblTriatlhète.Text = "Séléctionner le triathlète :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.TriathleteBinding;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TriathleteBinding
            // 
            this.TriathleteBinding.DataSource = typeof(Triathlon.TRIATHLETE);
            // 
            // TempsDataGrid
            // 
            this.TempsDataGrid.AllowUserToAddRows = false;
            this.TempsDataGrid.AllowUserToDeleteRows = false;
            this.TempsDataGrid.AutoGenerateColumns = false;
            this.TempsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TempsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numTriathlonDataGridViewTextBoxColumn,
            this.numDossardDataGridViewTextBoxColumn,
            this.dateInscriptionDataGridViewTextBoxColumn,
            this.tempsCourseCysclisteDataGridViewTextBoxColumn,
            this.tempsCourseDataGridViewTextBoxColumn,
            this.tempsNatationDataGridViewTextBoxColumn,
            this.numeroTriathleteDataGridViewTextBoxColumn,
            this.tRIATHLETEDataGridViewTextBoxColumn,
            this.vERIFIERsDataGridViewTextBoxColumn,
            this.tRIATHLONDataGridViewTextBoxColumn});
            this.TempsDataGrid.DataSource = this.TempsBinding;
            this.TempsDataGrid.Location = new System.Drawing.Point(7, 76);
            this.TempsDataGrid.Name = "TempsDataGrid";
            this.TempsDataGrid.RowHeadersWidth = 51;
            this.TempsDataGrid.RowTemplate.Height = 24;
            this.TempsDataGrid.Size = new System.Drawing.Size(758, 268);
            this.TempsDataGrid.TabIndex = 0;
            // 
            // numTriathlonDataGridViewTextBoxColumn
            // 
            this.numTriathlonDataGridViewTextBoxColumn.DataPropertyName = "numTriathlon";
            this.numTriathlonDataGridViewTextBoxColumn.HeaderText = "numTriathlon";
            this.numTriathlonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numTriathlonDataGridViewTextBoxColumn.Name = "numTriathlonDataGridViewTextBoxColumn";
            this.numTriathlonDataGridViewTextBoxColumn.Width = 125;
            // 
            // numDossardDataGridViewTextBoxColumn
            // 
            this.numDossardDataGridViewTextBoxColumn.DataPropertyName = "numDossard";
            this.numDossardDataGridViewTextBoxColumn.HeaderText = "numDossard";
            this.numDossardDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numDossardDataGridViewTextBoxColumn.Name = "numDossardDataGridViewTextBoxColumn";
            this.numDossardDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateInscriptionDataGridViewTextBoxColumn
            // 
            this.dateInscriptionDataGridViewTextBoxColumn.DataPropertyName = "dateInscription";
            this.dateInscriptionDataGridViewTextBoxColumn.HeaderText = "dateInscription";
            this.dateInscriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateInscriptionDataGridViewTextBoxColumn.Name = "dateInscriptionDataGridViewTextBoxColumn";
            this.dateInscriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempsCourseCysclisteDataGridViewTextBoxColumn
            // 
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.DataPropertyName = "tempsCourseCyscliste";
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.HeaderText = "tempsCourseCyscliste";
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.Name = "tempsCourseCysclisteDataGridViewTextBoxColumn";
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempsCourseDataGridViewTextBoxColumn
            // 
            this.tempsCourseDataGridViewTextBoxColumn.DataPropertyName = "tempsCourse";
            this.tempsCourseDataGridViewTextBoxColumn.HeaderText = "tempsCourse";
            this.tempsCourseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempsCourseDataGridViewTextBoxColumn.Name = "tempsCourseDataGridViewTextBoxColumn";
            this.tempsCourseDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempsNatationDataGridViewTextBoxColumn
            // 
            this.tempsNatationDataGridViewTextBoxColumn.DataPropertyName = "tempsNatation";
            this.tempsNatationDataGridViewTextBoxColumn.HeaderText = "tempsNatation";
            this.tempsNatationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempsNatationDataGridViewTextBoxColumn.Name = "tempsNatationDataGridViewTextBoxColumn";
            this.tempsNatationDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroTriathleteDataGridViewTextBoxColumn
            // 
            this.numeroTriathleteDataGridViewTextBoxColumn.DataPropertyName = "numeroTriathlete";
            this.numeroTriathleteDataGridViewTextBoxColumn.HeaderText = "numeroTriathlete";
            this.numeroTriathleteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroTriathleteDataGridViewTextBoxColumn.Name = "numeroTriathleteDataGridViewTextBoxColumn";
            this.numeroTriathleteDataGridViewTextBoxColumn.Width = 125;
            // 
            // tRIATHLETEDataGridViewTextBoxColumn
            // 
            this.tRIATHLETEDataGridViewTextBoxColumn.DataPropertyName = "TRIATHLETE";
            this.tRIATHLETEDataGridViewTextBoxColumn.HeaderText = "TRIATHLETE";
            this.tRIATHLETEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tRIATHLETEDataGridViewTextBoxColumn.Name = "tRIATHLETEDataGridViewTextBoxColumn";
            this.tRIATHLETEDataGridViewTextBoxColumn.Width = 125;
            // 
            // vERIFIERsDataGridViewTextBoxColumn
            // 
            this.vERIFIERsDataGridViewTextBoxColumn.DataPropertyName = "VERIFIERs";
            this.vERIFIERsDataGridViewTextBoxColumn.HeaderText = "VERIFIERs";
            this.vERIFIERsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vERIFIERsDataGridViewTextBoxColumn.Name = "vERIFIERsDataGridViewTextBoxColumn";
            this.vERIFIERsDataGridViewTextBoxColumn.Width = 125;
            // 
            // tRIATHLONDataGridViewTextBoxColumn
            // 
            this.tRIATHLONDataGridViewTextBoxColumn.DataPropertyName = "TRIATHLON";
            this.tRIATHLONDataGridViewTextBoxColumn.HeaderText = "TRIATHLON";
            this.tRIATHLONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tRIATHLONDataGridViewTextBoxColumn.Name = "tRIATHLONDataGridViewTextBoxColumn";
            this.tRIATHLONDataGridViewTextBoxColumn.Width = 125;
            // 
            // TempsBinding
            // 
            this.TempsBinding.DataSource = typeof(Triathlon.INSCRIPTION);
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.btnAnnuler);
            this.tabPageDetails.Controls.Add(this.btnConfirmer);
            this.tabPageDetails.Controls.Add(this.lblTotal);
            this.tabPageDetails.Controls.Add(this.label3);
            this.tabPageDetails.Controls.Add(this.label2);
            this.tabPageDetails.Controls.Add(this.lblNat);
            this.tabPageDetails.Controls.Add(this.textBox4);
            this.tabPageDetails.Controls.Add(this.textBox3);
            this.tabPageDetails.Controls.Add(this.txtBox);
            this.tabPageDetails.Controls.Add(this.txtBoxTotal);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(768, 397);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Détails";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAnnuler.Location = new System.Drawing.Point(398, 295);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(203, 42);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.Color.OliveDrab;
            this.btnConfirmer.Location = new System.Drawing.Point(107, 295);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(203, 42);
            this.btnConfirmer.TabIndex = 8;
            this.btnConfirmer.Text = "Ajouter";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(120, 71);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 16);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Temps total :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Temps course :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temps course cycliste :";
            // 
            // lblNat
            // 
            this.lblNat.AutoSize = true;
            this.lblNat.Location = new System.Drawing.Point(104, 118);
            this.lblNat.Name = "lblNat";
            this.lblNat.Size = new System.Drawing.Size(106, 16);
            this.lblNat.TabIndex = 4;
            this.lblNat.Text = "Temps natation :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(210, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(186, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 22);
            this.textBox3.TabIndex = 2;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(210, 115);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(186, 22);
            this.txtBox.TabIndex = 1;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(210, 68);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(186, 22);
            this.txtBoxTotal.TabIndex = 0;
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
            this.tabPageAffTemps.ResumeLayout(false);
            this.tabPageAffTemps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriathleteBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempsBinding)).EndInit();
            this.tabPageDetails.ResumeLayout(false);
            this.tabPageDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTemps;
        private System.Windows.Forms.TabPage tabPageAffTemps;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.Label lblTriatlhète;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView TempsDataGrid;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNat;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.BindingSource TriathleteBinding;
        private System.Windows.Forms.BindingSource TempsBinding;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTriathlonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDossardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsCourseCysclisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsNatationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTriathleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIATHLETEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vERIFIERsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIATHLONDataGridViewTextBoxColumn;
    }
}