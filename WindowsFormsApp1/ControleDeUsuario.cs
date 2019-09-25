using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ControleDeUsuario : WindowsFormsApp1.BaseForm
    {
        public ControleDeUsuario()
        {
            InitializeComponent();
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<User>("user");

            var list = collection.Find(_ => true).ToList();
            foreach (User user in list)
            {
                string[] userString = new string[] { user.Name, user.UserStatus.ToString(), user.Profile.ToString() };
                dataGridView1.Rows.Add(userString);
            }

            
        }

        private void ControleDeUsuario_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
