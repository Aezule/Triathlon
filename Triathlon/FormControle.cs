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
        public FormControle()
        {
            InitializeComponent();
        }
        TriathlonEntities context;

        private void FormControle_Load(object sender, EventArgs e)
        {
            try
            {
                context = new TriathlonEntities();
                context.VERIFIERs.Load();
                VerifBinding.DataSource = context.VERIFIERs.Local.ToBindingList();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        
    }
}
