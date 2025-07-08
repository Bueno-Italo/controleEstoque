namespace GUI
{
    partial class frmCadastroCategoria
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
            pnDados = new Panel();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnBotoes = new Panel();
            btCancelar = new Button();
            btSalvar = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btLocalizar = new Button();
            btInserir = new Button();
            pnDados.SuspendLayout();
            pnBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(txtCodigo);
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(label1);
            pnDados.Location = new Point(12, 12);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 328);
            pnDados.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 122);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(747, 23);
            txtNome.TabIndex = 3;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(12, 51);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome da Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // pnBotoes
            // 
            pnBotoes.Controls.Add(btCancelar);
            pnBotoes.Controls.Add(btSalvar);
            pnBotoes.Controls.Add(btExcluir);
            pnBotoes.Controls.Add(btAlterar);
            pnBotoes.Controls.Add(btLocalizar);
            pnBotoes.Controls.Add(btInserir);
            pnBotoes.Location = new Point(12, 346);
            pnBotoes.Name = "pnBotoes";
            pnBotoes.Size = new Size(776, 101);
            pnBotoes.TabIndex = 1;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.Image = Properties.Resources.Cancelar;
            btCancelar.Location = new Point(654, 4);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(105, 88);
            btCancelar.TabIndex = 5;
            btCancelar.TabStop = false;
            btCancelar.Text = "Cancelar";
            btCancelar.TextAlign = ContentAlignment.BottomCenter;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btSalvar
            // 
            btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvar.Image = Properties.Resources.Salvar1_fw;
            btSalvar.Location = new Point(523, 4);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(111, 88);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.TextAlign = ContentAlignment.BottomCenter;
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluir.Image = Properties.Resources.Excluir;
            btExcluir.Location = new Point(399, 4);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(104, 88);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Excluir";
            btExcluir.TextAlign = ContentAlignment.BottomCenter;
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click_1;
            // 
            // btAlterar
            // 
            btAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterar.Image = Properties.Resources.Alterar;
            btAlterar.Location = new Point(271, 4);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(108, 88);
            btAlterar.TabIndex = 2;
            btAlterar.Text = "Alterar";
            btAlterar.TextAlign = ContentAlignment.BottomCenter;
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click_1;
            // 
            // btLocalizar
            // 
            btLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLocalizar.Image = Properties.Resources.localizar_fw;
            btLocalizar.Location = new Point(141, 3);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(110, 89);
            btLocalizar.TabIndex = 1;
            btLocalizar.Text = "Localizar";
            btLocalizar.TextAlign = ContentAlignment.BottomCenter;
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // btInserir
            // 
            btInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInserir.Image = Properties.Resources.Novo;
            btInserir.Location = new Point(12, 4);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(109, 88);
            btInserir.TabIndex = 0;
            btInserir.Text = "Inserir";
            btInserir.TextAlign = ContentAlignment.BottomCenter;
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += btInserir_Click;
            // 
            // frmCadastroCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnBotoes);
            Controls.Add(pnDados);
            Name = "frmCadastroCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de categoria";
            Load += frmCadastroCategoria_Load;
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            pnBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnDados;
        private Panel pnBotoes;
        private Button btExcluir;
        private Button btAlterar;
        private Button btLocalizar;
        private Button btInserir;
        private Button btCancelar;
        private Button btSalvar;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtCodigo;
    }
}