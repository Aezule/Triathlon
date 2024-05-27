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
        /*Booléen qui vérifie si l'on ajoute un nouveau produit où si l'on modifie
         un produit existant*/
        bool verifNew = false;
        public FormControle()
        {
            InitializeComponent();
        }
        TriathlonEntities context = new TriathlonEntities();

        /* Charge les données de la table Verifiers dans le binding source */
        private void FormControle_Load(object sender, EventArgs e)
        {
            try
            {
                context.VERIFIERs.Load();
                VerifBinding.DataSource = context.VERIFIERs.Local.ToBindingList();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /* Enregistre dans la base de données les nouveaux objets de la table verifiers 
         * ou les modifications de ces derniers */
        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir enregistrer le controle ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                VERIFIER unCT = new VERIFIER();
                unCT = (VERIFIER)VerifBinding.Current;
                try
                {
                    if(verifNew == true)
                    {
                        VerifBinding.EndEdit();

                        context.VERIFIERs.Add(unCT);
                        context.SaveChanges();
                        MessageBox.Show("Ajout réussie !", "confirmation", MessageBoxButtons.OK);
                        VerifBinding.ResetBindings(false);
                    }
                    else
                    {
                        VerifBinding.EndEdit();
                        
                        context.SaveChanges();
                        MessageBox.Show("Modification réussie !", "confirmation", MessageBoxButtons.OK);
                    }
                    tabControleDopage.SelectedIndex = 0;
                }
                catch
                {
                    context.Entry(unCT).State = EntityState.Unchanged;
                    VerifBinding.ResetCurrentItem();
                    MessageBox.Show("Echec de l'insertion !", "Attention", MessageBoxButtons.OK);
                }
                tabControleDopage_SelectedIndexChanged(sender, e);
                
            }
        }

        /* Annule les modifications en cours */
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            tabControleDopage.SelectedIndex = 0;
            tabControleDopage_SelectedIndexChanged(sender, e);
        }

        private void tabControleDopage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControleDopage.SelectedIndex == 0)
            {
                VerifBinding.CancelEdit();
                verifNew = false;
            }
        }

        //supprime le controle sélectionner
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            VERIFIER leCT = (VERIFIER)VerifBinding.Current;

            try
            {
                DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer le controle ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    context.VERIFIERs.Remove(leCT);
                    context.SaveChanges();
                    tabControleDopage.SelectedIndex = 0;
                }
            }
            catch(Exception ex) 
            {
                context.Entry(leCT).State = EntityState.Unchanged;
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            verifNew = false;
        }
        
        //bool true pour nouveau false pour modif
        private void btnAjoutCT_Click(object sender, EventArgs e)
        {
            VerifBinding.AddNew();
            verifNew = true;
            tabControleDopage.SelectedIndex = 1;
        }
    }
}
