namespace GUI
{
    partial class frmBackupBancoDeDados
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
            btBackup = new Button();
            btRestaurar = new Button();
            SuspendLayout();
            // 
            // btBackup
            // 
            btBackup.Location = new Point(35, 12);
            btBackup.Name = "btBackup";
            btBackup.Size = new Size(718, 181);
            btBackup.TabIndex = 0;
            btBackup.Text = "Backup do Banco de Dados";
            btBackup.UseVisualStyleBackColor = true;
            btBackup.Click += btBackup_Click;
            // 
            // btRestaurar
            // 
            btRestaurar.Location = new Point(35, 215);
            btRestaurar.Name = "btRestaurar";
            btRestaurar.Size = new Size(718, 181);
            btRestaurar.TabIndex = 3;
            btRestaurar.Text = "Restaurar o Bando de Dados";
            btRestaurar.UseVisualStyleBackColor = true;
            // 
            // frmBackupBancoDeDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btRestaurar);
            Controls.Add(btBackup);
            Name = "frmBackupBancoDeDados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup do Banco de Dados";
            ResumeLayout(false);
        }

        #endregion

        private Button btBackup;
        private Button btRestaurar;
    }
}