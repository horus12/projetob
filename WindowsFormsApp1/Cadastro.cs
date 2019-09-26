using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WindowsFormsApp1
{
    public partial class Cadastro : Form
    {
        Login frm;
        public Cadastro(Login login)
        {
         
            InitializeComponent();
            frm = login;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          


        }

        void maskValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frm.Show();
            this.Dispose();
            


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Mongo mongo = new Mongo();
            CadastrarUsuario cadastrarUsuario = new CadastrarUsuario(mongo.getserver());
            User user = new User(tbNome.Text,tbSenha.Text,tbmCpf.Text,tbRg.Text);
            var status = cadastrarUsuario.cadastro(user);

            if (status.Equals("user_existent"))
            {
                string text = "Usuario ja cadastrado";
                MessageBox.Show(text);
                clearFields();
            }
            else if (status.Equals("success"))
            {
                MessageBox.Show("Usuario cadastrado com exito");
                frm.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Algum campo esta em branco");
            }
           
                

        }
        private void clearFields()
        {
            tbmCpf.Text = "";
            tbNome.Text = "";
            tbRg.Text = "";
            tbSenha.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSenha_Lostfocus(object sender, EventArgs e)
        {
            Regex AlphaRegex = new Regex("([a-zA-Z0-9])$");

            if (!AlphaRegex.IsMatch(this.tbSenha.Text))
            {
                lbInvalidPassword.Visible = true;
            }
            else
            {
                lbInvalidPassword.Visible = false;
            }

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
