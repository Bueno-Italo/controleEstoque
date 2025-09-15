namespace GUI
{
    partial class frmConfiguracaoBancoDados
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
            label3 = new Label();
            label4 = new Label();
            txtServidor = new TextBox();
            txtBanco = new TextBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Servidor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Bando de Dados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 220);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Senha";
            label4.Click += label4_Click;
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(12, 48);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(753, 23);
            txtServidor.TabIndex = 4;
            // 
            // txtBanco
            // 
            txtBanco.Location = new Point(12, 119);
            txtBanco.Name = "txtBanco";
            txtBanco.Size = new Size(753, 23);
            txtBanco.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 183);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(753, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 248);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(753, 23);
            txtSenha.TabIndex = 7;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(531, 346);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(78, 21);
            btSalvar.TabIndex = 8;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // frmConfiguracaoBancoDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btSalvar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtBanco);
            Controls.Add(txtServidor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmConfiguracaoBancoDados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração do Banco de Dados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtServidor;
        private TextBox txtBanco;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btSalvar;
    }
}