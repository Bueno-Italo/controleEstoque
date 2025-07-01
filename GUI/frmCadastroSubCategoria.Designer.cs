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
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            cbCatCod = new ComboBox();
            label3 = new Label();
            txtScatCod = new TextBox();
            txtNome = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panel2
            // 
            panel2.Location = new Point(12, 338);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 100);
            panel2.TabIndex = 1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome da SubCategoria";
            // 
            // cbCatCod
            // 
            cbCatCod.FormattingEnabled = true;
            cbCatCod.Location = new Point(17, 165);
            cbCatCod.Name = "cbCatCod";
            cbCatCod.Size = new Size(366, 23);
            cbCatCod.TabIndex = 2;
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
            // txtScatCod
            // 
            txtScatCod.Enabled = false;
            txtScatCod.Location = new Point(17, 42);
            txtScatCod.Name = "txtScatCod";
            txtScatCod.Size = new Size(100, 23);
            txtScatCod.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(17, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(693, 23);
            txtNome.TabIndex = 5;
            // 
            // frmCadastroSubCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCadastroSubCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de SubCategoria";
            Load += frmCadastroSubCategoria_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
    }
}