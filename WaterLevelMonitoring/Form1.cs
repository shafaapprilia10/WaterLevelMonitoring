using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using FontAwesome.Sharp;


namespace WaterLevelMonitoring
{
    public partial class frmMain : Form
    {
        // Random digunakan untuk membuat data sensor simulasi
        private Random random = new Random();

        // Tinggi wadah yang kita gunakan
        private const decimal TINGGI_WADAH = 20.00m;

        public frmMain()
        {
            InitializeComponent();

            // Menampilkan data terakhir dari SQL Server
            LoadLatestMonitoring();
        }

        // =========================================================
        // MENGAMBIL DATA TERBARU DARI SQL SERVER
        // =========================================================
        private void LoadLatestMonitoring()
        {
            string query = @"
                SELECT TOP 1
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

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader =
                            command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal jarak =
                                    reader.GetDecimal(
                                        reader.GetOrdinal("JarakCm"));

                                decimal tinggi =
                                    reader.GetDecimal(
                                        reader.GetOrdinal("TinggiCm"));

                                decimal persentase =
                                    reader.GetDecimal(
                                        reader.GetOrdinal("Persentase"));

                                string status =
                                    reader.GetString(
                                        reader.GetOrdinal("Status"));

                                // Menampilkan data ke Dashboard
                                lblJarakValue.Text =
                                    $"{jarak:0.00} cm";

                                lblKetinggianValue.Text =
                                    $"{tinggi:0.00} cm";

                                lblPersentaseValue.Text =
                                    $"{persentase:0.00} %";

                                lblStatusValue.Text =
                                    status;
                            }
                            else
                            {
                                // Jika database belum mempunyai data
                                lblJarakValue.Text = "0.00 cm";
                                lblKetinggianValue.Text = "0.00 cm";
                                lblPersentaseValue.Text = "0.00 %";
                                lblStatusValue.Text = "BELUM ADA DATA";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data monitoring.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // MEMBUAT DATA SENSOR SIMULASI
        // =========================================================
        private void GenerateSimulationData()
        {
            // Jarak sensor terhadap permukaan air
            // Untuk sementara dibuat secara acak 2 - 18 cm
            decimal jarakSensor =
                random.Next(2, 19);

            // Rumus tinggi air
            decimal tinggiAir =
                TINGGI_WADAH - jarakSensor;

            // Rumus persentase ketinggian air
            decimal persentase =
                (tinggiAir / TINGGI_WADAH) * 100;

            string status;

            // Menentukan status berdasarkan persentase
            if (persentase >= 90)
            {
                status = "HAMPIR PENUH";
            }
            else if (persentase >= 70)
            {
                status = "TINGGI";
            }
            else
            {
                status = "NORMAL";
            }

            // Simpan hasil simulasi ke SQL Server
            SaveMonitoringData(
                jarakSensor,
                tinggiAir,
                persentase,
                status
            );
        }

        // =========================================================
        // MENYIMPAN DATA KE SQL SERVER
        // =========================================================
        private void SaveMonitoringData(
    decimal jarak,
    decimal tinggi,
    decimal persentase,
    string status)
        {
            string query = @"
        INSERT INTO Monitoring
        (
            Waktu,
            JarakCm,
            TinggiCm,
            Persentase,
            Status
        )
        VALUES
        (
            GETDATE(),
            @JarakCm,
            @TinggiCm,
            @Persentase,
            @Status
        )";

            try
            {
                using (SqlConnection connection =
                    DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@JarakCm",
                            jarak);

                        command.Parameters.AddWithValue(
                            "@TinggiCm",
                            tinggi);

                        command.Parameters.AddWithValue(
                            "@Persentase",
                            persentase);

                        command.Parameters.AddWithValue(
                            "@Status",
                            status);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();

                MessageBox.Show(
                    "Gagal menyimpan data monitoring.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // TIMER
        // =========================================================
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Membuat data sensor simulasi
            GenerateSimulationData();

            // Membaca kembali data terbaru
            // kemudian menampilkannya ke Dashboard
            LoadLatestMonitoring();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            frmRiwayat formRiwayat = new frmRiwayat();

            formRiwayat.ShowDialog();
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            frmPengaturan formPengaturan = new frmPengaturan();

            formPengaturan.ShowDialog();
        }

        private void btnTentang_Click(object sender, EventArgs e)
        {
            frmTentang formTentang = new frmTentang();

            formTentang.ShowDialog();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSqlConnection_Click(object sender, EventArgs e)
        {

        }
    }
}