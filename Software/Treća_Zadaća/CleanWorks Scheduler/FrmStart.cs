﻿using System;
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
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
            Close();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {

        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcija ne radi!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}
