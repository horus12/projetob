﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Desbloqueio : Form
    {
        public Desbloqueio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var desbloqueioUseCase = new DesbloqueioUseCase();
            desbloqueioUseCase.unblock(txtBoxUnblock.Text, txtBoxEmail.Text);
        }
    }
}