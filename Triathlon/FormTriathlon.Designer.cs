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
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.tabControlTriathlon.SuspendLayout();
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
            this.tabPageAffTriathlon.Location = new System.Drawing.Point(4, 25);
            this.tabPageAffTriathlon.Name = "tabPageAffTriathlon";
            this.tabPageAffTriathlon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAffTriathlon.Size = new System.Drawing.Size(768, 397);
            this.tabPageAffTriathlon.TabIndex = 0;
            this.tabPageAffTriathlon.Text = "Affichage Triathlon";
            this.tabPageAffTriathlon.UseVisualStyleBackColor = true;
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
            // FormTriathlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlTriathlon);
            this.Name = "FormTriathlon";
            this.Text = "Gestionnaire des Triathlon";
            this.tabControlTriathlon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTriathlon;
        private System.Windows.Forms.TabPage tabPageAffTriathlon;
        private System.Windows.Forms.TabPage tabPageDetails;
    }
}