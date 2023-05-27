using MaterialSkin.Controls;
using MaterialSkin;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using CleanWorks_Scheduler.Models;
using CleanWorks_Scheduler.Repositories;

namespace CleanWorks_Scheduler
{
    public partial class FrmLogin : Form
    {
        //string username = "admin";
        //string password = "123456789";
        public static Admin LoggedAdmin { get; set; }
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void Prijava_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else
            {
                /*if (txtUsername.Text == username && txtPassword.Text == password)
                {
                    FrmChoice frmChoice = new FrmChoice();
                    Hide();
                    frmChoice.ShowDialog();
                    Close();
                } 
                */
                LoggedAdmin = AdminRepository.GetAdmin(txtUsername.Text);

                if(LoggedAdmin != null && LoggedAdmin.Password == txtPassword.Text)
                {
                    FrmChoice frmChoice = new FrmChoice();
                    Hide();
                    frmChoice.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

        }
    }
}
