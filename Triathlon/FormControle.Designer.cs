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
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.tabControleDopage.SuspendLayout();
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
            this.tabPageAffDopage.Location = new System.Drawing.Point(4, 25);
            this.tabPageAffDopage.Name = "tabPageAffDopage";
            this.tabPageAffDopage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAffDopage.Size = new System.Drawing.Size(768, 397);
            this.tabPageAffDopage.TabIndex = 0;
            this.tabPageAffDopage.Text = "Affichage Contrôle";
            this.tabPageAffDopage.UseVisualStyleBackColor = true;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(768, 397);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Détails";
            this.tabPageDetails.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControleDopage;
        private System.Windows.Forms.TabPage tabPageAffDopage;
        private System.Windows.Forms.TabPage tabPageDetails;
    }
}