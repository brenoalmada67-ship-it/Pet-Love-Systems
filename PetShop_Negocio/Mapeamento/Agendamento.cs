using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Negocio.Mapeamento
{
    public class Agendamento
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public string NomeCliente { get; set; }
        public string NomeAnimal { get; set; }
        public string TipoAnimal { get; set; }
        public string Servico { get; set; } // O novo campo adicionado
        public DateTime DataAgendamento { get; set; }
        public TimeSpan Horario { get; set; }
        public decimal Valor { get; set; }
    }
}