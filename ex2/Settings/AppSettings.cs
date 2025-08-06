using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Settings
{
    /// <summary>
    /// Classe para retornar configurações globais do projeto
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// ConnectionString do banco de dados Funcionário
        /// </summary>
        public string ConnectionString { get; }
            = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBFuncionario;Integrated Security=True";
    }
}
