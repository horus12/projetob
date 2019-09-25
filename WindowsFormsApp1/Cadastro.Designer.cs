namespace WindowsFormsApp1
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbRg = new System.Windows.Forms.TextBox();
            this.tbmCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lbWelcomeMsg = new System.Windows.Forms.Label();
            this.lbInvalidPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite seu CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digite seu nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Digite sua senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Digite seu RG:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(28, 200);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(109, 20);
            this.tbNome.TabIndex = 1;
            this.tbNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(28, 250);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(109, 20);
            this.tbSenha.TabIndex = 2;
            this.tbSenha.LostFocus += new System.EventHandler(this.tbSenha_Lostfocus);
            // 
            // tbRg
            // 
            this.tbRg.Location = new System.Drawing.Point(28, 300);
            this.tbRg.Name = "tbRg";
            this.tbRg.Size = new System.Drawing.Size(109, 20);
            this.tbRg.TabIndex = 3;
            // 
            // tbmCpf
            // 
            this.tbmCpf.Location = new System.Drawing.Point(28, 120);
            this.tbmCpf.Mask = "000,000,000-00";
            this.tbmCpf.Name = "tbmCpf";
            this.tbmCpf.Size = new System.Drawing.Size(100, 20);
            this.tbmCpf.TabIndex = 0;
            this.tbmCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvoltar.Location = new System.Drawing.Point(632, 415);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Location = new System.Drawing.Point(713, 415);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // lbWelcomeMsg
            // 
            this.lbWelcomeMsg.AutoSize = true;
            this.lbWelcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeMsg.Location = new System.Drawing.Point(28, 24);
            this.lbWelcomeMsg.Name = "lbWelcomeMsg";
            this.lbWelcomeMsg.Size = new System.Drawing.Size(460, 25);
            this.lbWelcomeMsg.TabIndex = 6;
            this.lbWelcomeMsg.Text = "Preencha seus dados para efetuar o Cadastro.";
            this.lbWelcomeMsg.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbInvalidPassword
            // 
            this.lbInvalidPassword.AutoSize = true;
            this.lbInvalidPassword.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidPassword.Location = new System.Drawing.Point(144, 256);
            this.lbInvalidPassword.Name = "lbInvalidPassword";
            this.lbInvalidPassword.Size = new System.Drawing.Size(115, 13);
            this.lbInvalidPassword.TabIndex = 11;
            this.lbInvalidPassword.Text = "INVALID PASSWORD";
            this.lbInvalidPassword.Visible = false;
            this.lbInvalidPassword.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 453);
            this.Controls.Add(this.lbInvalidPassword);
            this.Controls.Add(this.lbWelcomeMsg);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.tbmCpf);
            this.Controls.Add(this.tbRg);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastrar um usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbRg;
        private System.Windows.Forms.MaskedTextBox tbmCpf;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbWelcomeMsg;
        private System.Windows.Forms.Label lbInvalidPassword;
    }
}