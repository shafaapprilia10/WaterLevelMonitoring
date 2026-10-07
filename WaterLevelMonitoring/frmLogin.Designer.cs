namespace WaterLevelMonitoring
{
    partial class frmLogin
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
            lblFooter = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            pnlLogin = new Panel();
            btnLogin = new Button();
            lblTitle = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblWelcomeTitle = new Label();
            pnlWelcome = new Panel();
            pnlLogin.SuspendLayout();
            pnlWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // lblFooter
            // 
            lblFooter.ForeColor = Color.Gray;
            lblFooter.Location = new Point(84, 415);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(330, 25);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Water Level Monitoring System";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(64, 115);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(350, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Monitoring System";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(64, 167);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 19);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(64, 235);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lblFooter);
            pnlLogin.Controls.Add(lblTitle);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblSubtitle);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Location = new Point(436, 57);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(488, 458);
            pnlLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(64, 324);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(64, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 35);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "WATER LEVEL MONITORING";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(64, 258);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 23);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(64, 198);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 23);
            txtUsername.TabIndex = 5;
            // 
            // lblWelcomeTitle
            // 
            lblWelcomeTitle.BackColor = Color.Transparent;
            lblWelcomeTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeTitle.ForeColor = Color.Black;
            lblWelcomeTitle.Location = new Point(45, 160);
            lblWelcomeTitle.Name = "lblWelcomeTitle";
            lblWelcomeTitle.Size = new Size(320, 45);
            lblWelcomeTitle.TabIndex = 0;
            lblWelcomeTitle.Text = "WATER LEVEL MONITORING";
            lblWelcomeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlWelcome
            // 
            pnlWelcome.BackgroundImage = Properties.Resources.Group_28360;
            pnlWelcome.Controls.Add(lblWelcomeTitle);
            pnlWelcome.Location = new Point(0, 0);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(400, 600);
            pnlWelcome.TabIndex = 5;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(984, 561);
            Controls.Add(pnlWelcome);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Water Level Monitoring";
            Load += frmLogin_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlWelcome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblFooter;
        private Label lblSubtitle;
        private Label lblUsername;
        private Label lblPassword;
        private Panel pnlLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblTitle;
        private Label lblWelcomeTitle;
        private Panel pnlWelcome;
    }
}