namespace GUI
{
    partial class frmCadastroUnidadeDeMedida
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
            txtCod = new TextBox();
            txtUnidadeMedida = new TextBox();
            pnDados.SuspendLayout();
            pnBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.Controls.Add(txtUnidadeMedida);
            pnDados.Controls.Add(txtCod);
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
            label1.Location = new Point(17, 32);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 106);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Unidade de medida";
            // 
            // txtCod
            // 
            txtCod.Enabled = false;
            txtCod.Location = new Point(17, 50);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(144, 23);
            txtCod.TabIndex = 2;
            // 
            // txtUnidadeMedida
            // 
            txtUnidadeMedida.Location = new Point(17, 124);
            txtUnidadeMedida.Name = "txtUnidadeMedida";
            txtUnidadeMedida.Size = new Size(735, 23);
            txtUnidadeMedida.TabIndex = 3;
            // 
            // frmCadastroUnidadeDeMedida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "frmCadastroUnidadeDeMedida";
            Text = "Cadastro Unidade de Medida";
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            pnBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUnidadeMedida;
        private TextBox txtCod;
        private Label label2;
        private Label label1;
    }
}