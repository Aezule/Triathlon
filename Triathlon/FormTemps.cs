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

        }

        private void tabControlTemps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlTemps.SelectedIndex == 0)
            {
                TempsBinding.CancelEdit();
            }
        }
    }   
}
