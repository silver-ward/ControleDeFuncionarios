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
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MinLength(10, ErrorMessage = "Informe um nome com pelo menos {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe um nome com no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "O número de matrícula deve conter exatamente 6 dígitos.")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF deve conter 11 números, separados por pontos e vírgulas.")]
        public string Cpf { get; set; }
    }
}
