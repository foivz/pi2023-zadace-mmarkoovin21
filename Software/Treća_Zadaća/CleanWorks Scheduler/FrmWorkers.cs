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
using DBLayer;
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

        public Worker OdabraniRed()
        {
            return dgvWorkers.CurrentRow.DataBoundItem as Worker;
        }
        private void btnWorkerDelete_Click(object sender, EventArgs e)
        {
            Worker worker = OdabraniRed();
            string sql = $"DELETE FROM Workers WHERE Id = '{worker.Id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            Hide();
            Close();
            FrmWorkers frmWorkers = new FrmWorkers();
            frmWorkers.ShowDialog();
        }

        
        private void btnWorkerEdit_Click(object sender, EventArgs e)
        {
            FrmEditWorker frmEditWorker = new FrmEditWorker();
            frmEditWorker.ShowDialog();
        }

        private void btnWorkerAdd_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
            FrmAddWorker frmAddWorker = new FrmAddWorker();
            frmAddWorker.ShowDialog();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Worker> workers = WorkerRepository.GetWorkerByName(txtSearchWorker.Text, txtSearchWorker.Text);
            dgvWorkers.DataSource = workers;
            if (txtSearchWorker.Text == "")
            {
                Hide();
                Close();
                FrmWorkers frmWorkers = new FrmWorkers();
                frmWorkers.ShowDialog();
            }
        }
    }
}
