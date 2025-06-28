namespace GUI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            subCategoriaToolStripMenuItem = new ToolStripMenuItem();
            unidadeDeMedidaToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            movimentaçãoToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem1 = new ToolStripMenuItem();
            subCategoriaToolStripMenuItem1 = new ToolStripMenuItem();
            unidadeDeMedidaToolStripMenuItem1 = new ToolStripMenuItem();
            produtoToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            clienteToolStripMenuItem1 = new ToolStripMenuItem();
            fornecedorToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, consultaToolStripMenuItem, movimentaçãoToolStripMenuItem, relatórioToolStripMenuItem, ferramentasToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem, subCategoriaToolStripMenuItem, unidadeDeMedidaToolStripMenuItem, produtoToolStripMenuItem, toolStripSeparator1, clienteToolStripMenuItem, fornecedorToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(177, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // subCategoriaToolStripMenuItem
            // 
            subCategoriaToolStripMenuItem.Name = "subCategoriaToolStripMenuItem";
            subCategoriaToolStripMenuItem.Size = new Size(177, 22);
            subCategoriaToolStripMenuItem.Text = "SubCategoria";
            // 
            // unidadeDeMedidaToolStripMenuItem
            // 
            unidadeDeMedidaToolStripMenuItem.Name = "unidadeDeMedidaToolStripMenuItem";
            unidadeDeMedidaToolStripMenuItem.Size = new Size(177, 22);
            unidadeDeMedidaToolStripMenuItem.Text = "Unidade de Medida";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(177, 22);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(174, 6);
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(177, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(177, 22);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem1, subCategoriaToolStripMenuItem1, unidadeDeMedidaToolStripMenuItem1, produtoToolStripMenuItem1, toolStripSeparator2, clienteToolStripMenuItem1, fornecedorToolStripMenuItem1 });
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(66, 20);
            consultaToolStripMenuItem.Text = "Consulta";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            movimentaçãoToolStripMenuItem.Size = new Size(99, 20);
            movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(84, 20);
            ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // categoriaToolStripMenuItem1
            // 
            categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            categoriaToolStripMenuItem1.Size = new Size(180, 22);
            categoriaToolStripMenuItem1.Text = "Categoria";
            categoriaToolStripMenuItem1.Click += categoriaToolStripMenuItem1_Click;
            // 
            // subCategoriaToolStripMenuItem1
            // 
            subCategoriaToolStripMenuItem1.Name = "subCategoriaToolStripMenuItem1";
            subCategoriaToolStripMenuItem1.Size = new Size(180, 22);
            subCategoriaToolStripMenuItem1.Text = "SubCategoria";
            // 
            // unidadeDeMedidaToolStripMenuItem1
            // 
            unidadeDeMedidaToolStripMenuItem1.Name = "unidadeDeMedidaToolStripMenuItem1";
            unidadeDeMedidaToolStripMenuItem1.Size = new Size(180, 22);
            unidadeDeMedidaToolStripMenuItem1.Text = "Unidade de Medida";
            // 
            // produtoToolStripMenuItem1
            // 
            produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            produtoToolStripMenuItem1.Size = new Size(180, 22);
            produtoToolStripMenuItem1.Text = "Produto";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // clienteToolStripMenuItem1
            // 
            clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            clienteToolStripMenuItem1.Size = new Size(180, 22);
            clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // fornecedorToolStripMenuItem1
            // 
            fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            fornecedorToolStripMenuItem1.Size = new Size(180, 22);
            fornecedorToolStripMenuItem1.Text = "Fornecedor";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Controle de Estoque";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem subCategoriaToolStripMenuItem;
        private ToolStripMenuItem unidadeDeMedidaToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem1;
        private ToolStripMenuItem subCategoriaToolStripMenuItem1;
        private ToolStripMenuItem unidadeDeMedidaToolStripMenuItem1;
        private ToolStripMenuItem produtoToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem clienteToolStripMenuItem1;
        private ToolStripMenuItem fornecedorToolStripMenuItem1;
    }
}