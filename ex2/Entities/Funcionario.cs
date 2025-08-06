using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Entities
{
    /// <summary>
    /// Classe da Entity Funcionário
    /// </summary>
    public class Funcionario
    {

        public required Guid Id { get; set; } = Guid.NewGuid();
        public required string Nome { get; set; }
        public required string Matricula { get; set; }
        public required string Cpf { get; set; }
    }
}
