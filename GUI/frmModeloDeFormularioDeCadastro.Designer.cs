namespace GUI
{
    partial class frmModeloDeFormularioDeCadastro
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
            pnBotoes = new Panel();
            btCancelar = new Button();
            btSalvar = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btLocalizar = new Button();
            btInserir = new Button();
            pnBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.Location = new Point(12, 12);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 331);
            pnDados.TabIndex = 0;
            pnDados.Paint += panel1_Paint;
            // 
            // pnBotoes
            // 
            pnBotoes.Controls.Add(btCancelar);
            pnBotoes.Controls.Add(btSalvar);
            pnBotoes.Controls.Add(btExcluir);
            pnBotoes.Controls.Add(btAlterar);
            pnBotoes.Controls.Add(btLocalizar);
            pnBotoes.Controls.Add(btInserir);
            pnBotoes.Location = new Point(12, 349);
            pnBotoes.Name = "pnBotoes";
            pnBotoes.Size = new Size(776, 100);
            pnBotoes.TabIndex = 1;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.Image = Properties.Resources.Cancelar;
            btCancelar.Location = new Point(673, 3);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(99, 94);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.TextAlign = ContentAlignment.BottomCenter;
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvar.Image = Properties.Resources.Salvar1_fw;
            btSalvar.Location = new Point(542, 3);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(101, 94);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.TextAlign = ContentAlignment.BottomCenter;
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += button5_Click;
            // 
            // btExcluir
            // 
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluir.Image = Properties.Resources.Excluir;
            btExcluir.Location = new Point(401, 3);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(107, 94);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Excluir";
            btExcluir.TextAlign = ContentAlignment.BottomCenter;
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            btAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterar.Image = Properties.Resources.Alterar;
            btAlterar.Location = new Point(274, 3);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(102, 94);
            btAlterar.TabIndex = 2;
            btAlterar.Text = "Alterar";
            btAlterar.TextAlign = ContentAlignment.BottomCenter;
            btAlterar.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            btLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLocalizar.Image = Properties.Resources.localizar_fw;
            btLocalizar.Location = new Point(139, 3);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(111, 94);
            btLocalizar.TabIndex = 1;
            btLocalizar.Text = "Localizar";
            btLocalizar.TextAlign = ContentAlignment.BottomCenter;
            btLocalizar.UseVisualStyleBackColor = true;
            // 
            // btInserir
            // 
            btInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInserir.Image = Properties.Resources.Novo;
            btInserir.Location = new Point(3, 3);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(107, 94);
            btInserir.TabIndex = 0;
            btInserir.Text = "Inserir";
            btInserir.TextAlign = ContentAlignment.BottomCenter;
            btInserir.UseVisualStyleBackColor = true;
            // 
            // frmModeloDeFormularioDeCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnBotoes);
            Controls.Add(pnDados);
            KeyPreview = true;
            Name = "frmModeloDeFormularioDeCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modelo de formulário de cadastro";
            Load += frmModeloDeFormularioDeCadastro_Load;
            KeyDown += frmModeloDeFormularioDeCadastro_KeyDown;
            pnBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel pnDados;
        protected Panel pnBotoes;
        protected Button btCancelar;
        protected Button btSalvar;
        protected Button btExcluir;
        protected Button btAlterar;
        protected Button btLocalizar;
        protected Button btInserir;
    }
}