﻿using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class calculadoraCaloriasDiarias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAlimentos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {"Café da Manhã", "Almoço", "Janta"});
            this.comboBox1.Location = new System.Drawing.Point(22, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(22, 104);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Refeição";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alimentos";
            // 
            // comboBoxAlimentos
            // 
            this.comboBoxAlimentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlimentos.FormattingEnabled = true;
            this.comboBoxAlimentos.Location = new System.Drawing.Point(22, 156);
            this.comboBoxAlimentos.Name = "comboBoxAlimentos";
            this.comboBoxAlimentos.Size = new System.Drawing.Size(121, 23);
            this.comboBoxAlimentos.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar refeição";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(189, 254);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(415, 23);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Calorias Ingeridas: 0";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(189, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 199);
            this.listBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(415, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Enviar lista de alimentos por email";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 23);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(189, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 12;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantidade";
            // 
            // calculadoraCaloriasDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxAlimentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBox1);
            this.Name = "calculadoraCaloriasDiarias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculadoraCaloriasDiarias";
            this.Load += new System.EventHandler(this.calculadoraCaloriasDiarias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAlimentos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
    }
}