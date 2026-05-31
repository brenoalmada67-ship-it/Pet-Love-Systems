using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_Negocio.Mapeamento;
using Dapper;


namespace PetShop_Negocio.DAO
{
    // Classe de operações transacionais (CRUD) para a entidade Cidade.
    // Gerencia a base logística para o cadastro de tutores.
    public class CidadeDAO : Conexao
    {
        // Insere um novo registro de cidade no banco de dados.
        public void Inserir(Cidade cidade)
        {
            string sql = "INSERT INTO Cidades (Nome, UF) VALUES (@Nome, @UF)";
            banco.Execute(sql, cidade);
        }

        // Recupera todos os registros de cidades, ordenados alfabeticamente.
        public List<Cidade> Listar()
        {
            string sql = "SELECT * FROM Cidades ORDER BY Nome";
            return banco.Query<Cidade>(sql).ToList();
        }

        // Atualiza os dados de uma cidade existente com base no seu ID.
        public void Alterar(Cidade cidade)
        {
            string sql = "UPDATE Cidades SET Nome = @Nome, UF = @UF WHERE ID = @ID";
            banco.Execute(sql, cidade);
        }

        // Remove fisicamente o registro da cidade. 
        // Falhará se houver Clientes vinculados a esta cidade (Restrição de Chave Estrangeira).
        public void Excluir(int id)
        {
            string sql = "DELETE FROM Cidades WHERE ID = @IdExclusao";
            banco.Execute(sql, new { IdExclusao = id });
        }
    }
}