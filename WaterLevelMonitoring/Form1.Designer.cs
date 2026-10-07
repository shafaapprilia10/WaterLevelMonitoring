namespace WaterLevelMonitoring
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlSidebar = new Panel();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnTentang = new FontAwesome.Sharp.IconButton();
            btnPengaturan = new FontAwesome.Sharp.IconButton();
            btnRiwayat = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            lblSqlConnection = new Label();
            lblArduinoConnection = new Label();
            lblAppName = new Label();
            pnlContent = new Panel();
            label1 = new Label();
            lblContainerInfo = new Label();
            pnlStatus = new Panel();
            lblStatusValue = new Label();
            lblStatusTitle = new Label();
            pnlJarak = new Panel();
            lblJarakValue = new Label();
            lblJarakTitle = new Label();
            pnlPersentase = new Panel();
            lblPersentaseValue = new Label();
            lblPersentaseTitle = new Label();
            pnlKetinggian = new Panel();
            lblKetinggianValue = new Label();
            lblKetinggianTitle = new Label();
            lblTitle = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            pnlContent.SuspendLayout();
            pnlStatus.SuspendLayout();
            pnlJarak.SuspendLayout();
            pnlPersentase.SuspendLayout();
            pnlKetinggian.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.AliceBlue;
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.Controls.Add(iconPictureBox1);
            pnlSidebar.Controls.Add(btnTentang);
            pnlSidebar.Controls.Add(btnPengaturan);
            pnlSidebar.Controls.Add(btnRiwayat);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblSqlConnection);
            pnlSidebar.Controls.Add(lblArduinoConnection);
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(317, 561);
            pnlSidebar.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(70, 60);
            label2.Name = "label2";
            label2.Size = new Size(190, 21);
            label2.TabIndex = 17;
            label2.Text = "Monitoring Ketinggian Air";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.Blue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Tint;
            iconPictureBox1.IconColor = Color.Blue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 42;
            iconPictureBox1.Location = new Point(26, 42);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(42, 48);
            iconPictureBox1.TabIndex = 16;
            iconPictureBox1.TabStop = false;
            // 
            // btnTentang
            // 
            btnTentang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTentang.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnTentang.IconColor = Color.Black;
            btnTentang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTentang.IconSize = 25;
            btnTentang.Location = new Point(12, 354);
            btnTentang.Name = "btnTentang";
            btnTentang.Size = new Size(283, 58);
            btnTentang.TabIndex = 15;
            btnTentang.Text = "         Tentang";
            btnTentang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTentang.UseVisualStyleBackColor = true;
            btnTentang.Click += btnTentang_Click;
            // 
            // btnPengaturan
            // 
            btnPengaturan.BackColor = Color.White;
            btnPengaturan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPengaturan.IconChar = FontAwesome.Sharp.IconChar.Cog;
            btnPengaturan.IconColor = Color.Black;
            btnPengaturan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPengaturan.IconSize = 25;
            btnPengaturan.Location = new Point(12, 270);
            btnPengaturan.Name = "btnPengaturan";
            btnPengaturan.Size = new Size(283, 58);
            btnPengaturan.TabIndex = 14;
            btnPengaturan.Text = "        Pengaturan";
            btnPengaturan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPengaturan.UseVisualStyleBackColor = false;
            btnPengaturan.Click += btnPengaturan_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.White;
            btnRiwayat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayat.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            btnRiwayat.IconColor = Color.Black;
            btnRiwayat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRiwayat.IconSize = 25;
            btnRiwayat.Location = new Point(12, 190);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(283, 58);
            btnRiwayat.TabIndex = 13;
            btnRiwayat.Text = "          Riwayat";
            btnRiwayat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            btnDashboard.IconColor = Color.Black;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 25;
            btnDashboard.Location = new Point(12, 109);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(283, 58);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "          Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblSqlConnection
            // 
            lblSqlConnection.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSqlConnection.AutoSize = true;
            lblSqlConnection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSqlConnection.Location = new Point(60, 509);
            lblSqlConnection.Name = "lblSqlConnection";
            lblSqlConnection.Size = new Size(173, 21);
            lblSqlConnection.TabIndex = 6;
            lblSqlConnection.Text = "SQL Server : Terhubung";
            lblSqlConnection.Click += lblSqlConnection_Click;
            // 
            // lblArduinoConnection
            // 
            lblArduinoConnection.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblArduinoConnection.AutoSize = true;
            lblArduinoConnection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArduinoConnection.Location = new Point(71, 478);
            lblArduinoConnection.Name = "lblArduinoConnection";
            lblArduinoConnection.Size = new Size(153, 21);
            lblArduinoConnection.TabIndex = 5;
            lblArduinoConnection.Text = "Arduino : Menunggu";
            // 
            // lblAppName
            // 
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAppName.ForeColor = Color.SteelBlue;
            lblAppName.Location = new Point(65, 29);
            lblAppName.Margin = new Padding(0);
            lblAppName.Name = "lblAppName";
            lblAppName.RightToLeft = RightToLeft.No;
            lblAppName.Size = new Size(235, 40);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Water Level Monitor";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(label1);
            pnlContent.Controls.Add(lblContainerInfo);
            pnlContent.Controls.Add(pnlStatus);
            pnlContent.Controls.Add(pnlJarak);
            pnlContent.Controls.Add(pnlPersentase);
            pnlContent.Controls.Add(pnlKetinggian);
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(317, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(667, 561);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 69);
            label1.Name = "label1";
            label1.Size = new Size(312, 21);
            label1.TabIndex = 6;
            label1.Text = "Monitoring Ketinggian Air secara Real-Time";
            label1.Click += label1_Click;
            // 
            // lblContainerInfo
            // 
            lblContainerInfo.AutoSize = true;
            lblContainerInfo.Location = new Point(48, 95);
            lblContainerInfo.Name = "lblContainerInfo";
            lblContainerInfo.Size = new Size(137, 15);
            lblContainerInfo.TabIndex = 5;
            lblContainerInfo.Text = "Kapasitas Wadah : 20 cm";
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.LightGreen;
            pnlStatus.Controls.Add(lblStatusValue);
            pnlStatus.Controls.Add(lblStatusTitle);
            pnlStatus.Location = new Point(314, 344);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(235, 100);
            pnlStatus.TabIndex = 4;
            // 
            // lblStatusValue
            // 
            lblStatusValue.AutoSize = true;
            lblStatusValue.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblStatusValue.Location = new Point(0, 38);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(87, 30);
            lblStatusValue.TabIndex = 1;
            lblStatusValue.Text = "Normal";
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusTitle.Location = new Point(3, 0);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(80, 21);
            lblStatusTitle.TabIndex = 0;
            lblStatusTitle.Text = "Status Air";
            // 
            // pnlJarak
            // 
            pnlJarak.BackColor = Color.Plum;
            pnlJarak.Controls.Add(lblJarakValue);
            pnlJarak.Controls.Add(lblJarakTitle);
            pnlJarak.Location = new Point(45, 344);
            pnlJarak.Name = "pnlJarak";
            pnlJarak.Size = new Size(235, 100);
            pnlJarak.TabIndex = 3;
            // 
            // lblJarakValue
            // 
            lblJarakValue.AutoSize = true;
            lblJarakValue.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblJarakValue.Location = new Point(3, 38);
            lblJarakValue.Name = "lblJarakValue";
            lblJarakValue.Size = new Size(89, 30);
            lblJarakValue.TabIndex = 1;
            lblJarakValue.Text = "0.00 cm";
            // 
            // lblJarakTitle
            // 
            lblJarakTitle.AutoSize = true;
            lblJarakTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJarakTitle.Location = new Point(3, 0);
            lblJarakTitle.Name = "lblJarakTitle";
            lblJarakTitle.Size = new Size(100, 21);
            lblJarakTitle.TabIndex = 0;
            lblJarakTitle.Text = "Jarak Sensor";
            // 
            // pnlPersentase
            // 
            pnlPersentase.BackColor = Color.LightCyan;
            pnlPersentase.Controls.Add(lblPersentaseValue);
            pnlPersentase.Controls.Add(lblPersentaseTitle);
            pnlPersentase.Location = new Point(314, 173);
            pnlPersentase.Name = "pnlPersentase";
            pnlPersentase.Size = new Size(235, 100);
            pnlPersentase.TabIndex = 2;
            // 
            // lblPersentaseValue
            // 
            lblPersentaseValue.AutoSize = true;
            lblPersentaseValue.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblPersentaseValue.Location = new Point(3, 39);
            lblPersentaseValue.Name = "lblPersentaseValue";
            lblPersentaseValue.Size = new Size(78, 30);
            lblPersentaseValue.TabIndex = 1;
            lblPersentaseValue.Text = "0.00 %";
            // 
            // lblPersentaseTitle
            // 
            lblPersentaseTitle.AutoSize = true;
            lblPersentaseTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPersentaseTitle.Location = new Point(3, 0);
            lblPersentaseTitle.Name = "lblPersentaseTitle";
            lblPersentaseTitle.Size = new Size(130, 21);
            lblPersentaseTitle.TabIndex = 0;
            lblPersentaseTitle.Text = "Persentase Level";
            // 
            // pnlKetinggian
            // 
            pnlKetinggian.BackColor = Color.LightSteelBlue;
            pnlKetinggian.Controls.Add(lblKetinggianValue);
            pnlKetinggian.Controls.Add(lblKetinggianTitle);
            pnlKetinggian.Location = new Point(45, 173);
            pnlKetinggian.Name = "pnlKetinggian";
            pnlKetinggian.Size = new Size(235, 100);
            pnlKetinggian.TabIndex = 1;
            // 
            // lblKetinggianValue
            // 
            lblKetinggianValue.AutoSize = true;
            lblKetinggianValue.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblKetinggianValue.Location = new Point(3, 39);
            lblKetinggianValue.Name = "lblKetinggianValue";
            lblKetinggianValue.Size = new Size(89, 30);
            lblKetinggianValue.TabIndex = 1;
            lblKetinggianValue.Text = "0.00 cm";
            // 
            // lblKetinggianTitle
            // 
            lblKetinggianTitle.AutoSize = true;
            lblKetinggianTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetinggianTitle.Location = new Point(0, 0);
            lblKetinggianTitle.Name = "lblKetinggianTitle";
            lblKetinggianTitle.Size = new Size(114, 21);
            lblKetinggianTitle.TabIndex = 0;
            lblKetinggianTitle.Text = "Ketinggian Air";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(45, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(984, 561);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Water Level Monitoring";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            pnlJarak.ResumeLayout(false);
            pnlJarak.PerformLayout();
            pnlPersentase.ResumeLayout(false);
            pnlPersentase.PerformLayout();
            pnlKetinggian.ResumeLayout(false);
            pnlKetinggian.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlContent;
        private Label lblTitle;
        private Label lblAppName;
        private Panel pnlStatus;
        private Panel pnlJarak;
        private Panel pnlPersentase;
        private Panel pnlKetinggian;
        private Label lblKetinggianValue;
        private Label lblKetinggianTitle;
        private Label lblPersentaseValue;
        private Label lblPersentaseTitle;
        private Label lblJarakValue;
        private Label lblJarakTitle;
        private Label lblStatusValue;
        private Label lblStatusTitle;
        private Label lblSqlConnection;
        private Label lblArduinoConnection;
        private Label lblContainerInfo;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnRiwayat;
        private FontAwesome.Sharp.IconButton btnPengaturan;
        private FontAwesome.Sharp.IconButton btnTentang;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
