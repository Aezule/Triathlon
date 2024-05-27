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
                      

            try
            {

                //Vérification de l'existance du trathlon et du triathlète afin d'éviter les erreurs dans la base de données
                bool triathlonExiste = (from unT in context.TRIATHLONs // Pour un Trathlon dans le Dbset des traithlons
                                        where unT.numTriathlon == txtTriathlon.Text //ou le numéri de triathlon est le même que celui inséré dans la textbox du formulaire
                                        select unT).Any(); //On sélection et on regarde s'il contient des éléments (Any())

                bool triathletExiste = (from unT in context.TRIATHLETEs
                                        where unT.numeroTriathlete == textTriathlete.Text
                                        select unT).Any();

                if(MessageBox.Show("Voulez vous ajouter cette inscription ?","Ajout Inscription",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!triathletExiste || !triathletExiste)
                    {
                        //Affiche la bonne erreur selon l'entré.
                        if (!triathletExiste)
                        {
                            MessageBox.Show("Le thriathlète n'existe pas", "Ajout Inscription", MessageBoxButtons.OK);
                        }
                        else if(!triathlonExiste){
                            MessageBox.Show("Le thriathlon n'existe pas", "Ajout Inscription", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        //Ajout d'une inscription
                        INSCRIPTION laNouvelInscription = new INSCRIPTION();

                        laNouvelInscription.TRIATHLETE = (from unT in context.TRIATHLETEs
                                                          where unT.numeroTriathlete == textTriathlete.Text
                                                          select unT).FirstOrDefault();

                        laNouvelInscription.TRIATHLON = (from unT in context.TRIATHLONs
                                                            where unT.numTriathlon == txtTriathlon.Text
                                                            select unT).FirstOrDefault();

                        laNouvelInscription.dateInscription = dtPickerDate.Value.Date;

                        //On ajoute une valeur par défaut pour le numéro de dossard afin qu'il soit bien validé par SQL, un Trigger se chargera de remplacer la valeur
                        laNouvelInscription.numDossard = "0";

                        context.INSCRIPTIONs.Add(laNouvelInscription);
                        context.SaveChanges();

                        //Affichage du message lors que l'ajout
                        MessageBox.Show("Inscription crée !", "Ajout Inscription", MessageBoxButtons.OK);

                        //On appelle la méthode pour refresh la datagrid
                        bindingSourceTriathlons_CurrentChanged(sender, e);


                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        /// <summary>
        /// Supprime l'inscription séléectionné dans le binding source des inscriptions du datagrid de la page supprimer inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerInscription_Click(object sender, EventArgs e)
        {
            INSCRIPTION laInscription = (INSCRIPTION)bindingSourceInscriptionsDunTriathlon.Current;

            //Message de confirmation
            try
            {
                DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer cette inscription ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //On retire l'inscription de la DbSet des inscriptions
                    context.INSCRIPTIONs.Remove(laInscription);
                    context.SaveChanges();

                    //On appelle la méthode pour refresh la datagrid
                    bindingSourceTriathlons_CurrentChanged(sender, e);
                    

                }
            }
            catch (Exception ex)
            {
                context.Entry(laInscription).State = EntityState.Unchanged;
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
