using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalculadoraImc : WindowsFormsApp1.BaseForm
    {
        public CalculadoraImc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculadora imc = new Calculadora();
            var peso = double.Parse(textBox1.Text);
            var altura = double.Parse(textBox2.Text);
            double result = imc.calcula(peso, altura);
            label3.Text = result.ToString();
            label3.Visible = true;
        }
    }
}
