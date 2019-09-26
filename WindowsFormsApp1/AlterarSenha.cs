using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AlterarSenha : WindowsFormsApp1.BaseForm
    {
        User user_; 
        public AlterarSenha(User user)
        {
            user_ = user;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex AlphaRegex = new Regex("([a-zA-Z0-9])$");

            if (!AlphaRegex.IsMatch(this.tbSenha.Text))
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbSenha.Text.Equals(tbSenha2.Text))
            {
                Mongo mongo = new Mongo();
                var database = mongo.getserver();
                var collection = database.GetCollection<User>("user");

                var filter = new BsonDocument("Cpf", user_.Cpf);
                var results = collection.Find(filter).ToList();
                if (results.Count == 0)
                    throw new Exception();

                User user = results.First();

                Cript cript = new Cript();
                user.Password = cript.ComputeSha256Hash(tbSenha.Text);

                var filter1 = Builders<User>.Filter.Eq(s => s.Id, user.Id);
                var result = collection.ReplaceOne(filter1, user);

                MessageBox.Show("Senha alterada com sucesso");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("senhas não dão match ou não são validas");
            }
        }

        private void tbSenha2_TextChanged(object sender, EventArgs e)
        {
            Regex AlphaRegex = new Regex("([a-zA-Z0-9])$");

            if (!AlphaRegex.IsMatch(this.tbSenha.Text))
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
