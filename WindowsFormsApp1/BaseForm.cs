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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void menuInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {

        }

        private void calculoDoImcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculadoraImc calculadoraImc = new CalculadoraImc();
            calculadoraImc.ShowDialog();
        }
    }
}
