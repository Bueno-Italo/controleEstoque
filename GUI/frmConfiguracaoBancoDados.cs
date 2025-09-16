using System;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConfiguracaoBancoDados : Form
    {
        public frmConfiguracaoBancoDados()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria/reescreve o arquivo com servidor e banco
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBanco.txt", false);
                arquivo.WriteLine(txtServidor.Text);
                arquivo.WriteLine(txtBanco.Text);
                arquivo.Close();

                MessageBox.Show("Configuração salva com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar configuração: " + erro.Message);
            }
        }

        private void frmConfiguracaoBancoDados_Load(object sender, EventArgs e)
        {
            try
            {
                // Se o arquivo já existe, carrega os dados
                if (File.Exists("ConfiguracaoBanco.txt"))
                {
                    StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                    txtServidor.Text = arquivo.ReadLine();
                    txtBanco.Text = arquivo.ReadLine();
                    arquivo.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar configuração: " + erro.Message);
            }
        }
    }
}
