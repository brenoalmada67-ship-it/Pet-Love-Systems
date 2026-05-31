using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Negocio.Mapeamento
{
    /// Classe que reflete a tabela 'Categorias'.
    /// Utilizada para classificar os produtos do estoque (ex: Rações, Acessórios, Medicamentos).
    public class Categoria
    {
        // Chave Primária
        public int ID { get; set; }

        // Metadados da categoria
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}