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
            this.tabControleDopage = new System.Windows.Forms.TabControl();
            this.tabPageAffDopage = new System.Windows.Forms.TabPage();
            this.dataGridDopage = new System.Windows.Forms.DataGridView();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.lblCodeProduit = new System.Windows.Forms.Label();
            this.lblIdLabo = new System.Windows.Forms.Label();
            this.lblNumTriathlon = new System.Windows.Forms.Label();
            this.lblNumTriathlete = new System.Windows.Forms.Label();
            this.lblPrélèvement = new System.Windows.Forms.Label();
            this.lblVerif = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tabControleDopage.SuspendLayout();
            this.tabPageAffDopage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDopage)).BeginInit();
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
            this.dataGridDopage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDopage.Location = new System.Drawing.Point(7, 7);
            this.dataGridDopage.Name = "dataGridDopage";
            this.dataGridDopage.RowHeadersWidth = 51;
            this.dataGridDopage.RowTemplate.Height = 24;
            this.dataGridDopage.Size = new System.Drawing.Size(755, 384);
            this.dataGridDopage.TabIndex = 0;
            // 
            // tabPageDetails
            // 
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
            // lblCodeProduit
            // 
            this.lblCodeProduit.AutoSize = true;
            this.lblCodeProduit.Location = new System.Drawing.Point(147, 247);
            this.lblCodeProduit.Name = "lblCodeProduit";
            this.lblCodeProduit.Size = new System.Drawing.Size(138, 16);
            this.lblCodeProduit.TabIndex = 6;
            this.lblCodeProduit.Text = "Code produit dépisté :";
            // 
            // lblIdLabo
            // 
            this.lblIdLabo.AutoSize = true;
            this.lblIdLabo.Location = new System.Drawing.Point(147, 211);
            this.lblIdLabo.Name = "lblIdLabo";
            this.lblIdLabo.Size = new System.Drawing.Size(90, 16);
            this.lblIdLabo.TabIndex = 5;
            this.lblIdLabo.Text = "Id Laboratoire";
            // 
            // lblNumTriathlon
            // 
            this.lblNumTriathlon.AutoSize = true;
            this.lblNumTriathlon.Location = new System.Drawing.Point(147, 176);
            this.lblNumTriathlon.Name = "lblNumTriathlon";
            this.lblNumTriathlon.Size = new System.Drawing.Size(135, 16);
            this.lblNumTriathlon.TabIndex = 4;
            this.lblNumTriathlon.Text = "Numéro de Triathlon :";
            // 
            // lblNumTriathlete
            // 
            this.lblNumTriathlete.AutoSize = true;
            this.lblNumTriathlete.Location = new System.Drawing.Point(146, 144);
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
            this.lblVerif.Location = new System.Drawing.Point(147, 115);
            this.lblVerif.Name = "lblVerif";
            this.lblVerif.Size = new System.Drawing.Size(49, 16);
            this.lblVerif.TabIndex = 1;
            this.lblVerif.Text = "Positif :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(147, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(77, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id Contrôle :";
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
    }
}