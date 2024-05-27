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
                
                context.INSCRIPTIONs.Load();

                List<INSCRIPTION> listeInscriptions = (from unI in context.INSCRIPTIONs
                                                       select unI).ToList();


                comboTriathlete.DataSource = listeInscriptions;
                comboTriathlete.DisplayMember = "numDossard";
                comboTriathlete.ValueMember = "numDossard";
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
                catch(Exception er)
                {
                    VerifBinding.ResetCurrentItem();
                    context.Entry(unCT).State = EntityState.Unchanged;
                    

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
                comboTriathlete.Enabled = false;
                comboTriathlon.Enabled = false;
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
            comboTriathlete.Enabled = true;
            comboTriathlon.Enabled = true;
            tabControleDopage.SelectedIndex = 1;
        }

        private void comboTriathlete_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string numDossartTxt = "";

                if(verifNew == true)
                {
                    numDossartTxt = comboTriathlete.SelectedValue.ToString();
                }
                
                //TRIATHLON Triathlon = context.INSCRIPTIONs
                //                        .Where(i => i.numDossard == numDossard)
                //                        .Select(i => new { i.numTriathlon });


                List<INSCRIPTION> lesInscription = (from unI in context.INSCRIPTIONs
                                           where unI.numDossard == numDossartTxt
                                           select unI).ToList();

                List<TRIATHLON> lesTriathlons = new List<TRIATHLON>();


                foreach (INSCRIPTION leI in lesInscription)
                {

                    List<TRIATHLON> lesT2 = (from unT in context.TRIATHLONs
                                             where leI.numTriathlon == unT.numTriathlon
                                             select unT).ToList();
                         
                    foreach(TRIATHLON t in lesT2)
                    {
                        lesTriathlons.Add(t);
                    }
                }


                

                comboTriathlon.DataSource = lesTriathlons;
                //comboTriathlon.DisplayMember = "numTriathlon";
                //comboTriathlon.ValueMember = "numTriathlon";

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
