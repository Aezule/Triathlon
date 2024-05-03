using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triathlon
{
    public partial class FormControle : Form
    {
        public FormControle()
        {
            InitializeComponent();
        }
        TriathlonEntities context;

        private void FormControle_Load(object sender, EventArgs e)
        {
            try
            {
                context = new TriathlonEntities();
                context.VERIFIERs.Load();
                VerifBinding.DataSource = context.VERIFIERs.Local.ToBindingList();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir modifier le controle ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                VERIFIER unCT = new VERIFIER();
                unCT = (VERIFIER)VerifBinding.Current;
                try
                {
                    VerifBinding.EndEdit();
                    context.SaveChanges();
                    MessageBox.Show("Modification réussie !", "confirmation", MessageBoxButtons.OK);
                }
                catch
                {
                    context.Entry(unCT).State = EntityState.Unchanged;
                    VerifBinding.ResetCurrentItem();
                }

            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            VerifBinding.CancelEdit();
        }

        private void tabControleDopage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControleDopage.SelectedIndex == 0)
            {
                VerifBinding.CancelEdit();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer le controle ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            { 

            }
        }
    }
}
