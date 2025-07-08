namespace GUI
{
    partial class frmCadastroDeSubCategoria
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
            cbCatCod = new ComboBox();
            label3 = new Label();
            txtScatCod = new TextBox();
            txtNome = new TextBox();
            pnDados.SuspendLayout();
            pnBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(txtScatCod);
            pnDados.Controls.Add(label3);
            pnDados.Controls.Add(cbCatCod);
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
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 86);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome da SubCategoria";
            // 
            // cbCatCod
            // 
            cbCatCod.FormattingEnabled = true;
            cbCatCod.Location = new Point(23, 173);
            cbCatCod.Name = "cbCatCod";
            cbCatCod.Size = new Size(360, 23);
            cbCatCod.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 155);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 3;
            label3.Text = "Nome da Categoria";
            // 
            // txtScatCod
            // 
            txtScatCod.Enabled = false;
            txtScatCod.Location = new Point(23, 37);
            txtScatCod.Name = "txtScatCod";
            txtScatCod.Size = new Size(115, 23);
            txtScatCod.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(23, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(722, 23);
            txtNome.TabIndex = 5;
            // 
            // frmCadastroDeSubCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "frmCadastroDeSubCategoria";
            Text = "Cadastro de SubCategoria";
            Load += frmCadastroDeSubCategoria_Load;
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            pnBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbCatCod;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtScatCod;
        private Label label3;
    }
}