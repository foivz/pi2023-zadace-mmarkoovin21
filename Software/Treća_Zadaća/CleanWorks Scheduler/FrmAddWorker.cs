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
    public partial class FrmAddWorker : Form
    {
        public FrmAddWorker()
        {
            InitializeComponent();
        }

        private void FrmAddWorker_Load(object sender, EventArgs e)
        {

        }
        private void btnPasswordGenerator_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int sifra = random.Next(1000000, 9999999);
            txtPasswordGenerator.Text = sifra.ToString();

        }

        private void btnPasswordGenerator_Click_1(object sender, EventArgs e)
        {
            var random = new Random();
            int sifra = random.Next(1000000, 9999999);
            txtPasswordGenerator.Text = sifra.ToString();
        }

        private void btnSaveWorker_Click(object sender, EventArgs e)
        {
            AddWorker();
            Hide();
            Close();
            FrmWorkers frmWorkers = new FrmWorkers();
            frmWorkers.ShowDialog();
        }
        public void AddWorker()
        {
            int sifra = int.Parse(txtPasswordGenerator.Text);
            int id = int.Parse(txtId.Text);

            string sql = $"INSERT INTO Workers (Id, Ime, Prezime, Adresa, Mail, OIB, Broj_mobitela, Sifra) VALUES ('{id}','{txtFirstName.Text}','{txtLastName.Text}','{txtAdress.Text}','{txtMail.Text}','{txtOIB.Text}','{txtTelephone.Text}','{sifra}');";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
