using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.usecases.collections;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApp1
{
    public partial class calculadoraCaloriasDiarias : Form
    {
        String filter;
        List<Product> products;
        List<String> refeicoes;
        String name;
        List<Product> eated;
        float caloriasIngeridas = 0;
        public calculadoraCaloriasDiarias()
        {
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<Product>("product");
            products = collection.Find(_ => true).ToList();
            if (products.Count == 0)
                throw new Exception();
            InitializeComponent();

        }

        private void calculadoraCaloriasDiarias_Load(object sender, EventArgs e)
        {
            var classes = products.Select(result => result.Classe).Distinct().ToList();
            comboBoxCategory.Items.AddRange(classes.ToArray<object>());

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAlimentos.Items.Clear();
            filter = this.comboBoxCategory.GetItemText(this.comboBoxCategory.SelectedItem);
            var foods = products.Where(food => food.Classe == filter).ToList();
            var foodsName = foods.Select(foodName => foodName.Name).Distinct().ToList();
            comboBoxAlimentos.Items.AddRange(foodsName.ToArray<object>());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = this.comboBoxAlimentos.GetItemText(this.comboBoxAlimentos.SelectedItem);
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var filter = new BsonDocument("Name", name);
            var collection = database.GetCollection<Product>("product");
            var results = collection.Find(filter).ToList();
            if (results.Count == 0)
                throw new Exception("Usuario inexistente ");

            Product product = results.First();
            caloriasIngeridas += product.Calorias;
            labelTotal.Text = "Calorias Ingeridas: " + caloriasIngeridas;
        }
    }
}