namespace WaterLevelMonitoring
{
    partial class frmTentang
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
            btnKembali = new Button();
            label1 = new Label();
            lblInformasi = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(42, 9);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(204, 37);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Tentang Sistem";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(51, 371);
            btnKembali.Margin = new Padding(4);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(100, 35);
            btnKembali.TabIndex = 4;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(369, 21);
            label1.TabIndex = 5;
            label1.Text = "Informasi komponen dan teknologi yang digunakan";
            // 
            // lblInformasi
            // 
            lblInformasi.AutoSize = true;
            lblInformasi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblInformasi.Location = new Point(51, 102);
            lblInformasi.Margin = new Padding(4, 0, 4, 0);
            lblInformasi.Name = "lblInformasi";
            lblInformasi.Size = new Size(117, 21);
            lblInformasi.TabIndex = 2;
            lblInformasi.Text = "1. Arduino Uno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(51, 136);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(276, 76);
            label2.TabIndex = 6;
            label2.Text = "- Mikrometer Uno R3 ATmega 328P CH340\r\n- Operating Voltage 5V\r\n- 14 Digital I/O (6 PWM output)\r\n- 6 Analog Input\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(223, 21);
            label3.TabIndex = 7;
            label3.Text = "2. HC-SR04 Sensor Ultrasonik";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 225);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 21);
            label4.TabIndex = 8;
            label4.Text = "3. C# Windows Forms";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 225);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(184, 21);
            label5.TabIndex = 9;
            label5.Text = "4. Microsoft SQL Server";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(449, 136);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(206, 57);
            label8.TabIndex = 13;
            label8.Text = "- Tegangan Kerja 5V\r\n- Jarak Pengukuran 2-400 cm\r\n- 4 Pin (VCC, TRIG, ECHO, GND)\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(51, 259);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(228, 57);
            label6.TabIndex = 14;
            label6.Text = "- Framework .NET\r\n- Aplikasi Dekstop (Windows Form)\r\n- Komunikasi Serial dengan Arduino\r\n";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(449, 259);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(248, 19);
            label7.TabIndex = 15;
            label7.Text = "- Menyimpan Seluruh Data Monitoring";
            label7.Click += label7_Click;
            // 
            // frmTentang
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblInformasi);
            Controls.Add(label1);
            Controls.Add(btnKembali);
            Controls.Add(lblJudul);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmTentang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tentang Aplikasi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Button btnKembali;
        private Label label1;
        private Label lblInformasi;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label6;
        private Label label7;
    }
}