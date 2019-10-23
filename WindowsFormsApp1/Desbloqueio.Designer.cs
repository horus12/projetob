using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class Desbloqueio
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
            this.txtBoxUnblock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnblock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxUnblock
            // 
            this.txtBoxUnblock.Location = new System.Drawing.Point(38, 46);
            this.txtBoxUnblock.Name = "txtBoxUnblock";
            this.txtBoxUnblock.Size = new System.Drawing.Size(187, 23);
            this.txtBoxUnblock.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cpf\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUnblock
            // 
            this.btnUnblock.Location = new System.Drawing.Point(38, 119);
            this.btnUnblock.Name = "btnUnblock";
            this.btnUnblock.Size = new System.Drawing.Size(187, 23);
            this.btnUnblock.TabIndex = 2;
            this.btnUnblock.Text = "Desbloquear";
            this.btnUnblock.UseVisualStyleBackColor = true;
            this.btnUnblock.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(38, 90);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(187, 23);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // Desbloqueio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 213);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnblock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxUnblock);
            this.Name = "Desbloqueio";
            this.Text = "Desbloqueio";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnblock;
        private System.Windows.Forms.TextBox txtBoxUnblock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEmail;
    }
}