using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using PetShop_Negocio.Mapeamento;
using Dapper;

namespace PetShop_Negocio.DAO
{
    // Classe de operações transacionais (CRUD) para controle do inventário físico e financeiro.
    public class ProdutoDAO : Conexao
    {
        // Registra um novo produto, vinculando-o à sua respectiva Categoria (Setor).
        public void Inserir(Produto produto)
        {
            string sql = @"INSERT INTO Produtos (Nome, Preco, Estoque, IDCategoria, Ativo) 
                           VALUES (@Nome, @ValorUnitario, @Quantidade, @CategoriaID, @Ativo)";

            banco.Execute(sql, produto);
        }

        // Lista todo o estoque da loja, ordenado pelo nome do produto.

        public List<Produto> Listar()
        {
            // A MÁGICA: (Preco * Estoque) AS ValorTotal faz o SQL calcular a multiplicação na hora e injetar na sua classe C#
            string sql = "SELECT ID, Nome, Preco AS ValorUnitario, Estoque AS Quantidade, (Preco * Estoque) AS ValorTotal, IDCategoria AS CategoriaID, Ativo FROM Produtos ORDER BY Nome";
            return banco.Query<Produto>(sql).ToList();
        }

        // Atualiza dados financeiros (Preco), logísticos (Estoque) e estruturais (IDCategoria).
        public void Alterar(Produto produto)
        {
            string sql = @"UPDATE Produtos 
                           SET Nome = @Nome, 
                               Preco = @ValorUnitario, 
                               Estoque = @Quantidade, 
                               IDCategoria = @CategoriaID,
                               Ativo = @Ativo
                           WHERE ID = @ID";

            banco.Execute(sql, produto);
        }

        // Remove o produto do catálogo.
        public void Excluir(int id)
        {
            string sql = "DELETE FROM Produtos WHERE ID = @IdExclusao";
            banco.Execute(sql, new { IdExclusao = id });
        }
    }
}