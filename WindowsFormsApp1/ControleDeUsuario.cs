using MongoDB.Bson;
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
        List<User> list;
        
        public ControleDeUsuario()
        {
            InitializeComponent();
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<User>("user");

            list = collection.Find(_ => true).ToList();
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
            Mongo mongo = new Mongo();
            var database = mongo.getserver();
            var collection = database.GetCollection<User>("user");

            int i = 0;
            foreach (User user in list)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals("NORMAL"))
                    user.UserStatus = UserStatus.NORMAL;
                if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals("DELETED"))
                    user.UserStatus = UserStatus.DELETED;
                if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals("BLOQUED"))
                    user.UserStatus = UserStatus.BLOQUED;

                if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals("1"))
                    user.Profile = 1;
                if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals("2"))
                    user.Profile = 2;

                var filter = Builders<User>.Filter.Eq(s => s.Id, user.Id);
                var result = collection.ReplaceOne(filter, user);

                
            }


        }

        private void ControleDeUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
