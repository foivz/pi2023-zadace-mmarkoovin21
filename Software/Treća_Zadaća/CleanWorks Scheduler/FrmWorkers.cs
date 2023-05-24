using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CleanWorks_Scheduler.Models;
using CleanWorks_Scheduler.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CleanWorks_Scheduler
{
    public partial class FrmWorkers : MaterialForm
    {
        public FrmWorkers()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinMannager = MaterialSkinManager.Instance;
            materialSkinMannager.AddFormToManage(this);
            const MaterialSkinManager.Themes lIGHT = MaterialSkinManager.Themes.LIGHT;

            materialSkinMannager.Theme = lIGHT;

            materialSkinMannager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Worker> workers = WorkerRepository.GetWorkers();
            dgvWorkers.DataSource = workers;
        }

        private void btnWorkerDelete_Click(object sender, EventArgs e)
        {

        }

    }
}
