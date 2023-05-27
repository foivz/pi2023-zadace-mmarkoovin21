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


        private void btnSaveWorker_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.Id= int.Parse(numID.Text);
            worker.FirstName=txtFirstName.Text;
            worker.LastName=txtLastName.Text;
            worker.MailWorker = txtMail.Text;
            worker.OIB= txtOIB.Text;
            worker.Adress = txtAdress.Text;
            worker.PhoneNumber = txtTelephone.Text;
            worker.Password=int.Parse(txtPasswordGenerator.Text);
            WorkerRepository.UpdateWorker(worker);
            Hide();
            Close();
        }

        private void btnPasswordGenerator_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int sifra = random.Next(1000000, 9999999);
            txtPasswordGenerator.Text = sifra.ToString();
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            int id = int.Parse(numID.Text);
            Worker worker = WorkerRepository.GetWorker(id);
            txtFirstName.Text = worker.FirstName.ToString();
            txtLastName.Text = worker.LastName.ToString();
            txtMail.Text=worker.MailWorker.ToString();
            txtOIB.Text=worker.OIB.ToString();
            txtTelephone.Text=worker.PhoneNumber.ToString();
            txtAdress.Text=worker.Adress.ToString();
            txtPasswordGenerator.Text = worker.Password.ToString();
        }
    }
}
