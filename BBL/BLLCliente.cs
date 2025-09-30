using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace BBL
{
    public class BLLCliente
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx) 
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if(modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }

            if(modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF/CNPJ do cliente é obrigatório");
            }

            //Verificar CPF/CNPJ
            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatorio");
            }

            if(modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório");
            }

            DALCLiente DALobj = new DALCLiente(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF/CNPJ do cliente é obrigatório");
            }

            //Verificar CPF/CNPJ
            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatorio");
            }

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório");
            }

            DALCLiente DALobj = new DALCLiente(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCLiente DALobj = new DALCLiente(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor) 
        {
            DALCLiente DALobj = new DALCLiente(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DALCLiente DALobj = new DALCLiente(conexao);
            return DALobj.CarregaModeloCliente(codigo);
        }

        public ModeloCliente CarregaModeloCliente(string cpfcnpj)
        {
            DALCLiente DALobj = new DALCLiente(conexao);
            return DALobj.CarregaModeloCliente(cpfcnpj);
        }
    }
}
