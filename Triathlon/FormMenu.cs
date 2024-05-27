using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triathlon
{
    public partial class FormMenuGest : Form
    {
        public FormMenuGest()
        {
            InitializeComponent();
        }

        private void triathlonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormTriathlon"] == null)
            {
                FormTriathlon frm = new FormTriathlon();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["FormTriathlon"].BringToFront();
            }
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormInscription"] == null)
            {
                FormInscription frm = new FormInscription();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["FormInscription"].BringToFront();
            }
        }

        private void contrôleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormControle"] == null)
            {
                FormControle frm = new FormControle();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["FormControle"].BringToFront();
            }
        }

        private void tempsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormTemps"] == null)
            {
                FormTemps frm = new FormTemps();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["FormTemps"].BringToFront();
            }
        }

        private void classementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormClassement"] == null)
            {
                FormClassement frm = new FormClassement();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["FormClassement"].BringToFront();
            }
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Produits"] == null)
            {
                Produits frm = new Produits();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["Produits"].BringToFront();
            }
        }
    }
}
