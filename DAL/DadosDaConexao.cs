using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String StringDeConexao
        {
            get
            {
                return "Data Source=DESKTOP-UIOFKUL\\SQLEXPRESS;Initial Catalog=ControleDeEstoque;Integrated Security=True;TrustServerCertificate=True;";

                // return "Data Source=DESKTOP-UIOFKUL\\SQLEXPRESS;Integrated Security=True;Encrypt=False";

                //return "Data Source=localhost;Initial Catalog=controleestoque;User ID=sa;Password=Senha123";
            }
}
    }
}
