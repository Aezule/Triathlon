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
    public partial class FormTriathlon : Form
    {
        public FormTriathlon()
        {
            InitializeComponent();
        }
        TriathlonEntities context;

        private void FormTriathlon_Load(object sender, EventArgs e)
        {
            try
            {

                context = new TriathlonEntities();
                context.TRIATHLONs.Load();
           
                TriathlonBinding.DataSource = context.TRIATHLONs.Local.ToBindingList();
    
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridTriathlon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TRIATHLON leTriathlon = (TRIATHLON)TriathlonBinding.Current;
            tabControlTriathlon.SelectedIndex = 1;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
           /*
            
            Erreur voir plus tard
             
            TRIATHLON unTL = (TRIATHLON)TriathlonBinding.Current;
            try
            {  
                TriathlonBinding.EndEdit();
                context.TRIATHLONs.Add(unTL);
                context.SaveChanges();
                TriathlonBinding.ResetBindings(false);

            }
            catch (Exception ex)
            {

                context.Entry((TRIATHLON)TriathlonBinding.Current).State = EntityState.Unchanged;
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           */
        }
    }
}
