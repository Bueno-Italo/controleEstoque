
namespace GUI
{
    partial class frmCadastroCategoria
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
            btCancelar = new Button();
            btSalvar = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btLocalizar = new Button();
            btInserir = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 320);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btCancelar);
            panel2.Controls.Add(btSalvar);
            panel2.Controls.Add(btExcluir);
            panel2.Controls.Add(btAlterar);
            panel2.Controls.Add(btLocalizar);
            panel2.Controls.Add(btInserir);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(12, 338);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 100);
            panel2.TabIndex = 1;
            // 
            // btCancelar
            // 
            btCancelar.Image = Properties.Resources.Cancelar;
            btCancelar.Location = new Point(669, 6);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(94, 91);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.TextAlign = ContentAlignment.BottomCenter;
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvar.Image = Properties.Resources.Salvar1_fw;
            btSalvar.Location = new Point(544, 6);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(92, 91);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.TextAlign = ContentAlignment.BottomCenter;
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluir.Image = Properties.Resources.Excluir;
            btExcluir.Location = new Point(424, 6);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(83, 91);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Excluir";
            btExcluir.TextAlign = ContentAlignment.BottomCenter;
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            btAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterar.Image = Properties.Resources.Alterar;
            btAlterar.Location = new Point(300, 6);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(86, 91);
            btAlterar.TabIndex = 2;
            btAlterar.Text = "Alterar";
            btAlterar.TextAlign = ContentAlignment.BottomCenter;
            btAlterar.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            btLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLocalizar.Image = Properties.Resources.localizar_fw;
            btLocalizar.Location = new Point(163, 6);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(89, 91);
            btLocalizar.TabIndex = 1;
            btLocalizar.Text = "Localizar";
            btLocalizar.TextAlign = ContentAlignment.BottomCenter;
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += button2_Click;
            // 
            // btInserir
            // 
            btInserir.BackgroundImage = Properties.Resources.Novo;
            btInserir.BackgroundImageLayout = ImageLayout.Center;
            btInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInserir.Location = new Point(28, 3);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(96, 94);
            btInserir.TabIndex = 0;
            btInserir.Text = "Inserir";
            btInserir.TextAlign = ContentAlignment.BottomCenter;
            btInserir.UseVisualStyleBackColor = true;
            // 
            // frmCadastroCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCadastroCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fmCadastroCategoria";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btCancelar;
        private Button btSalvar;
        private Button btExcluir;
        private Button btAlterar;
        private Button btLocalizar;
        private Button btInserir;

    }
}