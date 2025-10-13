namespace GUI
{
    partial class frmConsultaCliente
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
            dgvDados = new DataGridView();
            btLocalizar = new Button();
            txtValor = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbNome = new RadioButton();
            rbCPF = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 125);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(776, 308);
            dgvDados.TabIndex = 7;
            // 
            // btLocalizar
            // 
            btLocalizar.Location = new Point(701, 49);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(88, 23);
            btLocalizar.TabIndex = 6;
            btLocalizar.Text = "Localizar";
            btLocalizar.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(140, 49);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(542, 23);
            txtValor.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 22);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 4;
            label1.Text = "Valor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbCPF);
            groupBox1.Controls.Add(rbNome);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(122, 107);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultar Pelo:";
            // 
            // rbNome
            // 
            rbNome.AutoSize = true;
            rbNome.Checked = true;
            rbNome.Location = new Point(6, 33);
            rbNome.Name = "rbNome";
            rbNome.Size = new Size(58, 19);
            rbNome.TabIndex = 0;
            rbNome.TabStop = true;
            rbNome.Text = "Nome";
            rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCPF
            // 
            rbCPF.AutoSize = true;
            rbCPF.Location = new Point(6, 67);
            rbCPF.Name = "rbCPF";
            rbCPF.Size = new Size(78, 19);
            rbCPF.TabIndex = 1;
            rbCPF.Text = "CPF/CNPJ";
            rbCPF.TextAlign = ContentAlignment.MiddleCenter;
            rbCPF.UseVisualStyleBackColor = true;
            // 
            // frmConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvDados);
            Controls.Add(btLocalizar);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Name = "frmConsultaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Cliente";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDados;
        private Button btLocalizar;
        private TextBox txtValor;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbCPF;
        private RadioButton rbNome;
    }
}