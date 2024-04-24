namespace Triathlon
{
    partial class FormClassement
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
            this.dataGridClassement = new System.Windows.Forms.DataGridView();
            this.comboBoxTriathlon = new System.Windows.Forms.ComboBox();
            this.lblCombo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClassement)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClassement
            // 
            this.dataGridClassement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClassement.Location = new System.Drawing.Point(12, 91);
            this.dataGridClassement.Name = "dataGridClassement";
            this.dataGridClassement.RowHeadersWidth = 51;
            this.dataGridClassement.RowTemplate.Height = 24;
            this.dataGridClassement.Size = new System.Drawing.Size(843, 416);
            this.dataGridClassement.TabIndex = 0;
            // 
            // comboBoxTriathlon
            // 
            this.comboBoxTriathlon.FormattingEnabled = true;
            this.comboBoxTriathlon.Location = new System.Drawing.Point(12, 49);
            this.comboBoxTriathlon.Name = "comboBoxTriathlon";
            this.comboBoxTriathlon.Size = new System.Drawing.Size(298, 24);
            this.comboBoxTriathlon.TabIndex = 1;
            // 
            // lblCombo
            // 
            this.lblCombo.AutoSize = true;
            this.lblCombo.Location = new System.Drawing.Point(12, 30);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(174, 16);
            this.lblCombo.TabIndex = 2;
            this.lblCombo.Text = "Sélection des classements :\r\n";
            // 
            // FormClassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 519);
            this.Controls.Add(this.lblCombo);
            this.Controls.Add(this.comboBoxTriathlon);
            this.Controls.Add(this.dataGridClassement);
            this.Name = "FormClassement";
            this.Text = "Affichage du Classement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClassement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClassement;
        private System.Windows.Forms.ComboBox comboBoxTriathlon;
        private System.Windows.Forms.Label lblCombo;
    }
}