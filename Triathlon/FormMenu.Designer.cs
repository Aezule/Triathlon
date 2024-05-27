namespace Triathlon
{
    partial class FormMenuGest
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
            this.menuStripGestion = new System.Windows.Forms.MenuStrip();
            this.triathlonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrôleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripGestion
            // 
            this.menuStripGestion.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripGestion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripGestion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triathlonToolStripMenuItem,
            this.inscriptionToolStripMenuItem,
            this.contrôleToolStripMenuItem,
            this.tempsToolStripMenuItem,
            this.classementToolStripMenuItem,
            this.produitsToolStripMenuItem});
            this.menuStripGestion.Location = new System.Drawing.Point(0, 0);
            this.menuStripGestion.Name = "menuStripGestion";
            this.menuStripGestion.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripGestion.Size = new System.Drawing.Size(900, 33);
            this.menuStripGestion.TabIndex = 1;
            this.menuStripGestion.Text = "Gestion";
            // 
            // triathlonToolStripMenuItem
            // 
            this.triathlonToolStripMenuItem.Name = "triathlonToolStripMenuItem";
            this.triathlonToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.triathlonToolStripMenuItem.Text = "Triathlon";
            this.triathlonToolStripMenuItem.Click += new System.EventHandler(this.triathlonToolStripMenuItem_Click);
            // 
            // inscriptionToolStripMenuItem
            // 
            this.inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            this.inscriptionToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.inscriptionToolStripMenuItem.Text = "Inscription";
            this.inscriptionToolStripMenuItem.Click += new System.EventHandler(this.inscriptionToolStripMenuItem_Click);
            // 
            // contrôleToolStripMenuItem
            // 
            this.contrôleToolStripMenuItem.Name = "contrôleToolStripMenuItem";
            this.contrôleToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.contrôleToolStripMenuItem.Text = "Contrôle";
            this.contrôleToolStripMenuItem.Click += new System.EventHandler(this.contrôleToolStripMenuItem_Click);
            // 
            // tempsToolStripMenuItem
            // 
            this.tempsToolStripMenuItem.Name = "tempsToolStripMenuItem";
            this.tempsToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.tempsToolStripMenuItem.Text = "Temps";
            this.tempsToolStripMenuItem.Click += new System.EventHandler(this.tempsToolStripMenuItem_Click);
            // 
            // classementToolStripMenuItem
            // 
            this.classementToolStripMenuItem.Name = "classementToolStripMenuItem";
            this.classementToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.classementToolStripMenuItem.Text = "Classement";
            this.classementToolStripMenuItem.Click += new System.EventHandler(this.classementToolStripMenuItem_Click);
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.produitsToolStripMenuItem.Text = "Produits";
            this.produitsToolStripMenuItem.Click += new System.EventHandler(this.produitsToolStripMenuItem_Click);
            // 
            // FormMenuGest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.menuStripGestion);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripGestion;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenuGest";
            this.Text = "Gestion Triathlon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripGestion.ResumeLayout(false);
            this.menuStripGestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripGestion;
        private System.Windows.Forms.ToolStripMenuItem triathlonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrôleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
    }
}