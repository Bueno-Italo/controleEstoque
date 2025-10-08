namespace GUI
{
    partial class frmCadastroCliente
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
            lbNome = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            groupBox1 = new GroupBox();
            rbJuridica = new RadioButton();
            rbFisica = new RadioButton();
            lbRSocial = new Label();
            txrRSocial = new TextBox();
            lbCPFCNPJ = new Label();
            txtCPFCNPJ = new TextBox();
            lbRGIE = new Label();
            txtRGIE = new TextBox();
            label2 = new Label();
            txtCep = new TextBox();
            label3 = new Label();
            txtEstado = new TextBox();
            label4 = new Label();
            txtCidade = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            txtCelular = new TextBox();
            label7 = new Label();
            txtFone = new TextBox();
            label10 = new Label();
            pnDados.SuspendLayout();
            pnBotoes.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.Controls.Add(txtCelular);
            pnDados.Controls.Add(label7);
            pnDados.Controls.Add(txtFone);
            pnDados.Controls.Add(label10);
            pnDados.Controls.Add(txtEmail);
            pnDados.Controls.Add(label9);
            pnDados.Controls.Add(txtBairro);
            pnDados.Controls.Add(label8);
            pnDados.Controls.Add(txtNumero);
            pnDados.Controls.Add(txtRua);
            pnDados.Controls.Add(label6);
            pnDados.Controls.Add(label5);
            pnDados.Controls.Add(txtCidade);
            pnDados.Controls.Add(label4);
            pnDados.Controls.Add(txtEstado);
            pnDados.Controls.Add(label3);
            pnDados.Controls.Add(txtCep);
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(txtRGIE);
            pnDados.Controls.Add(lbRGIE);
            pnDados.Controls.Add(txtCPFCNPJ);
            pnDados.Controls.Add(lbCPFCNPJ);
            pnDados.Controls.Add(txrRSocial);
            pnDados.Controls.Add(lbRSocial);
            pnDados.Controls.Add(groupBox1);
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(txtCodigo);
            pnDados.Controls.Add(lbNome);
            pnDados.Controls.Add(label1);
            pnDados.Paint += pnDados_Paint;
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
            btInserir.Click += btInserir_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 8);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(20, 64);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(97, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome do Cliente";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(20, 36);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(356, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(421, 23);
            txtNome.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbJuridica);
            groupBox1.Controls.Add(rbFisica);
            groupBox1.Location = new Point(401, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 54);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo do Cliente";
            // 
            // rbJuridica
            // 
            rbJuridica.AutoSize = true;
            rbJuridica.Location = new Point(220, 22);
            rbJuridica.Name = "rbJuridica";
            rbJuridica.Size = new Size(65, 19);
            rbJuridica.TabIndex = 5;
            rbJuridica.Text = "Juridica";
            rbJuridica.UseVisualStyleBackColor = true;
            // 
            // rbFisica
            // 
            rbFisica.AutoSize = true;
            rbFisica.Checked = true;
            rbFisica.Location = new Point(42, 22);
            rbFisica.Name = "rbFisica";
            rbFisica.Size = new Size(54, 19);
            rbFisica.TabIndex = 5;
            rbFisica.TabStop = true;
            rbFisica.Text = "Fisica";
            rbFisica.UseVisualStyleBackColor = true;
            rbFisica.CheckedChanged += rbFisica_CheckedChanged;
            // 
            // lbRSocial
            // 
            lbRSocial.AutoSize = true;
            lbRSocial.Location = new Point(20, 110);
            lbRSocial.Name = "lbRSocial";
            lbRSocial.Size = new Size(72, 15);
            lbRSocial.TabIndex = 5;
            lbRSocial.Text = "Razão Social";
            lbRSocial.Visible = false;
            // 
            // txrRSocial
            // 
            txrRSocial.Location = new Point(20, 128);
            txrRSocial.Name = "txrRSocial";
            txrRSocial.Size = new Size(421, 23);
            txrRSocial.TabIndex = 6;
            txrRSocial.Visible = false;
            // 
            // lbCPFCNPJ
            // 
            lbCPFCNPJ.AutoSize = true;
            lbCPFCNPJ.Location = new Point(447, 64);
            lbCPFCNPJ.Name = "lbCPFCNPJ";
            lbCPFCNPJ.Size = new Size(28, 15);
            lbCPFCNPJ.TabIndex = 7;
            lbCPFCNPJ.Text = "CPF";
            // 
            // txtCPFCNPJ
            // 
            txtCPFCNPJ.Location = new Point(447, 80);
            txtCPFCNPJ.Name = "txtCPFCNPJ";
            txtCPFCNPJ.Size = new Size(311, 23);
            txtCPFCNPJ.TabIndex = 8;
            // 
            // lbRGIE
            // 
            lbRGIE.AutoSize = true;
            lbRGIE.Location = new Point(447, 112);
            lbRGIE.Name = "lbRGIE";
            lbRGIE.Size = new Size(22, 15);
            lbRGIE.TabIndex = 9;
            lbRGIE.Text = "RG";
            // 
            // txtRGIE
            // 
            txtRGIE.Location = new Point(447, 128);
            txtRGIE.Name = "txtRGIE";
            txtRGIE.Size = new Size(311, 23);
            txtRGIE.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 152);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 11;
            label2.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(17, 170);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(167, 23);
            txtCep.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 152);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 13;
            label3.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(190, 170);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(186, 23);
            txtEstado.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 152);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 15;
            label4.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(416, 170);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(338, 23);
            txtCidade.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 196);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 17;
            label5.Text = "Rua";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(592, 196);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 18;
            label6.Text = "Numero";
            label6.Click += label6_Click;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(17, 212);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(569, 23);
            txtRua.TabIndex = 19;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(592, 212);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(156, 23);
            txtNumero.TabIndex = 20;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(14, 252);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(410, 23);
            txtBairro.TabIndex = 23;
            txtBairro.TextChanged += textBox9_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 236);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 21;
            label8.Text = "Bairro";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(430, 252);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 23);
            txtEmail.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(433, 236);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 25;
            label9.Text = "E-mail";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(430, 294);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(318, 23);
            txtCelular.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(433, 278);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 29;
            label7.Text = "Celular";
            // 
            // txtFone
            // 
            txtFone.Location = new Point(14, 294);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(410, 23);
            txtFone.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 278);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 27;
            label10.Text = "Telefone";
            // 
            // frmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "frmCadastroCliente";
            Text = "Cadastro de Cliente";
            Load += frmCadastroCliente_Load;
            Leave += frmCadastroCliente_Leave;
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            pnBotoes.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbJuridica;
        private RadioButton rbFisica;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label lbNome;
        private Label label1;
        private TextBox txtRGIE;
        private Label lbRGIE;
        private TextBox txtCPFCNPJ;
        private Label lbCPFCNPJ;
        private TextBox txrRSocial;
        private Label lbRSocial;
        private TextBox txtCidade;
        private Label label4;
        private TextBox txtEstado;
        private Label label3;
        private TextBox txtCep;
        private Label label2;
        private TextBox txtNumero;
        private TextBox txtRua;
        private Label label6;
        private Label label5;
        private TextBox txtBairro;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtCelular;
        private Label label7;
        private TextBox txtFone;
        private Label label10;
    }
}