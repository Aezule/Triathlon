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
            tabControlTriathlon.SelectedIndex = 1;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir modifier le triathlon ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                TRIATHLON unTL = new TRIATHLON();
                unTL = (TRIATHLON)TriathlonBinding.Current;
                try
                {
                    TriathlonBinding.EndEdit();
                    context.SaveChanges();
                    MessageBox.Show("Modification réussie !", "confirmation", MessageBoxButtons.OK);
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

     
    }
}
