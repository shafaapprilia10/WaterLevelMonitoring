namespace WaterLevelMonitoring
{
    partial class frmPengaturan
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
            lblJudul = new Label();
            lblTinggiWadah = new Label();
            nudTinggiWadah = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSimpan = new Button();
            btnKembali = new Button();
            label8 = new Label();
            pnlParameter = new Panel();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudTinggiWadah).BeginInit();
            pnlParameter.SuspendLayout();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(20, 19);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(247, 37);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Pengaturan Sistem";
            // 
            // lblTinggiWadah
            // 
            lblTinggiWadah.AutoSize = true;
            lblTinggiWadah.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTinggiWadah.Location = new Point(15, 46);
            lblTinggiWadah.Name = "lblTinggiWadah";
            lblTinggiWadah.Size = new Size(218, 21);
            lblTinggiWadah.TabIndex = 1;
            lblTinggiWadah.Text = "Tinggi Referensi Wadah (cm)";
            // 
            // nudTinggiWadah
            // 
            nudTinggiWadah.DecimalPlaces = 2;
            nudTinggiWadah.Location = new Point(15, 74);
            nudTinggiWadah.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudTinggiWadah.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            nudTinggiWadah.Name = "nudTinggiWadah";
            nudTinggiWadah.Size = new Size(120, 23);
            nudTinggiWadah.TabIndex = 2;
            nudTinggiWadah.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(15, 132);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 3;
            label1.Text = "Batas Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 162);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Normal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 189);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Tinggi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 217);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 6;
            label4.Text = "Hampir Penuh";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(133, 162);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 7;
            label5.Text = "< 70 %";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 189);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 8;
            label6.Text = "70 - 90 %";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(133, 217);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 9;
            label7.Text = "> 90 %";
            label7.Click += label7_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(20, 368);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 35);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "Simpan Pengaturan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnKembali
            // 
            btnKembali.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.Location = new Point(459, 368);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(100, 35);
            btnKembali.TabIndex = 11;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 66);
            label8.Name = "label8";
            label8.Size = new Size(290, 21);
            label8.TabIndex = 12;
            label8.Text = "Atur parameter sistem sesuai kebutuhan";
            // 
            // pnlParameter
            // 
            pnlParameter.BackColor = Color.White;
            pnlParameter.Controls.Add(label9);
            pnlParameter.Controls.Add(lblTinggiWadah);
            pnlParameter.Controls.Add(nudTinggiWadah);
            pnlParameter.Controls.Add(label1);
            pnlParameter.Controls.Add(label2);
            pnlParameter.Controls.Add(label7);
            pnlParameter.Controls.Add(label5);
            pnlParameter.Controls.Add(label4);
            pnlParameter.Controls.Add(label6);
            pnlParameter.Controls.Add(label3);
            pnlParameter.Location = new Point(20, 105);
            pnlParameter.Name = "pnlParameter";
            pnlParameter.Size = new Size(539, 250);
            pnlParameter.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(15, 104);
            label9.Name = "label9";
            label9.Size = new Size(293, 15);
            label9.TabIndex = 10;
            label9.Text = "Masukkan tinggi maksimal dari sensor ke dasar wadah";
            // 
            // frmPengaturan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 411);
            Controls.Add(pnlParameter);
            Controls.Add(label8);
            Controls.Add(btnKembali);
            Controls.Add(lblJudul);
            Controls.Add(btnSimpan);
            Name = "frmPengaturan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pengaturan Sistem";
            ((System.ComponentModel.ISupportInitialize)nudTinggiWadah).EndInit();
            pnlParameter.ResumeLayout(false);
            pnlParameter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblTinggiWadah;
        private NumericUpDown nudTinggiWadah;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSimpan;
        private Button btnKembali;
        private Label label8;
        private Panel pnlParameter;
        private Label label9;
    }
}