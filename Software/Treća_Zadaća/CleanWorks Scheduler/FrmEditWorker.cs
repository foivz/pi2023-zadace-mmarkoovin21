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

namespace CleanWorks_Scheduler
{
    public partial class FrmEditWorker : Form
    {
        private Worker worker;

        public FrmEditWorker()
        {
            InitializeComponent();

        }

        public FrmEditWorker(Worker worker) : this()
        {
            this.worker = worker;
        }

        private void FrmEditWorker_Load(object sender, EventArgs e)
        {
            if (worker != null)
            {
                txtFirstName.Text = worker.FirstName;
                txtLastName.Text = worker.LastName;
                txtAdress.Text = worker.Adress;
                txtMail.Text = worker.MailWorker;
                txtOIB.Text = worker.OIB;
                txtTelephone.Text = worker.PhoneNumber;
                txtPasswordGenerator.Text = worker.Password.ToString();
            }
        }

        private void btnSaveWorker_Click(object sender, EventArgs e)
        {
            if (worker != null)
            {
                worker.FirstName = txtFirstName.Text;
                worker.LastName = txtLastName.Text;
                worker.Adress = txtAdress.Text;
                worker.MailWorker = txtMail.Text;
                worker.OIB = txtOIB.Text;
                worker.PhoneNumber = txtTelephone.Text;
                worker.Password = int.Parse(txtPasswordGenerator.Text);

                WorkerRepository.UpdateWorker(worker);

                MessageBox.Show("Radnik uspješno ažuriran.");
            }

            Close();
        }

        private void btnPasswordGenerator_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int sifra = random.Next(1000000, 9999999);
            txtPasswordGenerator.Text = sifra.ToString();
        }
    }

}