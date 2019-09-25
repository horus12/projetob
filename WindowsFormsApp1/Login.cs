using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
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
            var status =  loginUsecase.Login(maskedTextBox1.Text,tbPassword.Text);
            if(status.Equals("wrong_password"))
                MessageBox.Show("senha errada");
            else if (status.Equals("not_found"))
            {
                MessageBox.Show("senha errada");
            }
            else { 
                MessageBox.Show("Logando ...");
                MenuInicial menuInicial = new MenuInicial();
                menuInicial.Show();
                this.Hide();
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
