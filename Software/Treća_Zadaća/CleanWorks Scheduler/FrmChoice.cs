using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanWorks_Scheduler
{
    public partial class FrmChoice : Form
    {
        public FrmChoice()
        {
            InitializeComponent();
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            FrmWorkers frmWorkers = new FrmWorkers();
            Hide();
            frmWorkers.ShowDialog();
            Close();
        }
    }
}
