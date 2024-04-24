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
            this.tabControlTriathlon = new System.Windows.Forms.TabControl();
            this.tabPageAffTriathlon = new System.Windows.Forms.TabPage();
            this.dataGridTriathlon = new System.Windows.Forms.DataGridView();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControlTriathlon.SuspendLayout();
            this.tabPageAffTriathlon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTriathlon)).BeginInit();
            this.tabPageDetails.SuspendLayout();
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
            this.dataGridTriathlon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTriathlon.Location = new System.Drawing.Point(6, 6);
            this.dataGridTriathlon.Name = "dataGridTriathlon";
            this.dataGridTriathlon.RowHeadersWidth = 51;
            this.dataGridTriathlon.RowTemplate.Height = 24;
            this.dataGridTriathlon.Size = new System.Drawing.Size(756, 385);
            this.dataGridTriathlon.TabIndex = 1;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.textBox4);
            this.tabPageDetails.Controls.Add(this.textBox3);
            this.tabPageDetails.Controls.Add(this.textBox2);
            this.tabPageDetails.Controls.Add(this.textBox1);
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
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Lime;
            this.btnValider.Location = new System.Drawing.Point(206, 270);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(115, 32);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupprimer.Location = new System.Drawing.Point(472, 58);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(112, 32);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(257, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(257, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(257, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // FormTriathlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlTriathlon);
            this.Name = "FormTriathlon";
            this.Text = "Gestionnaire des Triathlon";
            this.tabControlTriathlon.ResumeLayout(false);
            this.tabPageAffTriathlon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTriathlon)).EndInit();
            this.tabPageDetails.ResumeLayout(false);
            this.tabPageDetails.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnValider;
    }
}