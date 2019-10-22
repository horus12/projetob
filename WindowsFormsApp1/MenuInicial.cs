using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuInicial : WindowsFormsApp1.BaseForm
    {
        User user_;
        public MenuInicial(User user)
        {
            InitializeComponent();
            user_ = user;
        }
        private void MenuInicial_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void controleDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDeUsuario controleDeUsuario = new ControleDeUsuario();
            controleDeUsuario.ShowDialog();
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {
            if (user_.Profile == 2)
            {
                administraçãoToolStripMenuItem.Visible = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarSenha alterarSenha = new AlterarSenha(user_);
            alterarSenha.ShowDialog();
        }

        private void cALULADORADEPESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculadoraImc calculadoraImc = new CalculadoraImc();
            calculadoraImc.ShowDialog();
        }
    }
}
