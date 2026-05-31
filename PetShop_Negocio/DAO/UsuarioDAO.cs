using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_Negocio.Mapeamento;
using Dapper;

namespace PetShop_Negocio.DAO
{
    public class UsuarioDAO : Conexao
    {
        public void Inserir(Usuario usuario)
        {
            string sql = @"INSERT INTO Usuarios (Nome, Cargo, Login, Senha, AcessaProdutos, AcessaClientes, AcessaCidades, AcessaCategorias, Admin, Ativo) 
                           VALUES (@Nome, @Cargo, @Login, @Senha, @AcessaProdutos, @AcessaClientes, @AcessaCidades, @AcessaCategorias, @Admin, 1)";
            banco.Execute(sql, usuario);
        }

        public List<Usuario> Listar()
        {
            // Traz apenas os usuários ativos
            string sql = "SELECT * FROM Usuarios WHERE Ativo = 1";
            return banco.Query<Usuario>(sql).ToList();
        }

        public void Alterar(Usuario usuario)
        {
            string sql = @"UPDATE Usuarios 
                           SET Nome = @Nome, Cargo = @Cargo, Login = @Login, Senha = @Senha, 
                               AcessaProdutos = @AcessaProdutos, AcessaClientes = @AcessaClientes, 
                               AcessaCidades = @AcessaCidades, AcessaCategorias = @AcessaCategorias, Admin = @Admin 
                           WHERE ID = @ID";
            banco.Execute(sql, usuario);
        }

        public void Excluir(int id)
        {
            // Exclusão Lógica: Apenas desativa o usuário para não quebrar o histórico do banco
            string sql = "UPDATE Usuarios SET Ativo = 0 WHERE ID = @IdExclusao";
            banco.Execute(sql, new { IdExclusao = id });
        }

        public Usuario Login(string login, string senha)
        {

            string sql = "SELECT * FROM Usuarios WHERE Login = @Login AND Senha = @Senha AND Ativo = 1";


            return banco.QueryFirstOrDefault<Usuario>(sql, new { Login = login, Senha = senha });
        }
    }
}