using System;
using System.Windows.Forms;
using WindowsFormsApp1.exceptions;

namespace WindowsFormsApp1
{
    public partial class CalculadoraImc : BaseForm
    {
        public CalculadoraImc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool er = !(textBox1 != null && !string.IsNullOrWhiteSpace(textBox1.Text) && textBox2 != null && !string.IsNullOrWhiteSpace(textBox2.Text));

            if (!er) {
                Calculadora imc = new Calculadora();
                var peso = double.Parse(textBox1.Text);
                var altura = double.Parse(textBox2.Text);
                if (altura != 0.0 && peso != 0.0)
                {
                    double result = imc.calcula(peso, altura);
                    label3.Text = result.ToString("00.00");
                    showImcValue(result);
                    label3.Visible = true; 
                }
                else
                {
                    MessageBox.Show("Campos não podem ser 0");
                }

            } else
            {
                MessageBox.Show("Preencha todos os campos");
            }

        }

        private void showImcValue(double result)
        {
            if (result < 17)
            {
                label4.Text = "Muito abaixo do peso";
                label4.Visible = true;
            }

            if (result >= 17 && result <= 18.49)
            {
                label4.Text = "Abaixo do peso";
                label4.Visible = true;

            }
            if (result >= 18.49 && result <= 24.99)
            {
                label4.Text = "Peso normal";
                label4.Visible = true;

            }

            if (result > 24.99 && result <= 29.99)
            {
                label4.Text = "Acima do peso";
                label4.Visible = true;

            }
            if (result > 29.99 && result <= 34.99)
            {
                label4.Text = "Obesidade I";
                label4.Visible = true;

            }
            if (result > 34.99 && result <= 39.99)
            {
                label4.Text = "	Obesidade II (severa)";
                label4.Visible = true;

            }
            if (result > 39.99)
            {
                label4.Text = "Obesidade III (mórbida)";
                label4.Visible = true;

            }
        }

        private void CalculadoraImc_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
