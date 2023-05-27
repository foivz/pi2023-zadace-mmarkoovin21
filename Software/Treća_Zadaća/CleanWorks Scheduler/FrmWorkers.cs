using CleanWorks_Scheduler.Models;
using CleanWorks_Scheduler.Repositories;
using DBLayer;
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
    public partial class FrmWorkers : Form
    {
        public FrmWorkers()
        {
            InitializeComponent();
        }

        private void FrmWorkers_Load(object sender, EventArgs e)
        {
            ShowWorkers();
        }
        private void ShowWorkers()
        {
            List<Worker> workers = WorkerRepository.GetWorkers();
            dgvWorkers.DataSource = workers;

            dgvWorkers.Columns["Id"].HeaderText = "ID";
            dgvWorkers.Columns["FirstName"].HeaderText = "Ime";
            dgvWorkers.Columns["LastName"].HeaderText = "Prezime";
            dgvWorkers.Columns["OIB"].HeaderText = "OIB";
            dgvWorkers.Columns["Adress"].HeaderText = "Addresa";
            dgvWorkers.Columns["MailWorker"].HeaderText = "E-mail";
            dgvWorkers.Columns["PhoneNumber"].HeaderText = "Broj mobitela";
            dgvWorkers.Columns["Password"].HeaderText = "Šifra";

            dgvWorkers.Columns["Id"].DisplayIndex = 0;
            dgvWorkers.Columns["FirstName"].DisplayIndex = 1;
            dgvWorkers.Columns["LastName"].DisplayIndex = 2;
            dgvWorkers.Columns["OIB"].DisplayIndex = 3;
            dgvWorkers.Columns["Adress"].DisplayIndex = 4;
            dgvWorkers.Columns["MailWorker"].DisplayIndex = 5;
            dgvWorkers.Columns["PhoneNumber"].DisplayIndex = 6;
            dgvWorkers.Columns["Password"].DisplayIndex = 7;
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

        private void btnWorkerAdd_Click(object sender, EventArgs e)
        {
            FrmAddWorker frmAddWorker = new FrmAddWorker();
            frmAddWorker.ShowDialog();
        }

        private void btnWorkerEdit_Click(object sender, EventArgs e)
        {
            FrmEditWorker frmEditWorker = new FrmEditWorker();
            frmEditWorker.ShowDialog();
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
    }
}
