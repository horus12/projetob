namespace WindowsFormsApp1
{
    partial class MenuInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloqueioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cALULADORADEPESOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exclusaoDeAlimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteracaoDeAlimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularCaloriasConsumidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.menuToolStripMenuItem, this.administraçãoToolStripMenuItem, this.calculadoraToolStripMenuItem,
                this.perfilToolStripMenuItem, this.calculoDeToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked +=
                new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.controleDeUsuarioToolStripMenuItem, this.desbloqueioToolStripMenuItem});
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // controleDeUsuarioToolStripMenuItem
            // 
            this.controleDeUsuarioToolStripMenuItem.Name = "controleDeUsuarioToolStripMenuItem";
            this.controleDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.controleDeUsuarioToolStripMenuItem.Text = "Controle de Usuario";
            this.controleDeUsuarioToolStripMenuItem.Click +=
                new System.EventHandler(this.controleDeUsuarioToolStripMenuItem_Click);
            // 
            // desbloqueioToolStripMenuItem
            // 
            this.desbloqueioToolStripMenuItem.Name = "desbloqueioToolStripMenuItem";
            this.desbloqueioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.desbloqueioToolStripMenuItem.Text = "Desbloqueio";
            this.desbloqueioToolStripMenuItem.Click += new System.EventHandler(this.desbloqueioToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.cALULADORADEPESOToolStripMenuItem});
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // cALULADORADEPESOToolStripMenuItem
            // 
            this.cALULADORADEPESOToolStripMenuItem.Name = "cALULADORADEPESOToolStripMenuItem";
            this.cALULADORADEPESOToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cALULADORADEPESOToolStripMenuItem.Text = "CALULADORA DE PESO";
            this.cALULADORADEPESOToolStripMenuItem.Click +=
                new System.EventHandler(this.cALULADORADEPESOToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.alterarSenhaToolStripMenuItem, this.excluirContaToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar senha";
            this.alterarSenhaToolStripMenuItem.Click +=
                new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // excluirContaToolStripMenuItem
            // 
            this.excluirContaToolStripMenuItem.Name = "excluirContaToolStripMenuItem";
            this.excluirContaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.excluirContaToolStripMenuItem.Text = "Excluir conta";
            this.excluirContaToolStripMenuItem.Click +=
                new System.EventHandler(this.excluirContaToolStripMenuItem_Click);
            // 
            // calculoDeToolStripMenuItem
            // 
            this.calculoDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.cadastroDeAlimentosToolStripMenuItem, this.exclusaoDeAlimentoToolStripMenuItem,
                this.alteracaoDeAlimentoToolStripMenuItem, this.calcularCaloriasConsumidasToolStripMenuItem,
                this.consultarProdutoToolStripMenuItem
            });
            this.calculoDeToolStripMenuItem.Name = "calculoDeToolStripMenuItem";
            this.calculoDeToolStripMenuItem.Size = new System.Drawing.Size(223, 20);
            this.calculoDeToolStripMenuItem.Text = "Calculo de Calorias consumidas no dia";
            // 
            // cadastroDeAlimentosToolStripMenuItem
            // 
            this.cadastroDeAlimentosToolStripMenuItem.Name = "cadastroDeAlimentosToolStripMenuItem";
            this.cadastroDeAlimentosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cadastroDeAlimentosToolStripMenuItem.Text = "Cadastro de alimentos";
            this.cadastroDeAlimentosToolStripMenuItem.Click +=
                new System.EventHandler(this.cadastroDeAlimentosToolStripMenuItem_Click);
            // 
            // exclusaoDeAlimentoToolStripMenuItem
            // 
            this.exclusaoDeAlimentoToolStripMenuItem.Name = "exclusaoDeAlimentoToolStripMenuItem";
            this.exclusaoDeAlimentoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.exclusaoDeAlimentoToolStripMenuItem.Text = "exclusao de alimento";
            this.exclusaoDeAlimentoToolStripMenuItem.Click +=
                new System.EventHandler(this.exclusaoDeAlimentoToolStripMenuItem_Click);
            // 
            // alteracaoDeAlimentoToolStripMenuItem
            // 
            this.alteracaoDeAlimentoToolStripMenuItem.Name = "alteracaoDeAlimentoToolStripMenuItem";
            this.alteracaoDeAlimentoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.alteracaoDeAlimentoToolStripMenuItem.Text = "alteracao de alimento";
            this.alteracaoDeAlimentoToolStripMenuItem.Click +=
                new System.EventHandler(this.alteracaoDeAlimentoToolStripMenuItem_Click);
            // 
            // calcularCaloriasConsumidasToolStripMenuItem
            // 
            this.calcularCaloriasConsumidasToolStripMenuItem.Name = "calcularCaloriasConsumidasToolStripMenuItem";
            this.calcularCaloriasConsumidasToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.calcularCaloriasConsumidasToolStripMenuItem.Text = "calcular calorias consumidas";
            this.calcularCaloriasConsumidasToolStripMenuItem.Click +=
                new System.EventHandler(this.calcularCaloriasConsumidasToolStripMenuItem_Click);
            // 
            // consultarProdutoToolStripMenuItem
            // 
            this.consultarProdutoToolStripMenuItem.Name = "consultarProdutoToolStripMenuItem";
            this.consultarProdutoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.consultarProdutoToolStripMenuItem.Text = "Consultar Produto";
            this.consultarProdutoToolStripMenuItem.Click +=
                new System.EventHandler(this.consultarProdutoToolStripMenuItem_Click);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuInicial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuInicial_FormClosed_1);
            this.Load += new System.EventHandler(this.MenuInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cALULADORADEPESOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desbloqueioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularCaloriasConsumidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteracaoDeAlimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exclusaoDeAlimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProdutoToolStripMenuItem;
    }
}
