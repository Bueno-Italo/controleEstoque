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
            btCancelar = new Button();
            btSalvar = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btLocalizar = new Button();
            btInserir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
//            SuspendLayout();
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
           // txtScatCod.TextChanged += txtScatCod_TextChanged;
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
            //cbCatCod.SelectedIndexChanged += cbCatCod_SelectedIndexChanged;
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
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.Image = Properties.Resources.Cancelar;
            btCancelar.Location = new Point(656, 3);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(117, 94);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.TextAlign = ContentAlignment.BottomCenter;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btSalvar
            // 
            btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvar.Image = Properties.Resources.Salvar1_fw;
            btSalvar.Location = new Point(530, 3);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(120, 97);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.TextAlign = ContentAlignment.BottomCenter;
            btSalvar.UseVisualStyleBackColor = true;
            //btSalvar.Click += btSalvar_Click_1;
            // 
            // btExcluir
            // 
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluir.Image = Properties.Resources.Excluir;
            btExcluir.Location = new Point(401, 3);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(123, 93);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Excluir";
            btExcluir.TextAlign = ContentAlignment.BottomCenter;
            btExcluir.UseVisualStyleBackColor = true;
            //btExcluir.Click += btExcluir_Click_1;
            // 
            // btAlterar
            // 
            btAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterar.Image = Properties.Resources.Alterar;
            btAlterar.Location = new Point(266, 3);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(129, 94);
            btAlterar.TabIndex = 2;
            btAlterar.Text = "Alterar";
            btAlterar.TextAlign = ContentAlignment.BottomCenter;
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click;
            // 
            // btLocalizar
            // 
            btLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLocalizar.Image = Properties.Resources.localizar_fw;
            btLocalizar.Location = new Point(133, 2);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(127, 94);
            btLocalizar.TabIndex = 1;
            btLocalizar.Text = "Localizar";
            btLocalizar.TextAlign = ContentAlignment.BottomCenter;
            btLocalizar.UseVisualStyleBackColor = true;
            //btLocalizar.Click += btLocalizar_Click_1;
            // 
            // btInserir
            // 
            btInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInserir.Image = Properties.Resources.Novo;
            btInserir.Location = new Point(7, 2);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(120, 94);
            btInserir.TabIndex = 0;
            btInserir.Text = "Inserir";
            btInserir.TextAlign = ContentAlignment.BottomCenter;
            btInserir.UseVisualStyleBackColor = true;
            //btInserir.Click += btInserir_Click_1;
            // 
            // frmCadastroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Name = "frmCadastroSubCategoria";
            this.Text = "Cadastro de SubCategoria";
            this.Load += new System.EventHandler(this.frmCadastroSubCategoria_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            //AutoScaleDimensions = new SizeF(7F, 15F);
            //AutoScaleMode = AutoScaleMode.Font;
            //ClientSize = new Size(800, 450);
            // Controls.Add(panel2);
            // Controls.Add(panel1);
            //Name = "frmCadastroSubCategoria";
           // StartPosition = FormStartPosition.CenterScreen;
            //Text = "Cadastro de SubCategoria";
            //Load += frmCadastroSubCategoria_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
    }
}