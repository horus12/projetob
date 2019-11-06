using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApp1.usecases.collections;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApp1
{
    public partial class ConsultarProdutos : Form
    {
        List<Product> list;

        public ConsultarProdutos()
        {
            InitializeComponent();
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<Product>("product");

            list = collection.Find(_ => true).ToList();
            foreach (Product user in list)
            {
                string[] userString =  { user.Name, user.Tipo, user.Classe , user.Calorias.ToString(CultureInfo.InvariantCulture) };
                dataGridView1.Rows.Add(userString);
            }
            
        }



        private void filter(String filters)
        {
            dataGridView1.Rows.Clear();
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<Product>("product");

            var filter = new BsonDocument {{"Name", new BsonDocument {{"$regex", filters}, {"$options", "i"}}}};

            var results = collection.Find(filter).ToList();
            foreach (Product user in results)
            {
                string[] userString =  { user.Name, user.Tipo, user.Classe , user.Calorias.ToString(CultureInfo.InvariantCulture) };
                dataGridView1.Rows.Add(userString);
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter(textBox1.Text);
        }
    }
}