using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_Negocio.Mapeamento;
using Dapper;

namespace PetShop_Negocio.DAO
{
    public class ClienteDAO : Conexao
    {
        // Insere um novo cliente no banco
        public void Inserir(Cliente cliente)
        {
            string sql = "INSERT INTO Clientes (Nome, CPF, Telefone, Cidade, Estado) VALUES (@Nome, @CPF, @Telefone, @Cidade, @Estado)";
            banco.Execute(sql, cliente);
        }

        // Busca todos os clientes para exibir na grelha
        public List<Cliente> Listar()
        {
            string sql = "SELECT ID, Nome, CPF, Telefone, Cidade, Estado FROM Clientes ORDER BY Nome";
            return banco.Query<Cliente>(sql).ToList();
        }

        // Atualiza os dados de um cliente existente
        public void Alterar(Cliente cliente)
        {
            string sql = "UPDATE Clientes SET Nome = @Nome, CPF = @CPF, Telefone = @Telefone, Cidade = @Cidade, Estado = @Estado WHERE ID = @ID";
            banco.Execute(sql, cliente);
        }

        // Remove o cliente
        public void Excluir(int id)
        {
            string sql = "DELETE FROM Clientes WHERE ID = @IdExclusao";
            banco.Execute(sql, new { IdExclusao = id });
        }
    }
}