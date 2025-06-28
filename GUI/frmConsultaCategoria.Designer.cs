namespace GUI
{
    partial class frmConsultaCategoria
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
            txtValor = new TextBox();
            btLocalizar = new Button();
            dgvDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(12, 51);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(669, 23);
            txtValor.TabIndex = 1;
            txtValor.TextChanged += textBox1_TextChanged;
            // 
            // btLocalizar
            // 
            btLocalizar.Location = new Point(700, 51);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(88, 23);
            btLocalizar.TabIndex = 2;
            btLocalizar.Text = "Localizar";
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 107);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(776, 331);
            dgvDados.TabIndex = 3;
            dgvDados.CellContentClick += dgvDados_CellContentClick;
            // 
            // frmConsultaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDados);
            Controls.Add(btLocalizar);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Name = "frmConsultaCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Categoria";
            Load += frmConsultaCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor;
        private Button btLocalizar;
        private DataGridView dgvDados;
    }
}