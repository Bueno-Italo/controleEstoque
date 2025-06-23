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
    

    public partial class frmCadastroCategoria : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btInserir_click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void alteraBotoes(int v)
        {
            throw new NotImplementedException();
        }
    }
}
/*
public Modelo_de_Formulario_de_Cadastro()
        {
            InitializeComponent();
        }

public partial class Modelo_de_Formulario_de_Cadastro : GUI.frmModeloDeFormularioDeCadastro  Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void Modelo_de_Formulario_de_Cadastro_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }
    }



*/