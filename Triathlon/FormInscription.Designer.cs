﻿namespace Triathlon
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
            this.components = new System.ComponentModel.Container();
            this.tabControlInscription = new System.Windows.Forms.TabControl();
            this.tabPageAjoutInsc = new System.Windows.Forms.TabPage();
            this.textTriathlete = new System.Windows.Forms.TextBox();
            this.txtTriathlon = new System.Windows.Forms.TextBox();
            this.btnAjouterInscription = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtPickerDate = new System.Windows.Forms.DateTimePicker();
            this.lbltriathlète = new System.Windows.Forms.Label();
            this.lblTriathlon = new System.Windows.Forms.Label();
            this.tabPageSuppInsc = new System.Windows.Forms.TabPage();
            this.labelNoInscription = new System.Windows.Forms.Label();
            this.btnSupprimerInscription = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numDossardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsCourseCysclisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsNatationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTriathleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceInscriptionsDunTriathlon = new System.Windows.Forms.BindingSource(this.components);
            this.lblInscription = new System.Windows.Forms.Label();
            this.comboBoxTriathlon = new System.Windows.Forms.ComboBox();
            this.bindingSourceTriathlons = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceInscriptionAll = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlInscription.SuspendLayout();
            this.tabPageAjoutInsc.SuspendLayout();
            this.tabPageSuppInsc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInscriptionsDunTriathlon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTriathlons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInscriptionAll)).BeginInit();
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
            this.tabPageAjoutInsc.Controls.Add(this.textTriathlete);
            this.tabPageAjoutInsc.Controls.Add(this.txtTriathlon);
            this.tabPageAjoutInsc.Controls.Add(this.btnAjouterInscription);
            this.tabPageAjoutInsc.Controls.Add(this.lblDate);
            this.tabPageAjoutInsc.Controls.Add(this.dtPickerDate);
            this.tabPageAjoutInsc.Controls.Add(this.lbltriathlète);
            this.tabPageAjoutInsc.Controls.Add(this.lblTriathlon);
            this.tabPageAjoutInsc.Location = new System.Drawing.Point(4, 25);
            this.tabPageAjoutInsc.Name = "tabPageAjoutInsc";
            this.tabPageAjoutInsc.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageAjoutInsc.Size = new System.Drawing.Size(767, 396);
            this.tabPageAjoutInsc.TabIndex = 0;
            this.tabPageAjoutInsc.Text = "Ajouter une Inscription";
            this.tabPageAjoutInsc.UseVisualStyleBackColor = true;
            // 
            // textTriathlete
            // 
            this.textTriathlete.Location = new System.Drawing.Point(215, 84);
            this.textTriathlete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTriathlete.Name = "textTriathlete";
            this.textTriathlete.Size = new System.Drawing.Size(152, 22);
            this.textTriathlete.TabIndex = 8;
            // 
            // txtTriathlon
            // 
            this.txtTriathlon.Location = new System.Drawing.Point(215, 35);
            this.txtTriathlon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTriathlon.Name = "txtTriathlon";
            this.txtTriathlon.Size = new System.Drawing.Size(152, 22);
            this.txtTriathlon.TabIndex = 7;
            // 
            // btnAjouterInscription
            // 
            this.btnAjouterInscription.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAjouterInscription.Location = new System.Drawing.Point(257, 286);
            this.btnAjouterInscription.Name = "btnAjouterInscription";
            this.btnAjouterInscription.Size = new System.Drawing.Size(270, 57);
            this.btnAjouterInscription.TabIndex = 6;
            this.btnAjouterInscription.Text = "Ajouter ";
            this.btnAjouterInscription.UseVisualStyleBackColor = false;
            this.btnAjouterInscription.Click += new System.EventHandler(this.btnAjouterInscription_Click);
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
            // dtPickerDate
            // 
            this.dtPickerDate.Location = new System.Drawing.Point(200, 154);
            this.dtPickerDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtPickerDate.Name = "dtPickerDate";
            this.dtPickerDate.Size = new System.Drawing.Size(200, 22);
            this.dtPickerDate.TabIndex = 2;
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
            this.tabPageSuppInsc.Controls.Add(this.labelNoInscription);
            this.tabPageSuppInsc.Controls.Add(this.btnSupprimerInscription);
            this.tabPageSuppInsc.Controls.Add(this.dataGridView1);
            this.tabPageSuppInsc.Controls.Add(this.lblInscription);
            this.tabPageSuppInsc.Controls.Add(this.comboBoxTriathlon);
            this.tabPageSuppInsc.Location = new System.Drawing.Point(4, 25);
            this.tabPageSuppInsc.Name = "tabPageSuppInsc";
            this.tabPageSuppInsc.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageSuppInsc.Size = new System.Drawing.Size(767, 396);
            this.tabPageSuppInsc.TabIndex = 1;
            this.tabPageSuppInsc.Text = "Supprimer une Inscription";
            this.tabPageSuppInsc.UseVisualStyleBackColor = true;
            // 
            // labelNoInscription
            // 
            this.labelNoInscription.Location = new System.Drawing.Point(238, 196);
            this.labelNoInscription.Name = "labelNoInscription";
            this.labelNoInscription.Size = new System.Drawing.Size(293, 58);
            this.labelNoInscription.TabIndex = 4;
            this.labelNoInscription.Text = "Pas d\'inscriptions pour ce triathlon";
            this.labelNoInscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSupprimerInscription
            // 
            this.btnSupprimerInscription.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupprimerInscription.Location = new System.Drawing.Point(48, 346);
            this.btnSupprimerInscription.Name = "btnSupprimerInscription";
            this.btnSupprimerInscription.Size = new System.Drawing.Size(677, 44);
            this.btnSupprimerInscription.TabIndex = 3;
            this.btnSupprimerInscription.Text = "Supprimer";
            this.btnSupprimerInscription.UseVisualStyleBackColor = false;
            this.btnSupprimerInscription.Click += new System.EventHandler(this.btnSupprimerInscription_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDossardDataGridViewTextBoxColumn,
            this.dateInscriptionDataGridViewTextBoxColumn,
            this.tempsCourseCysclisteDataGridViewTextBoxColumn,
            this.tempsCourseDataGridViewTextBoxColumn,
            this.tempsNatationDataGridViewTextBoxColumn,
            this.numeroTriathleteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceInscriptionsDunTriathlon;
            this.dataGridView1.Location = new System.Drawing.Point(7, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 275);
            this.dataGridView1.TabIndex = 2;
            // 
            // numDossardDataGridViewTextBoxColumn
            // 
            this.numDossardDataGridViewTextBoxColumn.DataPropertyName = "numDossard";
            this.numDossardDataGridViewTextBoxColumn.HeaderText = "Dossard";
            this.numDossardDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numDossardDataGridViewTextBoxColumn.Name = "numDossardDataGridViewTextBoxColumn";
            // 
            // dateInscriptionDataGridViewTextBoxColumn
            // 
            this.dateInscriptionDataGridViewTextBoxColumn.DataPropertyName = "dateInscription";
            this.dateInscriptionDataGridViewTextBoxColumn.HeaderText = "Date d\'inscription";
            this.dateInscriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateInscriptionDataGridViewTextBoxColumn.Name = "dateInscriptionDataGridViewTextBoxColumn";
            // 
            // tempsCourseCysclisteDataGridViewTextBoxColumn
            // 
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.DataPropertyName = "tempsCourseCyscliste";
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.HeaderText = "Temps Cyclisme";
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tempsCourseCysclisteDataGridViewTextBoxColumn.Name = "tempsCourseCysclisteDataGridViewTextBoxColumn";
            // 
            // tempsCourseDataGridViewTextBoxColumn
            // 
            this.tempsCourseDataGridViewTextBoxColumn.DataPropertyName = "tempsCourse";
            this.tempsCourseDataGridViewTextBoxColumn.HeaderText = "Temps Course";
            this.tempsCourseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tempsCourseDataGridViewTextBoxColumn.Name = "tempsCourseDataGridViewTextBoxColumn";
            // 
            // tempsNatationDataGridViewTextBoxColumn
            // 
            this.tempsNatationDataGridViewTextBoxColumn.DataPropertyName = "tempsNatation";
            this.tempsNatationDataGridViewTextBoxColumn.HeaderText = "Temps Natation";
            this.tempsNatationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tempsNatationDataGridViewTextBoxColumn.Name = "tempsNatationDataGridViewTextBoxColumn";
            // 
            // numeroTriathleteDataGridViewTextBoxColumn
            // 
            this.numeroTriathleteDataGridViewTextBoxColumn.DataPropertyName = "numeroTriathlete";
            this.numeroTriathleteDataGridViewTextBoxColumn.HeaderText = "Numéro du Triathlete";
            this.numeroTriathleteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numeroTriathleteDataGridViewTextBoxColumn.Name = "numeroTriathleteDataGridViewTextBoxColumn";
            // 
            // bindingSourceInscriptionsDunTriathlon
            // 
            this.bindingSourceInscriptionsDunTriathlon.DataSource = typeof(Triathlon.INSCRIPTION);
            // 
            // lblInscription
            // 
            this.lblInscription.AutoSize = true;
            this.lblInscription.Location = new System.Drawing.Point(45, 4);
            this.lblInscription.Name = "lblInscription";
            this.lblInscription.Size = new System.Drawing.Size(154, 16);
            this.lblInscription.TabIndex = 1;
            this.lblInscription.Text = "Séléctionner un triathlon :";
            // 
            // comboBoxTriathlon
            // 
            this.comboBoxTriathlon.DataSource = this.bindingSourceTriathlons;
            this.comboBoxTriathlon.FormattingEnabled = true;
            this.comboBoxTriathlon.Location = new System.Drawing.Point(48, 32);
            this.comboBoxTriathlon.Name = "comboBoxTriathlon";
            this.comboBoxTriathlon.Size = new System.Drawing.Size(297, 24);
            this.comboBoxTriathlon.TabIndex = 0;
            // 
            // bindingSourceTriathlons
            // 
            this.bindingSourceTriathlons.DataSource = typeof(Triathlon.TRIATHLON);
            this.bindingSourceTriathlons.CurrentChanged += new System.EventHandler(this.bindingSourceTriathlons_CurrentChanged);
            // 
            // bindingSourceInscriptionAll
            // 
            this.bindingSourceInscriptionAll.DataSource = typeof(Triathlon.INSCRIPTION);
            // 
            // FormInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlInscription);
            this.Name = "FormInscription";
            this.Text = "Inscription des Triathlètes";
            this.Load += new System.EventHandler(this.FormInscription_Load);
            this.tabControlInscription.ResumeLayout(false);
            this.tabPageAjoutInsc.ResumeLayout(false);
            this.tabPageAjoutInsc.PerformLayout();
            this.tabPageSuppInsc.ResumeLayout(false);
            this.tabPageSuppInsc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInscriptionsDunTriathlon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTriathlons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInscriptionAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInscription;
        private System.Windows.Forms.TabPage tabPageAjoutInsc;
        private System.Windows.Forms.TabPage tabPageSuppInsc;
        private System.Windows.Forms.Label lblTriathlon;
        private System.Windows.Forms.Label lbltriathlète;
        private System.Windows.Forms.DateTimePicker dtPickerDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAjouterInscription;
        private System.Windows.Forms.ComboBox comboBoxTriathlon;
        private System.Windows.Forms.Label lblInscription;
        private System.Windows.Forms.Button btnSupprimerInscription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceInscriptionsDunTriathlon;
        private System.Windows.Forms.BindingSource bindingSourceTriathlons;
        private System.Windows.Forms.BindingSource bindingSourceInscriptionAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDossardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsCourseCysclisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsNatationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTriathleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelNoInscription;
        private System.Windows.Forms.TextBox textTriathlete;
        private System.Windows.Forms.TextBox txtTriathlon;
    }
}

