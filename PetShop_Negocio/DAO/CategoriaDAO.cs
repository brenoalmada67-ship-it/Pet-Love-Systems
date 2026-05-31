using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_Negocio.Mapeamento;
using Dapper;


namespace PetShop_Negocio.DAO
{
    /// Classe de operações transacionais (CRUD) para a entidade Categoria.
    public class CategoriaDAO : Conexao
    {
        public void Inserir(Categoria categoria)
        {
            string sql = "INSERT INTO Categorias (Nome, Descricao) VALUES (@Nome, @Descricao)";
            // O Dapper extrai automaticamente os valores das propriedades Nome e Descricao do objeto 'categoria'.
            banco.Execute(sql, categoria);
        }

        public List<Categoria> Listar()
        {
            string sql = "SELECT * FROM Categorias ORDER BY Nome";
            return banco.Query<Categoria>(sql).ToList();
        }

        public void Alterar(Categoria categoria)
        {
            string sql = "UPDATE Categorias SET Nome = @Nome, Descricao = @Descricao WHERE ID = @ID";
            banco.Execute(sql, categoria);
        }

        public void Excluir(int id)
        {
            string sql = "DELETE FROM Categorias WHERE ID = @IdExclusao";
            banco.Execute(sql, new { IdExclusao = id });
        }
    }
}