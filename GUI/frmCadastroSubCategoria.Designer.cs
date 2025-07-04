namespace GUI
{
    partial class frmCadastroSubCategoria
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
            panel1 = new Panel();
            txtNome = new TextBox();
            txtScatCod = new TextBox();
            label3 = new Label();
            cbCatCod = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btSubInserir = new Button();
            btSubLocalizar = new Button();
            btSubAlterar = new Button();
            btSubExcluir = new Button();
            btSubSalvar = new Button();
            btSubCancelar = new Button();
            SubCodigo = new Label();
            label5 = new Label();
            cbSubCatCod = new ComboBox();
            label6 = new Label();
            txtSubScatCod = new TextBox();
            txtSubNome = new TextBox();
            pnDados.SuspendLayout();
            pnBotoes.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.Controls.Add(txtSubNome);
            pnDados.Controls.Add(txtSubScatCod);
            pnDados.Controls.Add(label6);
            pnDados.Controls.Add(cbSubCatCod);
            pnDados.Controls.Add(label5);
            pnDados.Controls.Add(SubCodigo);
            pnDados.Location = new Point(10, 11);
            pnDados.Size = new Size(679, 293);
            // 
            // pnBotoes
            // 
            pnBotoes.Controls.Add(btSubCancelar);
            pnBotoes.Controls.Add(btSubSalvar);
            pnBotoes.Controls.Add(btSubExcluir);
            pnBotoes.Controls.Add(btSubAlterar);
            pnBotoes.Controls.Add(btSubLocalizar);
            pnBotoes.Controls.Add(btSubInserir);
            pnBotoes.Location = new Point(10, 310);
            pnBotoes.Size = new Size(679, 111);
            pnBotoes.Paint += pnBotoes_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtScatCod);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbCatCod);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 306);
            panel1.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(17, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(693, 23);
            txtNome.TabIndex = 5;
            // 
            // txtScatCod
            // 
            txtScatCod.Enabled = false;
            txtScatCod.Location = new Point(17, 42);
            txtScatCod.Name = "txtScatCod";
            txtScatCod.Size = new Size(100, 23);
            txtScatCod.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 147);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 3;
            label3.Text = "Nome da Categoria";
            // 
            // cbCatCod
            // 
            cbCatCod.FormattingEnabled = true;
            cbCatCod.Location = new Point(17, 165);
            cbCatCod.Name = "cbCatCod";
            cbCatCod.Size = new Size(366, 23);
            cbCatCod.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome da SubCategoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // panel2
            // 
            panel2.Controls.Add(btCancelar);
            panel2.Controls.Add(btSalvar);
            panel2.Controls.Add(btExcluir);
            panel2.Controls.Add(btAlterar);
            panel2.Controls.Add(btLocalizar);
            panel2.Controls.Add(btInserir);
            panel2.Location = new Point(12, 338);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 100);
            panel2.TabIndex = 1;
            // 
            // btSubInserir
            // 
            btSubInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSubInserir.Image = Properties.Resources.Novo;
            btSubInserir.Location = new Point(5, 0);
            btSubInserir.Name = "btSubInserir";
            btSubInserir.Size = new Size(106, 99);
            btSubInserir.TabIndex = 0;
            btSubInserir.Text = "Inserir";
            btSubInserir.TextAlign = ContentAlignment.BottomCenter;
            btSubInserir.UseVisualStyleBackColor = true;
            btSubInserir.Click += btSubInserir_Click;
            // 
            // btSubLocalizar
            // 
            btSubLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSubLocalizar.Image = Properties.Resources.localizar_fw;
            btSubLocalizar.Location = new Point(117, 3);
            btSubLocalizar.Name = "btSubLocalizar";
            btSubLocalizar.Size = new Size(109, 96);
            btSubLocalizar.TabIndex = 1;
            btSubLocalizar.Text = "Localizar";
            btSubLocalizar.TextAlign = ContentAlignment.BottomCenter;
            btSubLocalizar.UseVisualStyleBackColor = true;
            btSubLocalizar.Click += btSubLocalizar_Click;
            // 
            // btSubAlterar
            // 
            btSubAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSubAlterar.Image = Properties.Resources.Alterar;
            btSubAlterar.Location = new Point(232, 5);
            btSubAlterar.Name = "btSubAlterar";
            btSubAlterar.Size = new Size(109, 94);
            btSubAlterar.TabIndex = 2;
            btSubAlterar.Text = "Alterar";
            btSubAlterar.TextAlign = ContentAlignment.BottomCenter;
            btSubAlterar.UseVisualStyleBackColor = true;
            btSubAlterar.Click += button3_Click;
            // 
            // btSubExcluir
            // 
            btSubExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSubExcluir.Image = Properties.Resources.Excluir;
            btSubExcluir.Location = new Point(347, 5);
            btSubExcluir.Name = "btSubExcluir";
            btSubExcluir.Size = new Size(99, 94);
            btSubExcluir.TabIndex = 3;
            btSubExcluir.Text = "Excluir";
            btSubExcluir.TextAlign = ContentAlignment.BottomCenter;
            btSubExcluir.UseVisualStyleBackColor = true;
            btSubExcluir.Click += btSubExcluir_Click;
            // 
            // btSubSalvar
            // 
            btSubSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSubSalvar.Image = Properties.Resources.Salvar1_fw;
            btSubSalvar.Location = new Point(452, 3);
            btSubSalvar.Name = "btSubSalvar";
            btSubSalvar.RightToLeft = RightToLeft.Yes;
            btSubSalvar.Size = new Size(102, 96);
            btSubSalvar.TabIndex = 4;
            btSubSalvar.Text = "Salvar";
            btSubSalvar.TextAlign = ContentAlignment.BottomCenter;
            btSubSalvar.UseVisualStyleBackColor = true;
            btSubSalvar.Click += btSubSalvar_Click;
            // 
            // btSubCancelar
            // 
            btSubCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSubCancelar.Image = Properties.Resources.Cancelar;
            btSubCancelar.Location = new Point(560, 3);
            btSubCancelar.Name = "btSubCancelar";
            btSubCancelar.Size = new Size(109, 96);
            btSubCancelar.TabIndex = 5;
            btSubCancelar.Text = "Cancelar";
            btSubCancelar.TextAlign = ContentAlignment.BottomCenter;
            btSubCancelar.UseVisualStyleBackColor = true;
            btSubCancelar.Click += btSubCancelar_Click;
            // 
            // SubCodigo
            // 
            SubCodigo.AutoSize = true;
            SubCodigo.Location = new Point(20, 20);
            SubCodigo.Name = "SubCodigo";
            SubCodigo.Size = new Size(46, 15);
            SubCodigo.TabIndex = 0;
            SubCodigo.Text = "Código";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 77);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 1;
            label5.Text = "Nome da SubCategoria";
            label5.Click += label5_Click;
            // 
            // cbSubCatCod
            // 
            cbSubCatCod.FormattingEnabled = true;
            cbSubCatCod.Location = new Point(20, 152);
            cbSubCatCod.Name = "cbSubCatCod";
            cbSubCatCod.Size = new Size(321, 23);
            cbSubCatCod.TabIndex = 2;
            cbSubCatCod.SelectedIndexChanged += cbSubCatCod_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 134);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 3;
            label6.Text = "Nome da Categoria";
            // 
            // txtSubScatCod
            // 
            txtSubScatCod.Location = new Point(20, 38);
            txtSubScatCod.Name = "txtSubScatCod";
            txtSubScatCod.Size = new Size(106, 23);
            txtSubScatCod.TabIndex = 4;
            // 
            // txtSubNome
            // 
            txtSubNome.Location = new Point(20, 95);
            txtSubNome.Name = "txtSubNome";
            txtSubNome.Size = new Size(583, 23);
            txtSubNome.TabIndex = 5;
            // 
            // frmCadastroSubCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(703, 429);
            Name = "frmCadastroSubCategoria";
            Text = "Cadastro de SubCategoria";
            Load += frmCadastroSubCategoria_Load;
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            pnBotoes.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            //ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private ComboBox cbCatCod;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox txtNome;
        private TextBox txtScatCod;
        private Button btAlterar;
        private Button btLocalizar;
        private Button btInserir;
        private Button btSalvar;
        private Button btExcluir;
        private Button btCancelar;
        private Button txtCodigo;
        private System.Windows.Forms.Button btAdd;
        private Button btSubInserir;
        private Button btSubCancelar;
        private Button btSubSalvar;
        private Button btSubExcluir;
        private Button btSubAlterar;
        private Button btSubLocalizar;
        private TextBox txtSubScatCod;
        private Label label6;
        private ComboBox cbSubCatCod;
        private Label label5;
        private Label SubCodigo;
        private TextBox txtSubNome;
    }
}