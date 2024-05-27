using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace Triathlon
{
    public partial class FormTriathlon : Form
    {
        public FormTriathlon()
        {
            InitializeComponent();
        }
        TriathlonEntities context;
        // Booléen qui vérifie si l'on ajoute un nouveau produit où si l'on modifie
        bool isNew = false;
            /// <summary>
            /// Charge les données de la table Triathlon dans le binding source
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void FormTriathlon_Load(object sender, EventArgs e)
        {
            try
            {
                context = new TriathlonEntities();
                context.TRIATHLONs.Load();
                context.TYPE_TRIATHLON.Load();
                TypeBinding.DataSource = context.TYPE_TRIATHLON.Local.ToBindingList();
                TriathlonBinding.DataSource = context.TRIATHLONs.Local.ToBindingList();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridTriathlon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tabControlTriathlon.SelectedIndex = 1;
        }
        /// <summary>
        /// Ajoute ou modifie un triathlon dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir enregistrer le triathlon ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                TRIATHLON unTL = new TRIATHLON();
                unTL = (TRIATHLON)TriathlonBinding.Current;
                try
                {
                    // Si le triathlon est nouveau
                    if(isNew)
                    {
                        TriathlonBinding.EndEdit();

                        context.TRIATHLONs.Add(unTL);
                        context.SaveChanges();
                        MessageBox.Show("Ajout réussie !", "confirmation", MessageBoxButtons.OK);
                        TriathlonBinding.ResetBindings(false);
                    }
                    // Si le triathlon est existant
                    else
                    {
                        TriathlonBinding.EndEdit();
                        context.SaveChanges();
                        MessageBox.Show("Modification réussie !", "confirmation", MessageBoxButtons.OK);
                    }
                    
                }
                catch
                {
                    context.Entry(unTL).State = EntityState.Unchanged; 
                    TriathlonBinding.ResetCurrentItem();
                }

            }
      
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            TriathlonBinding.CancelEdit();

        }

        private void tabControlTriathlon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlTriathlon.SelectedIndex == 0)
            {
                TriathlonBinding.CancelEdit();
            }
        
           
        }
        /// <summary>
        /// Supprime un triathlon de la base de données, un trigger s'occupe de supprimer les inscription est verification associées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            TRIATHLON leT = (TRIATHLON)TriathlonBinding.Current;

            try
            {
                DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer le controle ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    context.TRIATHLONs.Remove(leT);
                    context.SaveChanges();
                    tabControlTriathlon.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                context.Entry(leT).State = EntityState.Unchanged;
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// permet d'ajouter un nouveau triathlon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControlTriathlon.SelectedIndex = 1;
            TriathlonBinding.AddNew();
            isNew = true;
            txtNumTri.Enabled = true;
        }
    }
}
