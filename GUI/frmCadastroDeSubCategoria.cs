using BBL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroDeSubCategoria : frmModeloDeFormularioDeCadastro
    {
        public frmCadastroDeSubCategoria()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtNome.Clear();
            txtScatCod.Clear();
        }

        private void frmCadastroDeSubCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCatCod.DataSource = bll.Localizar("");
            cbCatCod.DisplayMember = "cat_nome";
            cbCatCod.ValueMember = "cat_cod";
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            alteraBotoes(2);
            this.operacao = "alterar";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura
                ModeloSubCategoria modelo = new ModeloSubCategoria();//origin
                //ModeloDeSubCategoria modelo = new ModeloDeSubCategoria();
                modelo.ScatNome = txtNome.Text;
                modelo.CatCod = Convert.ToInt32(cbCatCod.SelectedValue);

                //Objeto para gravar no DB
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ScatCod.ToString());
                    //MessageBox.Show("ERRO ao cadastrar" + modelo.ScatCod.ToString());
                }

                else
                {
                    //alterar categoria
                    modelo.ScatCod = Convert.ToInt32(txtScatCod.Text);
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtScatCod.Text));
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

        private void cbCatCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //frmCadastroCategoria f = new frmCadastroCategoria();
            //frmCadastroDeSubCategoria f = new frmCadastroDeSubCategoria();
            //f.ShowDialog();
            //f.Dispose();
            //DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //BLLCategoria bll = new BLLCategoria(cx);
            //cbCatCod.DataSource = bll.Localizar("");
            //cbCatCod.DisplayMember = "cat_nome";
            //cbCatCod.ValueMember = "cat_cod";
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScatCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLocalizar_Click_1(object sender, EventArgs e)
        {
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo);
                txtScatCod.Text = modelo.ScatCod.ToString();
                txtNome.Text = modelo.ScatNome;
                cbCatCod.SelectedValue = modelo.CatCod;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }
    }
}
