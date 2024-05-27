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

namespace Triathlon
{
    public partial class FormClassement : Form
    {
        public FormClassement()
        {
            InitializeComponent();
            
        }
        TriathlonEntities context;
        TRIATHLON DesTriathlon = new TRIATHLON();
        

        /// <summary>
        /// méthode pour charger le chargement des données dans le datagrid suivant le triathlon sélectionné
        /// </summary>
        private void LoadClassement()
        {
            DesTriathlon = (TRIATHLON)TriathlonBinding.Current;
            dataGridClassement.DataSource = context.GetClassement(DesTriathlon.numTriathlon).ToList();
        }

        private void FormClassement_Load(object sender, EventArgs e)
        {
            try
            {
                context = new TriathlonEntities();
                context.TRIATHLONs.Load();
                TriathlonBinding.DataSource = context.TRIATHLONs.Local.ToBindingList();
                LoadClassement();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        private void TriathlonBinding_CurrentChanged(object sender, EventArgs e)
        {
            LoadClassement();

        }
    }
}
