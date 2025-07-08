using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using DAL;
using Modelo;
using BBL;

namespace GUI
{
    public partial class frmCadastroCategoria : Form
    //public partial class frmCadastroCategoria : GUI.frmModeloDeFormularioDeCadastro
    {
        public String operacao;
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }      

        public void alteraBotoes(int op)
        {
            // op = operaçoes que serao feitas com os botoes
            // 1  = Preparar os botoes para inserir e localizar
            // 2  = preparar os para inserir/alterar um registro
            // 3  = preparar a tela para excluir ou alterar

            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }

        private void btExcluir_Click_1(object sender, EventArgs e)
        {

            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCategoria bll = new BLLCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btAlterar_Click_1(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);
                ModeloCategoria modelo = bll.CarregaModeloCategoria(f.codigo);
                txtCodigo.Text = modelo.CatCod.ToString();
                txtNome.Text = modelo.CatNome;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura
                ModeloCategoria modelo = new ModeloCategoria();
                modelo.CatNome = txtNome.Text;

                //Objeto para gravar no DB
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.CatCod.ToString());
                }

                else
                {
                    //alterar categoria
                    modelo.CatCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }


        /*
          private void button3_Click(object sender, EventArgs e)
         {

         }
        private void button4_Click(object sender, EventArgs e)
        {

        }
         private void label1_Click(object sender, EventArgs e)
        {

        }
        */
    }
}
