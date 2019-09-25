namespace WindowsFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbIntro = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbRegister = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbTextUser = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIntro
            // 
            this.lbIntro.AutoSize = true;
            this.lbIntro.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntro.Location = new System.Drawing.Point(-1, 9);
            this.lbIntro.Name = "lbIntro";
            this.lbIntro.Size = new System.Drawing.Size(558, 37);
            this.lbIntro.TabIndex = 0;
            this.lbIntro.Text = "Bem vindo a sua nova calculadora de Calorias";
            this.lbIntro.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.maskedTextBox1);
            this.gbLogin.Controls.Add(this.btLogin);
            this.gbLogin.Controls.Add(this.lbRegister);
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.lbPassword);
            this.gbLogin.Controls.Add(this.lbTextUser);
            this.gbLogin.Location = new System.Drawing.Point(18, 118);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(305, 225);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login de usuario";
            this.gbLogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedTextBox1.Location = new System.Drawing.Point(23, 47);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogin.Location = new System.Drawing.Point(224, 196);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbRegister.Location = new System.Drawing.Point(20, 115);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(135, 13);
            this.lbRegister.TabIndex = 4;
            this.lbRegister.Text = "Cadastrar uma nova conta.";
            this.lbRegister.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Location = new System.Drawing.Point(23, 88);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 13);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(20, 72);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(86, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Digite sua senha";
            this.lbPassword.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbTextUser
            // 
            this.lbTextUser.AutoSize = true;
            this.lbTextUser.Location = new System.Drawing.Point(20, 31);
            this.lbTextUser.Name = "lbTextUser";
            this.lbTextUser.Size = new System.Drawing.Size(43, 13);
            this.lbTextUser.TabIndex = 0;
            this.lbTextUser.Text = "Usuário";
            this.lbTextUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.lbIntro);
            this.Name = "Login";
            this.Text = "Calculadora de calorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIntro;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lbTextUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

