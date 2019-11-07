using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.data;
using WindowsFormsApp1.exceptions;
using WindowsFormsApp1.usecases.collections;
using AutoMapper;
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
                throw new NoProductException("Nenhum produto cadastrado na base, impossivel realizar calculos");
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

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Product, ProductView>();
            });
            IMapper iMapper = config.CreateMapper();
            var productView = iMapper.Map<Product, ProductView>(product);
            listBox1.Items.Add(productView);
            listBox1.Refresh();
        }
        
//        private void button2_Click_1(object sender, EventArgs e)
//        {
//            StreamWriter myOutputStream = new StreamWriter(@"C:\Users\15610967\Documents\Myfile.csv");
//
//            foreach (var item in listBox1.Items)
//            {
//                myOutputStream.WriteLine(item.ToString());
//            }
//            myOutputStream.Close();
//            Email email = new Email();
//
//            var myFile = new StreamReader(@"C:\Users\15610967\Documents\Myfile.csv");
//            var cryptoStream = new CryptoStream(myFile, new FromBase64Transform(), CryptoStreamMode.Write);
//            var memoryStream = new MemoryStream();
//            memoryStream.CopyTo(myFile);
//            email.email_send();
//        }
    }
}