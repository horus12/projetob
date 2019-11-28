using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuInicial : BaseForm
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
                cadastroDeAlimentosToolStripMenuItem.Visible = false;
                exclusaoDeAlimentoToolStripMenuItem.Visible = false;
                alteracaoDeAlimentoToolStripMenuItem.Visible = false;
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

        private void desbloqueioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var desbloqueio = new Desbloqueio();
            desbloqueio.ShowDialog();
        }

        private void excluirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var excluir = new ExclusaoUser();
            excluir.ShowDialog();
        }

        private void calcularCaloriasConsumidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var calculadoraCaloriasDiarias = new calculadoraCaloriasDiarias();
                calculadoraCaloriasDiarias.ShowDialog();
            }
            catch (Exception eNTRY)
            {
                MessageBox.Show("Não existem produtos cadastrados");
            }
        }

        private void cadastroDeAlimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var cadastrarProduto = new CadastroDeProduto();
            cadastrarProduto.ShowDialog();
        }

        private void exclusaoDeAlimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var excluirProduto =  new ExcluirProduto();
            excluirProduto.ShowDialog();
        }

        private void alteracaoDeAlimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var alterarProduto = new AlterarProduto();
            alterarProduto.ShowDialog();
        }

        private void consultarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultarProduto = new ConsultarProdutos();
            consultarProduto.ShowDialog();
        }
    }
}
