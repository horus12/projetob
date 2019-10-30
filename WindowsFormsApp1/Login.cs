using System;
using System.Windows.Forms;
using WindowsFormsApp1.exceptions;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private int tentativas = 1;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            this.Hide();

            Cadastro cadastro = new Cadastro(this);
            cadastro.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginUsecase loginUsecase = new LoginUsecase();
            try
            {
                User user = loginUsecase.Login(maskedTextBox1.Text, tbPassword.Text);
                MenuInicial menuInicial = new MenuInicial(user);
                menuInicial.Show();
                this.Hide();
            }
            catch (WrongcredentialsException ex)
            {
                tentativas++;
                if (tentativas > 4)
                {
                    var bloqueioUseCase = new BloqueioUseCase();
                    bloqueioUseCase.block(maskedTextBox1.Text);
                    MessageBox.Show("Usuário bloqueado, enviar seu CPF para: projetobsi2019@gmail.com solicitando desbloqueio");
                    return;
                }
                if (tentativas > 3)
                {
                    MessageBox.Show("Seu usuário será bloqueado se errar novamente suas credenciais");
                }
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}