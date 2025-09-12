namespace GUI
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            label1 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            txtDescricao = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtQtde = new TextBox();
            txtValorPago = new TextBox();
            label6 = new Label();
            txtValorVenda = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbUnd = new ComboBox();
            cbCategoria = new ComboBox();
            cbSubCategoria = new ComboBox();
            panel1 = new Panel();
            pbFoto = new PictureBox();
            label10 = new Label();
            btLoFoto = new Button();
            btRmFoto = new Button();
            pnDados.SuspendLayout();
            pnBotoes.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.Controls.Add(btRmFoto);
            pnDados.Controls.Add(btLoFoto);
            pnDados.Controls.Add(label10);
            pnDados.Controls.Add(panel1);
            pnDados.Controls.Add(cbSubCategoria);
            pnDados.Controls.Add(cbCategoria);
            pnDados.Controls.Add(cbUnd);
            pnDados.Controls.Add(label9);
            pnDados.Controls.Add(label8);
            pnDados.Controls.Add(label7);
            pnDados.Controls.Add(txtValorVenda);
            pnDados.Controls.Add(label6);
            pnDados.Controls.Add(txtValorPago);
            pnDados.Controls.Add(txtQtde);
            pnDados.Controls.Add(label5);
            pnDados.Controls.Add(label4);
            pnDados.Controls.Add(txtDescricao);
            pnDados.Controls.Add(label3);
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(txtCodigo);
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(label1);
            pnDados.Size = new Size(776, 334);
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
            // btInserir
            // 
            btInserir.Click += btInserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 6);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 50);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(26, 24);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(107, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(26, 68);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(295, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 94);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(26, 112);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(295, 83);
            txtDescricao.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 242);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 6;
            label4.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 198);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 7;
            label5.Text = "Valor Pago";
            // 
            // txtQtde
            // 
            txtQtde.Location = new Point(26, 260);
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(132, 23);
            txtQtde.TabIndex = 8;
            txtQtde.KeyPress += txtQtde_KeyPress;
            txtQtde.Leave += txtQtde_Leave;
            // 
            // txtValorPago
            // 
            txtValorPago.Location = new Point(26, 216);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(132, 23);
            txtValorPago.TabIndex = 9;
            txtValorPago.KeyPress += txtValorPago_KeyPress;
            txtValorPago.Leave += txtValorPago_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 198);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 10;
            label6.Text = "Valor de Venda";
            label6.Click += label6_Click;
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(174, 216);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(140, 23);
            txtValorVenda.TabIndex = 11;
            txtValorVenda.KeyPress += txtValorVenda_KeyPress;
            txtValorVenda.Leave += txtValorVenda_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(173, 242);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 12;
            label7.Text = "Unidade de Medida";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 286);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 13;
            label8.Text = "Categoria";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(174, 286);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 14;
            label9.Text = "SubCategoria";
            // 
            // cbUnd
            // 
            cbUnd.FormattingEnabled = true;
            cbUnd.Location = new Point(173, 260);
            cbUnd.Name = "cbUnd";
            cbUnd.Size = new Size(141, 23);
            cbUnd.TabIndex = 15;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(26, 304);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(132, 23);
            cbCategoria.TabIndex = 16;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // cbSubCategoria
            // 
            cbSubCategoria.FormattingEnabled = true;
            cbSubCategoria.Location = new Point(177, 304);
            cbSubCategoria.Name = "cbSubCategoria";
            cbSubCategoria.Size = new Size(137, 23);
            cbSubCategoria.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pbFoto);
            panel1.Location = new Point(347, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 221);
            panel1.TabIndex = 18;
            // 
            // pbFoto
            // 
            pbFoto.Dock = DockStyle.Fill;
            pbFoto.Location = new Point(0, 0);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(393, 217);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 0;
            pbFoto.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(347, 6);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 19;
            label10.Text = "Foto";
            // 
            // btLoFoto
            // 
            btLoFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLoFoto.Image = (Image)resources.GetObject("btLoFoto.Image");
            btLoFoto.ImageAlign = ContentAlignment.TopCenter;
            btLoFoto.Location = new Point(394, 265);
            btLoFoto.Name = "btLoFoto";
            btLoFoto.Size = new Size(114, 62);
            btLoFoto.TabIndex = 20;
            btLoFoto.Text = "Carregar Foto";
            btLoFoto.TextAlign = ContentAlignment.BottomCenter;
            btLoFoto.UseVisualStyleBackColor = true;
            btLoFoto.Click += btLoFoto_Click;
            // 
            // btRmFoto
            // 
            btRmFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btRmFoto.Image = (Image)resources.GetObject("btRmFoto.Image");
            btRmFoto.ImageAlign = ContentAlignment.TopCenter;
            btRmFoto.Location = new Point(595, 265);
            btRmFoto.Name = "btRmFoto";
            btRmFoto.Size = new Size(114, 62);
            btRmFoto.TabIndex = 21;
            btRmFoto.Text = "Remover Foto";
            btRmFoto.TextAlign = ContentAlignment.BottomCenter;
            btRmFoto.UseVisualStyleBackColor = true;
            btRmFoto.Click += btRmFoto_Click;
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "frmCadastroProduto";
            Text = "Cadastro de produto";
            Load += frmCadastroProduto_Load;
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            pnBotoes.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtValorVenda;
        private Label label6;
        private TextBox txtValorPago;
        private TextBox txtQtde;
        private Label label5;
        private Label label4;
        private TextBox txtDescricao;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
        private ComboBox cbSubCategoria;
        private ComboBox cbCategoria;
        private ComboBox cbUnd;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btRmFoto;
        private Button btLoFoto;
        private Label label10;
        private Panel panel1;
        private PictureBox pbFoto;
    }
}