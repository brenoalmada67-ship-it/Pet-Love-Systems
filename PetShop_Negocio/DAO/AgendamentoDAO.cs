using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_Negocio.Mapeamento;
using Dapper;

namespace PetShop_Negocio.DAO
{
    public class AgendamentoDAO : Conexao
    {
        public void Inserir(Agendamento agendamento)
        {
            // Adicionado o Servico no INSERT
            string sql = @"INSERT INTO Agendamentos (IDCliente, NomeAnimal, TipoAnimal, Servico, DataAgendamento, Horario, Valor) 
                           VALUES (@IDCliente, @NomeAnimal, @TipoAnimal, @Servico, @DataAgendamento, @Horario, @Valor)";
            banco.Execute(sql, agendamento);
        }

        public List<Agendamento> Listar()
        {
            // Adicionado o a.Servico no SELECT
            string sql = @"SELECT a.ID, a.IDCliente, c.Nome AS NomeCliente, a.NomeAnimal, a.TipoAnimal, a.Servico, a.DataAgendamento, a.Horario, a.Valor 
                           FROM Agendamentos a
                           INNER JOIN Clientes c ON a.IDCliente = c.ID
                           ORDER BY a.DataAgendamento DESC, a.Horario ASC";

            return banco.Query<Agendamento>(sql).ToList();
        }

        public void Alterar(Agendamento agendamento)
        {
            // Adicionado o Servico = @Servico no UPDATE
            string sql = @"UPDATE Agendamentos 
                           SET IDCliente = @IDCliente, NomeAnimal = @NomeAnimal, TipoAnimal = @TipoAnimal, 
                               Servico = @Servico, DataAgendamento = @DataAgendamento, Horario = @Horario, Valor = @Valor 
                           WHERE ID = @ID";
            banco.Execute(sql, agendamento);
        }

        public void Excluir(int id)
        {
            string sql = "DELETE FROM Agendamentos WHERE ID = @IdExclusao";
            banco.Execute(sql, new { IdExclusao = id });
        }

        public List<TimeSpan> BuscarHorariosOcupados(DateTime data)
        {
            string sql = "SELECT Horario FROM Agendamentos WHERE DataAgendamento = @Data";
            return banco.Query<TimeSpan>(sql, new { Data = data.Date }).ToList();
        }
    }
}