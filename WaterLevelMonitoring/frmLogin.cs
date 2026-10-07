using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WaterLevelMonitoring
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
            {
                frmMain mainForm = new frmMain();
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Username atau password salah.",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
