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
using Ferramentas;

namespace GUI
{
    public partial class frmCadastroCliente : frmModeloDeFormularioDeCadastro
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCodigo.Text = modelo.CliCod.ToString();

                if (modelo.CliTipo == "Física")
                {
                    rbFisica.Checked = true;
                }
                else
                {
                    rbFisica.Checked = false;
                }

                txtNome.Text = modelo.CliNome;
                txrRSocial.Text = modelo.CliRSocial;
                txtCPFCNPJ.Text = modelo.CliCpfCnpj;
                txtRGIE.Text = modelo.CliRgIe;
                txtCep.Text = modelo.CliCep;
                txtEstado.Text = modelo.CliEstado;
                txtCidade.Text = modelo.CliCidade;
                txtRua.Text = modelo.CliEndereco;
                txtNumero.Text = modelo.CliEndNumero;
                txtBairro.Text = modelo.CliBairro;
                txtEmail.Text = modelo.CliEmail;
                txtFone.Text = modelo.CliFone;
                txtCelular.Text = modelo.CliCelular;

                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtNome.Text;
                modelo.CliRSocial = txrRSocial.Text;
                modelo.CliCpfCnpj = txtCPFCNPJ.Text;
                modelo.CliRgIe = txtRGIE.Text;
                modelo.CliCep = txtCep.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliEndereco = txtRua.Text;
                modelo.CliEndNumero = txtNumero.Text;
                modelo.CliBairro = txtBairro.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliFone = txtFone.Text;
                modelo.CliCelular = txtCelular.Text;

                if (rbFisica.Checked == true)
                {
                    modelo.CliTipo = "Física"; //Pessoa Fisica
                    modelo.CliRSocial = "";
                }
                else
                {
                    modelo.CliTipo = "Jurídica"; //Juridica
                }

                //Objeto para gravar no DB
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.CliCod.ToString());
                }

                else
                {
                    //alterar categoria
                    modelo.CliCod = Convert.ToInt32(txtCodigo.Text);
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

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btInserir_Click_1(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtCPFCNPJ.Clear();
            txtEmail.Clear();
            txtEstado.Clear();
            txtFone.Clear();
            txtNumero.Clear();
            txtRGIE.Clear();
            txrRSocial.Clear();
            txtRua.Clear();

            rbFisica.Checked = true;

        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked == true)
            {
                lbRSocial.Visible = false;
                txrRSocial.Visible = false;
                lbCPFCNPJ.Text = "CPF";
                lbRGIE.Text = "RG";
            }
            else
            {
                lbRSocial.Visible = true;
                txrRSocial.Visible = true;
                lbCPFCNPJ.Text = "CNPJ";
                lbRGIE.Text = "IE";
            }
        }

        private void frmCadastroCliente_Leave(object sender, EventArgs e)
        {
            if (BuscaEndereco.verificaCEP(txtCep.Text) == true)
            {
                txtBairro.Text = BuscaEndereco.bairro;
                txtEstado.Text = BuscaEndereco.estado;
                txtCidade.Text = BuscaEndereco.cidade;
                txtRua.Text = BuscaEndereco.endereco;

            }
        }

        private void txtCPFCNPJ_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;
            if (rbFisica.Checked == true)
            {
                //cpf
                if (Validacao.IsCpf(txtCPFCNPJ.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
            }
            else
            {
                if (Validacao.IsCnpj(txtCPFCNPJ.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
            }
        }
    }
}
