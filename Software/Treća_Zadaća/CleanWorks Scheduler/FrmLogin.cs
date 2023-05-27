using MaterialSkin.Controls;
using MaterialSkin;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using CleanWorks_Scheduler.Models;
using CleanWorks_Scheduler.Repositories;

namespace CleanWorks_Scheduler
{
    public partial class FrmLogin : MaterialForm
    {
        //string username = "admin";
        //string password = "123456789";
        public static Admin LoggedAdmin { get; set; }
        public FrmLogin()
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
