using Dapper;
using ex2.Entities;
using ex2.Settings;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Repositories
{
    /// <summary>
    /// Repositório de dados para Funcionários
    /// </summary>
    public class FuncionarioRepository
    {
        /// <summary>
        /// Atributo privado somente-leitura da classe AppSettings
        /// </summary>
        private readonly AppSettings _appSettings = new AppSettings();

        public void Insert(Funcionario funcionario)
        {
            string query = "SP_InserirFuncionario";

            using (var connection = new SqlConnection(_appSettings.ConnectionString))
            {
                connection.Execute(query,funcionario, commandType:System.Data.CommandType.StoredProcedure);
            }
        }

        public Funcionario Retrieve(string nome)
        {
            string query = "SELECT * FROM FUNCIONARIO WHERE Nome = @Nome";
            var funcionario = new Funcionario();

            using (var connection = new SqlConnection(_appSettings.ConnectionString))
            {
                return connection.QueryFirstOrDefault<Funcionario>(query, new {Nome = nome});
            }
        }

        public IEnumerable<Funcionario> RetrieveAll()
        {
            string query = "SELECT * FROM FUNCIONARIO";
            using (var connection = new SqlConnection(_appSettings.ConnectionString))
            {
                return connection.Query<Funcionario>(query);
            }
        }

        public void Update(Funcionario funcionario)
        {
            string query = "SP_AlterarFuncionario";

            using (var connection = new SqlConnection(_appSettings.ConnectionString))
            {
                connection.Execute(query, funcionario, commandType: System.Data.CommandType.StoredProcedure);
            }

        }
        public void Delete(Guid id)
        {
            string query = "SP_ExcluirFuncionario";
            var parameters = new { Id = id };

            using (var connection = new SqlConnection(_appSettings.ConnectionString))
            {
                connection.Execute(query, parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
