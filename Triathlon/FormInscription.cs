using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Triathlon
{
    public partial class FormInscription : Form
    {

        /// <summary>
        /// Contexte utilisé pour accéder aux DbSets de la base de données
        /// </summary>
        private TriathlonEntities context;

        public FormInscription()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement des ressources du contexte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInscription_Load(object sender, EventArgs e)
        {
            try
            {

                context = new TriathlonEntities();
                context.INSCRIPTIONs.Load();
                context.TRIATHLONs.Load();

                bindingSourceTriathlons.DataSource = context.TRIATHLONs.Local.ToBindingList();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// Ajoute une nouvelle inscription avec les données receuillis sur le formulaire d'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterInscription_Click(object sender, EventArgs e)
        {
            INSCRIPTION laNouvelInscription = new INSCRIPTION();



            bool triathlonExiste = (from unT in context.TRIATHLONs
                              where unT.numTriathlon == txtTriathlon.Text
                              select unT).Any();


          

        }

        /// <summary>
        /// Supprime l'inscription séléectionné dans le binding source des inscriptions du datagrid de la page supprimer inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerInscription_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Affiche les inscriptions du Triathlon sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingSourceTriathlons_CurrentChanged(object sender, EventArgs e)
        {
            //On récupère le triathlon de la combobox via le binding
            TRIATHLON leT = (TRIATHLON)bindingSourceTriathlons.Current;

            //On récupère via une requete linq les inscriptions liés au triathlon
            List<INSCRIPTION> lesInscriptionsDuTriathlon = (from unI in context.INSCRIPTIONs
                                                            where unI.numTriathlon == leT.numTriathlon
                                                            select unI).ToList();

            //On applique au bindingSource les inscriptions.
            bindingSourceInscriptionsDunTriathlon.DataSource = lesInscriptionsDuTriathlon;

            if(bindingSourceInscriptionsDunTriathlon.Count == 0)
            {
                labelNoInscription.Visible = true;
            }
            else
            {
                labelNoInscription.Visible = false;
            }
        }
    }
}
