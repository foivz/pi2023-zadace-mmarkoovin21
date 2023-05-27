using CleanWorks_Scheduler.Models;
using CleanWorks_Scheduler.Repositories;
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
    public partial class FrmEditWorker : Form
    {
        public FrmEditWorker()
        {
            InitializeComponent();
        }

        private void FrmEditWorker_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveWorker_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPasswordGenerator_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int sifra = random.Next(1000000, 9999999);
            txtPasswordGenerator.Text = sifra.ToString();
        }
    }
}
