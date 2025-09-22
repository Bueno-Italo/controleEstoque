namespace GUI
{
    partial class frmCadastroTipoPagamento
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
            label1 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
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
            // 
            // btCancelar
            // 
            btCancelar.Click += btCancelar_Click;
            // 
            // btSalvar
            // 
            btSalvar.Click += btSalvar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Click += btExcluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.Click += btAlterar_Click;
            // 
            // btLocalizar
            // 
            btLocalizar.Click += btLocalizar_Click;
            // 
            // btInserir
            // 
            btInserir.Click += btInserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 92);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Pagamento";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(15, 45);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(15, 110);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 3;
            // 
            // frmCadastroTipoPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "frmCadastroTipoPagamento";
            Text = "Cadastro Tipo Pagamento";
            Load += frmCadastroTipoPagamento_Load;
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            pnBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
    }
}