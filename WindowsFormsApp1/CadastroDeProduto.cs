using System;
using System.Windows.Forms;
using WindowsFormsApp1.usecases;

namespace WindowsFormsApp1
{
    public partial class CadastroDeProduto : Form
    {
        public CadastroDeProduto()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadastrarProduto = new CadastrarProduto();

            if(cadastrarProduto.NewProduct(tbName.Text,tbTipo.Text,tbValue.Text,cbCategorias.Text))
            {
                MessageBox.Show("success");
                tbName.Text = "";
                tbValue.Text = "";
                cbCategorias.Text = "";
                tbTipo.Text = "";
            }else
            {
                MessageBox.Show("error");
            }
        }


        private void tbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}