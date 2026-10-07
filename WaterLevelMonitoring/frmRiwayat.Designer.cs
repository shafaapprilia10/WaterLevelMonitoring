namespace WaterLevelMonitoring
{
    partial class frmRiwayat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvRiwayat = new DataGridView();
            btnRefresh = new Button();
            btnKembali = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(266, 37);
            label1.TabIndex = 0;
            label1.Text = "Riwayat Monitoring ";
            label1.Click += label1_Click;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Location = new Point(88, 90);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.Size = new Size(700, 350);
            dgvRiwayat.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(88, 464);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnKembali
            // 
            btnKembali.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.Location = new Point(688, 464);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(100, 35);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 56);
            label2.Name = "label2";
            label2.Size = new Size(253, 21);
            label2.TabIndex = 4;
            label2.Text = "Data ketinggian air yang tersimpan";
            // 
            // frmRiwayat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(label2);
            Controls.Add(btnKembali);
            Controls.Add(btnRefresh);
            Controls.Add(dgvRiwayat);
            Controls.Add(label1);
            Name = "frmRiwayat";
            Text = "Riwayat Monitoring";
            Load += frmRiwayat_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvRiwayat;
        private Button btnRefresh;
        private Button btnKembali;
        private Label label2;
    }
}