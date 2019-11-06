﻿using System;
 using System.Collections.Generic;
 using System.Globalization;
 using System.Linq;
 using System.Windows.Forms;
 using WindowsFormsApp1.usecases;
 using WindowsFormsApp1.usecases.collections;
 using MongoDB.Driver;

 namespace WindowsFormsApp1
{
    public partial class AlterarProduto : Form
    {
        private List<Product> resultes;
        Product p = new Product();
        public AlterarProduto()
        {
            InitializeComponent();
            updateCombo();
        }

      
        
        
        
        private void updateCombo()
        {
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<Product>("product"); 
            resultes = collection.Find(_ => true).ToList();
            comboBox1.Items.Clear();
            if (resultes.Count == 0)
            {
                
                MessageBox.Show("No Products");
                
            }

            List<String> list = resultes.Select(result => result.Name).ToList();
            comboBox1.Items.AddRange(list.ToArray<object>());
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Product product in resultes )
            {
                if (product.Name.Equals(comboBox1.GetItemText(this.comboBox1.SelectedItem)))
                {
                    p = product;
                }
            }

            textBox1.Text = p.Name;
            cbCategoria.Text = p.Classe;
            tbTipo.Text = p.Tipo;
            textBox4.Text = p.Calorias.ToString(CultureInfo.CurrentCulture);

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            var alterarProduto = new AlterarProdutoUseCase();
            if (alterarProduto.NewProduct(textBox1.Text, tbTipo.Text, textBox4.Text, cbCategoria.Text, p.Id))
            {
                MessageBox.Show("success");
                
                comboBox1.SelectedIndex = -1;
                updateCombo();
                textBox1.Text = "";
                cbCategoria.Text = "";
                tbTipo.Text = "";
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("erro tente novamente");
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}