using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.usecases;
using WindowsFormsApp1.usecases.collections;
using MongoDB.Driver;

namespace WindowsFormsApp1
{
    public partial class ExcluirProduto : Form
    {
        private List<Product> resultes;
        Product p = new Product();
        public ExcluirProduto()
        {
            InitializeComponent();
            updateCombo();

        }
        

        private void ExcluirProduto_Load(object sender, EventArgs e)
        {
            
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
            label3.Text = "Nome: " + p.Name;
            label4.Text = "Tipo de Comida: " + p.Classe;
            label5.Text = "Calorias: " + p.Calorias;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var excluirProduto = new ExcuirProduto();

            if (excluirProduto.Excluir(p))
            {
                MessageBox.Show("success");
                
                comboBox1.SelectedIndex = -1;
                updateCombo();
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";

            }else
            {
                MessageBox.Show("error");
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                comboBox1.SelectedIndex = -1;
            }

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


    }
}