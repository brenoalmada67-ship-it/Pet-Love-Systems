using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetShop_Negocio.Mapeamento
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int CategoriaID { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Ativo { get; set; }
    }
}