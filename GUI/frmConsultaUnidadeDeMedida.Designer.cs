namespace GUI
{
    partial class frmConsultaUnidadeDeMedida
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
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 102);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(776, 331);
            dgvDados.TabIndex = 7;
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            // 
            // btLocalizar
            // 
            btLocalizar.Location = new Point(700, 46);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(88, 23);
            btLocalizar.TabIndex = 6;
            btLocalizar.Text = "Localizar";
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(12, 46);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(669, 23);
            txtValor.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 4;
            label1.Text = "Unidade de medida";
            // 
            // frmConsultaUnidadeDeMedida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDados);
            Controls.Add(btLocalizar);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Name = "frmConsultaUnidadeDeMedida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Unidade de Medida";
            Load += frmConsultaUnidadeDeMedida_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDados;
        private Button btLocalizar;
        private TextBox txtValor;
        private Label label1;
    }
}