using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Negocio.Mapeamento
{
    /// Classe que reflete a tabela 'Cidades'.
    /// Fundamental para o controle de logística de entregas e busca em domicílio (Táxi Dog).
    public class Cidade
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        // Armazena a Unidade Federativa (ex: SP, RJ). Mapeia o CHAR(2) do banco.
        public string UF { get; set; }
    }
}