﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuInicial : WindowsFormsApp1.BaseForm
    {
        public MenuInicial(String type)
        {
            

            InitializeComponent(type);
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void controleDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDeUsuario controleDeUsuario = new ControleDeUsuario();
            controleDeUsuario.ShowDialog();
            
        }
    }
}
