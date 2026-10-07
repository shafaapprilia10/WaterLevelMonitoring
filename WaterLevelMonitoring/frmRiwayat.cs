using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterLevelMonitoring
{
    public partial class frmRiwayat : Form
    {
        public frmRiwayat()
        {
            InitializeComponent();
        }

        private void frmRiwayat_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            string query = @"
        SELECT
            Id,
            Waktu,
            JarakCm,
            TinggiCm,
            Persentase,
            Status
        FROM Monitoring
        ORDER BY Id DESC";

            try
            {
                using (SqlConnection connection =
                    DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dgvRiwayat.DataSource = table;
                    }
                }

                // Mengatur tampilan kolom
                dgvRiwayat.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvRiwayat.ReadOnly = true;
                dgvRiwayat.AllowUserToAddRows = false;
                dgvRiwayat.AllowUserToDeleteRows = false;
                dgvRiwayat.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil riwayat monitoring.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

