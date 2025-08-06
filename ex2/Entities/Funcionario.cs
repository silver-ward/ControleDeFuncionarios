using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Algo deu errado ao atribuir o número de identificação do funcionário.\nPor favor, tente novamente ou contate o suporte.")]
        public required Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MinLength(3, ErrorMessage = "Informe um nome com pelo menos {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Informe um nome com no máximo {1} caracteres.")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MinLength(5, ErrorMessage = "Informe uma matrícula com pelo menos {1} caracteres.")]
        [MaxLength(10, ErrorMessage = "Informe uma matrícula com no máximo {1} caracteres.")]
        public required string Matricula { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$")]
        public required string Cpf { get; set; }
    }
}
