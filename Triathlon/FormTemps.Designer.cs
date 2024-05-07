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
            this.TempsBinding = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblCycl = new System.Windows.Forms.Label();
            this.lblNat = new System.Windows.Forms.Label();
            this.txtBoxCourse = new System.Windows.Forms.TextBox();
            this.txtBoxCycl = new System.Windows.Forms.TextBox();
            this.txtBoxNat = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.numDossardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsCourseCysclisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsNatationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTriathleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControlTemps.Location = new System.Drawing.Point(14, 15);
            this.tabControlTemps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlTemps.Name = "tabControlTemps";
            this.tabControlTemps.SelectedIndex = 0;
            this.tabControlTemps.Size = new System.Drawing.Size(873, 532);
            this.tabControlTemps.TabIndex = 2;
            this.tabControlTemps.SelectedIndexChanged += new System.EventHandler(this.tabControlTemps_SelectedIndexChanged);
            // 
            // tabPageAffTemps
            // 
            this.tabPageAffTemps.Controls.Add(this.btnAjouter);
            this.tabPageAffTemps.Controls.Add(this.btnSupp);
            this.tabPageAffTemps.Controls.Add(this.lblTriatlhète);
            this.tabPageAffTemps.Controls.Add(this.comboBox1);
            this.tabPageAffTemps.Controls.Add(this.TempsDataGrid);
            this.tabPageAffTemps.Location = new System.Drawing.Point(4, 29);
            this.tabPageAffTemps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAffTemps.Name = "tabPageAffTemps";
            this.tabPageAffTemps.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAffTemps.Size = new System.Drawing.Size(865, 499);
            this.tabPageAffTemps.TabIndex = 0;
            this.tabPageAffTemps.Text = "Affichage Temps";
            this.tabPageAffTemps.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAjouter.Location = new System.Drawing.Point(70, 439);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(308, 50);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter un temps";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupp.Location = new System.Drawing.Point(413, 438);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(308, 50);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = false;
            // 
            // lblTriatlhète
            // 
            this.lblTriatlhète.AutoSize = true;
            this.lblTriatlhète.Location = new System.Drawing.Point(29, 20);
            this.lblTriatlhète.Name = "lblTriatlhète";
            this.lblTriatlhète.Size = new System.Drawing.Size(188, 20);
            this.lblTriatlhète.TabIndex = 2;
            this.lblTriatlhète.Text = "Séléctionner le triathlète :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.TriathleteBinding;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // TriathleteBinding
            // 
            this.TriathleteBinding.DataSource = typeof(Triathlon.TRIATHLETE);
            this.TriathleteBinding.CurrentChanged += new System.EventHandler(this.TriathleteBinding_CurrentChanged);
            // 
            // TempsDataGrid
            // 
            this.TempsDataGrid.AllowUserToAddRows = false;
            this.TempsDataGrid.AllowUserToDeleteRows = false;
            this.TempsDataGrid.AutoGenerateColumns = false;
            this.TempsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TempsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDossardDataGridViewTextBoxColumn,
            this.dateInscriptionDataGridViewTextBoxColumn,
            this.tempsCourseCysclisteDataGridViewTextBoxColumn,
            this.tempsCourseDataGridViewTextBoxColumn,
            this.tempsNatationDataGridViewTextBoxColumn,
            this.numeroTriathleteDataGridViewTextBoxColumn});
            this.TempsDataGrid.DataSource = this.TempsBinding;
            this.TempsDataGrid.Location = new System.Drawing.Point(12, 80);
            this.TempsDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TempsDataGrid.MultiSelect = false;
            this.TempsDataGrid.Name = "TempsDataGrid";
            this.TempsDataGrid.ReadOnly = true;
            this.TempsDataGrid.RowHeadersWidth = 51;
            this.TempsDataGrid.RowTemplate.Height = 24;
            this.TempsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TempsDataGrid.Size = new System.Drawing.Size(835, 335);
            this.TempsDataGrid.TabIndex = 0;
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
            this.tabPageDetails.Controls.Add(this.lblCourse);
            this.tabPageDetails.Controls.Add(this.lblCycl);
            this.tabPageDetails.Controls.Add(this.lblNat);
            this.tabPageDetails.Controls.Add(this.txtBoxCourse);
            this.tabPageDetails.Controls.Add(this.txtBoxCycl);
            this.tabPageDetails.Controls.Add(this.txtBoxNat);
            this.tabPageDetails.Controls.Add(this.txtBoxTotal);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 29);
            this.tabPageDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageDetails.Size = new System.Drawing.Size(865, 499);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Détails";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAnnuler.Location = new System.Drawing.Point(448, 369);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(228, 52);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.Color.OliveDrab;
            this.btnConfirmer.Location = new System.Drawing.Point(120, 369);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(228, 52);
            this.btnConfirmer.TabIndex = 8;
            this.btnConfirmer.Text = "Ajouter";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(135, 92);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Temps total :";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(117, 216);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(117, 20);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Temps course :";
            // 
            // lblCycl
            // 
            this.lblCycl.AutoSize = true;
            this.lblCycl.Location = new System.Drawing.Point(63, 184);
            this.lblCycl.Name = "lblCycl";
            this.lblCycl.Size = new System.Drawing.Size(172, 20);
            this.lblCycl.TabIndex = 5;
            this.lblCycl.Text = "Temps course cycliste :";
            // 
            // lblNat
            // 
            this.lblNat.AutoSize = true;
            this.lblNat.Location = new System.Drawing.Point(110, 151);
            this.lblNat.Name = "lblNat";
            this.lblNat.Size = new System.Drawing.Size(127, 20);
            this.lblNat.TabIndex = 4;
            this.lblNat.Text = "Temps natation :";
            // 
            // txtBoxCourse
            // 
            this.txtBoxCourse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TempsBinding, "tempsCourse", true));
            this.txtBoxCourse.Location = new System.Drawing.Point(236, 212);
            this.txtBoxCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCourse.Name = "txtBoxCourse";
            this.txtBoxCourse.Size = new System.Drawing.Size(112, 26);
            this.txtBoxCourse.TabIndex = 3;
            // 
            // txtBoxCycl
            // 
            this.txtBoxCycl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TempsBinding, "tempsCourseCyscliste", true));
            this.txtBoxCycl.Location = new System.Drawing.Point(236, 181);
            this.txtBoxCycl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCycl.Name = "txtBoxCycl";
            this.txtBoxCycl.Size = new System.Drawing.Size(112, 26);
            this.txtBoxCycl.TabIndex = 2;
            // 
            // txtBoxNat
            // 
            this.txtBoxNat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TempsBinding, "tempsNatation", true));
            this.txtBoxNat.Location = new System.Drawing.Point(236, 151);
            this.txtBoxNat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxNat.Name = "txtBoxNat";
            this.txtBoxNat.Size = new System.Drawing.Size(112, 26);
            this.txtBoxNat.TabIndex = 1;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(236, 85);
            this.txtBoxTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(112, 26);
            this.txtBoxTotal.TabIndex = 0;
            // 
            // numDossardDataGridViewTextBoxColumn
            // 
            this.numDossardDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numDossardDataGridViewTextBoxColumn.DataPropertyName = "numDossard";
            this.numDossardDataGridViewTextBoxColumn.HeaderText = "numDossard";
            this.numDossardDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numDossardDataGridViewTextBoxColumn.Name = "numDossardDataGridViewTextBoxColumn";
            this.numDossardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateInscriptionDataGridViewTextBoxColumn
            // 
            this.dateInscriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateInscriptionDataGridViewTextBoxColumn.DataPropertyName = "dateInscription";
            this.dateInscriptionDataGridViewTextBoxColumn.HeaderText = "dateInscription";
            this.dateInscriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateInscriptionDataGridViewTextBoxColumn.Name = "dateInscriptionDataGridViewTextBoxColumn";
            this.dateInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tempsCourseCysclisteDataGridViewTextBoxColumn
            // 
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.DataPropertyName = "tempsCourseCyscliste";
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.HeaderText = "tempsCourseCyscliste";
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.Name = "tempsCourseCysclisteDataGridViewTextBoxColumn";
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tempsCourseDataGridViewTextBoxColumn
            // 
            this.tempsCourseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tempsCourseDataGridViewTextBoxColumn.DataPropertyName = "tempsCourse";
            this.tempsCourseDataGridViewTextBoxColumn.HeaderText = "tempsCourse";
            this.tempsCourseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempsCourseDataGridViewTextBoxColumn.Name = "tempsCourseDataGridViewTextBoxColumn";
            this.tempsCourseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tempsNatationDataGridViewTextBoxColumn
            // 
            this.tempsNatationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tempsNatationDataGridViewTextBoxColumn.DataPropertyName = "tempsNatation";
            this.tempsNatationDataGridViewTextBoxColumn.HeaderText = "tempsNatation";
            this.tempsNatationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempsNatationDataGridViewTextBoxColumn.Name = "tempsNatationDataGridViewTextBoxColumn";
            this.tempsNatationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroTriathleteDataGridViewTextBoxColumn
            // 
            this.numeroTriathleteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroTriathleteDataGridViewTextBoxColumn.DataPropertyName = "numeroTriathlete";
            this.numeroTriathleteDataGridViewTextBoxColumn.HeaderText = "numeroTriathlete";
            this.numeroTriathleteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroTriathleteDataGridViewTextBoxColumn.Name = "numeroTriathleteDataGridViewTextBoxColumn";
            this.numeroTriathleteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tabControlTemps);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox txtBoxCourse;
        private System.Windows.Forms.TextBox txtBoxCycl;
        private System.Windows.Forms.TextBox txtBoxNat;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblCycl;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.BindingSource TriathleteBinding;
        private System.Windows.Forms.BindingSource TempsBinding;
        private System.Windows.Forms.Label lblNat;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDossardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsCourseCysclisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsNatationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTriathleteDataGridViewTextBoxColumn;
    }
}