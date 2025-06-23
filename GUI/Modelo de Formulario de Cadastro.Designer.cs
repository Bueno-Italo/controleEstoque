namespace GUI
{
    public partial class Modelo_de_Formulario_de_Cadastro : Form
    {

        public String operacao;
        public Modelo_de_Formulario_de_Cadastro()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }
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
            pbBotoes = new Panel();
            btCancelar = new Button();
            btAlterar = new Button();
            btSalvar = new Button();
            btExcluir = new Button();
            btLocalizar = new Button();
            btInserir = new Button();
            pbBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.Location = new Point(12, 22);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 349);
            pnDados.TabIndex = 0;
            // 
            // pbBotoes
            // 
            pbBotoes.Controls.Add(btCancelar);
            pbBotoes.Controls.Add(btAlterar);
            pbBotoes.Controls.Add(btSalvar);
            pbBotoes.Controls.Add(btExcluir);
            pbBotoes.Controls.Add(btLocalizar);
            pbBotoes.Controls.Add(btInserir);
            pbBotoes.Location = new Point(12, 422);
            pbBotoes.Name = "pbBotoes";
            pbBotoes.Size = new Size(776, 116);
            pbBotoes.TabIndex = 1;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCancelar.Image = Properties.Resources.Cancelar;
            btCancelar.Location = new Point(698, 21);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(82, 82);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.TextAlign = ContentAlignment.BottomCenter;
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            btAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btAlterar.Image = Properties.Resources.Alterar;
            btAlterar.Location = new Point(281, 21);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(82, 82);
            btAlterar.TabIndex = 4;
            btAlterar.Text = "Alterar";
            btAlterar.TextAlign = ContentAlignment.BottomCenter;
            btAlterar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSalvar.Image = Properties.Resources.Salvar1_fw;
            btSalvar.Location = new Point(559, 21);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(82, 82);
            btSalvar.TabIndex = 3;
            btSalvar.Text = "Salvar";
            btSalvar.TextAlign = ContentAlignment.BottomCenter;
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            btExcluir.CausesValidation = false;
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btExcluir.Image = Properties.Resources.Excluir;
            btExcluir.Location = new Point(420, 21);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(82, 82);
            btExcluir.TabIndex = 2;
            btExcluir.Text = "Excluir";
            btExcluir.TextAlign = ContentAlignment.BottomCenter;
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            btLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLocalizar.Image = Properties.Resources.localizar_fw;
            btLocalizar.Location = new Point(142, 21);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(82, 82);
            btLocalizar.TabIndex = 1;
            btLocalizar.Text = "Localizar";
            btLocalizar.TextAlign = ContentAlignment.BottomCenter;
            btLocalizar.UseVisualStyleBackColor = true;
            // 
            // btInserir
            // 
            btInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btInserir.Image = Properties.Resources.Novo;
            btInserir.Location = new Point(3, 21);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(82, 82);
            btInserir.TabIndex = 0;
            btInserir.Text = "Inserir";
            btInserir.TextAlign = ContentAlignment.BottomCenter;
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += button1_Click;
            // 
            // Modelo_de_Formulario_de_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(pbBotoes);
            Controls.Add(pnDados);
            Name = "Modelo_de_Formulario_de_Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de categoria";
            Load += Modelo_de_Formulario_de_Cadastro_Load;
            pbBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnDados;
        private Panel pbBotoes;
        private Button btAlterar;
        private Button btSalvar;
        private Button btExcluir;
        private Button btLocalizar;
        private Button btInserir;
        private Button btCancelar;
    }
}