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
    public partial class Produits : Form
    {
        public Produits()
        {
            InitializeComponent();
        }

        TriathlonEntities context;

        private void Produits_Load(object sender, EventArgs e)
        {
            try
            {

                context = new TriathlonEntities();
                context.PRODUITs.Load();

                bindingSourceProduits.DataSource = context.PRODUITs.Local.ToBindingList();

                btnValider.Visible = false;
                btnAnnuler.Visible = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bindingSourceProduits.CancelEdit();
            textBoxCode.ReadOnly = true;

            btnModifier.Visible = true;

            btnValider.Visible = false;
            btnAnnuler.Visible = false;
             

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir enregistrer le Produit ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                PRODUIT unP = new PRODUIT();
                unP = (PRODUIT)bindingSourceProduits.Current;
                try
                {
                    if(!String.IsNullOrEmpty(textBoxCode.Text) || !String.IsNullOrEmpty(textBoxCode.Text) || !String.IsNullOrEmpty(textBoxCode.Text))
                    {
                        bindingSourceProduits.EndEdit();

                        context.PRODUITs.Add(unP);
                        context.SaveChanges();
                        MessageBox.Show("Ajout réussie !", "confirmation", MessageBoxButtons.OK);
                        bindingSourceProduits.ResetBindings(false);



                        textBoxCode.ReadOnly = true;

                        btnModifier.Visible = true;

                        btnValider.Visible = false;
                        btnAnnuler.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Veuillez remplir le formulaire", "Attention", MessageBoxButtons.OK);

                        bindingSourceProduits.CancelEdit();
                    }
                  
                    
                }
                catch
                {
                    context.Entry(unP).State = EntityState.Unchanged;
                    bindingSourceProduits.ResetCurrentItem();
                    MessageBox.Show("Echec de l'insertion !", "Attention", MessageBoxButtons.OK);
                }
                tabControlProduits_TabIndexChanged(this, EventArgs.Empty);
               

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            bindingSourceProduits.EndEdit();

            context.SaveChanges();
            MessageBox.Show("Modification réussie !", "confirmation", MessageBoxButtons.OK);
        }

        private void btnAddProduit_Click(object sender, EventArgs e)
        {
            bindingSourceProduits.AddNew();
            tabControlProduits.SelectedIndex = 1;
            textBoxCode.ReadOnly = false;

            btnModifier.Visible = false;

            btnValider.Visible = true;
            btnAnnuler.Visible = true;
        }

        private void tabControlProduits_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControlProduits.SelectedIndex == 0)
            {
                bindingSourceProduits.CancelEdit();
                textBoxCode.ReadOnly = true;

                
            }
        }

        private void btnSuppProduit_Click(object sender, EventArgs e)
        {
            PRODUIT leP = (PRODUIT)bindingSourceProduits.Current;

            try
            {
                DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer le produit ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    context.PRODUITs.Remove(leP);
                    context.SaveChanges();
                    tabControlProduits.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                context.Entry(leP).State = EntityState.Unchanged;
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        

    }
}
