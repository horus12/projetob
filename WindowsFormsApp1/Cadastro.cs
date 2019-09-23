using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WindowsFormsApp1
{
    public partial class Cadastro : Form
    {
        Login frm;
        public Cadastro(Login login)
        {
         
            InitializeComponent();
            frm = login;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          


        }

        void maskValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frm.Show();
            this.Dispose();
            


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Mongo mongo = new Mongo();
            mongo.getserver();

           
                

        }

        private void label5_Click(object sender, EventArgs e)
        {
           

        }
    }
}
