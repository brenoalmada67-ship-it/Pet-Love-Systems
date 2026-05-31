using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Negocio
{
    public class Conexao
    {
        public SqlConnection banco = null;

        public Conexao()
        {
            // Arquiteto Sênior: Portabilidade ativada. O ponto (.) instrui o código a procurar
            // a instância SQLEXPRESS na máquina local de quem estiver executando o projeto.
            banco = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PetShopBanco;Integrated Security=true;");
        }
    }
}