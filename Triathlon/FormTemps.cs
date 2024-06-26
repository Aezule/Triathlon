﻿using System;
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
    public partial class FormTemps : Form
    {
        TriathlonEntities context;
        TRIATHLETE leTriathlete = new TRIATHLETE();
        public FormTemps()
        {
            InitializeComponent();
        }
        

        private void LoadTemps()
        {
            leTriathlete = (TRIATHLETE)TriathleteBinding.Current;

            if (leTriathlete != null)
            {
                List<INSCRIPTION> listInscriptionsDuTriathlete = (from unI in context.INSCRIPTIONs
                                                                  where unI.numeroTriathlete == leTriathlete.numeroTriathlete
                                                                  select unI).ToList();
                TempsBinding.DataSource = listInscriptionsDuTriathlete;
            }
        }

        private void FormTemps_Load(object sender, EventArgs e)
        {
 
            try
            {
                context = new TriathlonEntities();
                context.TRIATHLETEs.Load();
                context.INSCRIPTIONs.Load();
                TriathleteBinding.DataSource = context.TRIATHLETEs.Local.ToBindingList();
                LoadTemps();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    

        private void TriathleteBinding_CurrentChanged(object sender, EventArgs e)
        {
            LoadTemps();
            if (TempsBinding == null || TempsBinding.Count == 0 )
            {     
                    tabControlTemps.TabPages.Remove(tabPageDetails);
            }
            else
            {
                if (!tabControlTemps.TabPages.Contains(tabPageDetails))
                {
                    tabControlTemps.TabPages.Add(tabPageDetails);
                }
            }   
        }

        private void tabControlTemps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlTemps.SelectedIndex == 0)
            {
                TempsBinding.CancelEdit();
            }
            else
            {
                INSCRIPTION unInscription = (INSCRIPTION)TempsBinding.Current;
                txtBoxTotal.Text = (unInscription.tempsCourseCyscliste + unInscription.tempsCourse + unInscription.tempsNatation).ToString();
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            INSCRIPTION unInscription = (INSCRIPTION)TempsBinding.Current;
            unInscription.tempsCourseCyscliste = 0;
            unInscription.tempsCourse = 0;
            unInscription.tempsNatation = 0;
            context.SaveChanges();
            TempsBinding.ResetCurrentItem();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            TempsBinding.EndEdit();
            context.SaveChanges();
            INSCRIPTION unInscription = (INSCRIPTION)TempsBinding.Current;
            txtBoxTotal.Text = (unInscription.tempsCourseCyscliste + unInscription.tempsCourse + unInscription.tempsNatation).ToString();

        }
    }   
}
