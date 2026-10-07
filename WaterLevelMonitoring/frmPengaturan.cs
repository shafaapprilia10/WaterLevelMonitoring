using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WaterLevelMonitoring
{
    public partial class frmPengaturan : Form
    {
        public frmPengaturan()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            decimal tinggiWadah = nudTinggiWadah.Value;

            MessageBox.Show(
                $"Pengaturan berhasil disimpan.\n\n" +
                $"Tinggi wadah: {tinggiWadah:0.00} cm",
                "Pengaturan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
