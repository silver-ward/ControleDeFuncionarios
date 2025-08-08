using ex2.Entities;
using ex2.Repositories;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Controllers
{
    /// <summary>
    /// Classe de controle das operações de Funcionário
    /// </summary>
    public class FuncionarioController
    {
        /// <summary>
        /// Método para cadastrar Funcionário no banco de dados
        /// </summary>
        public void Cadastrar()
        {
            Console.WriteLine("CADASTRO DE FUNCIONÁRIOS");
            Console.WriteLine("Por favor, informe os seguintes dados do funcionário a ser cadastrado:");

            var funcionario = new Funcionario();
            var validationResults = new List<ValidationResult>();

            do
            {
                Console.Write("Nome Completo: ");
                funcionario.Nome = Console.ReadLine();
                
                validationResults.Clear();
                Validator.TryValidateProperty(funcionario.Nome,
                    new ValidationContext(funcionario)
                    {
                        MemberName=nameof(Funcionario.Nome)
                    },
                    validationResults
                    );

                if (validationResults.Count > 0)
                {
                    Console.WriteLine(validationResults[0].ErrorMessage);
                }

            } while (validationResults.Count > 0);

            do
            {
                Console.Write("Matrícula: ");
                funcionario.Matricula = Console.ReadLine();

                validationResults.Clear();
                Validator.TryValidateProperty(funcionario.Matricula,
                    new ValidationContext(funcionario)
                    {
                        MemberName=nameof(Funcionario.Matricula)
                    },
                    validationResults
                    );

                if(validationResults.Count > 0)
                {
                    Console.WriteLine(validationResults[0].ErrorMessage);
                }

            } while (validationResults.Count > 0);

            do
            {
                Console.Write("CPF: ");
                funcionario.Cpf = Console.ReadLine();

                validationResults.Clear();
                Validator.TryValidateProperty(funcionario.Cpf,
                    new ValidationContext(funcionario)
                    {
                        MemberName = nameof(Funcionario.Cpf)
                    },
                    validationResults
                    );

                if (validationResults.Count > 0)
                {
                    Console.WriteLine(validationResults[0].ErrorMessage);
                }

            } while (validationResults.Count > 0);

            var repository = new FuncionarioRepository();
            repository.Insert(funcionario);

        }

        /// <summary>
        /// Método para consultar Funcionários no banco de dados
        /// </summary>
        public void ConsultarTodos()
        {
            Console.WriteLine("CONSULTA DE FUNCIONÁRIOS");
            Console.WriteLine("Aqui está a lista de funcionários disponível no banco de dados:");
            
            var repository = new FuncionarioRepository();
            IEnumerable<Funcionario> funcionarios = repository.RetrieveAll();

            foreach(var funcionario in funcionarios)
            {
                Console.WriteLine();
                Console.WriteLine($"Nome:......: {funcionario.Nome}");
                Console.WriteLine($"Matrícula..: {funcionario.Matricula}");
                Console.WriteLine($"CPF........: {funcionario.Cpf}");
            }

        }

        /// <summary>
        /// Método para consultar Funcionário por nome no banco de dados
        /// </summary>
        public void ConsultarPorNome()
        {

        }

        /// <summary>
        /// Método para alterar Funcionário no banco de dados
        /// </summary>
        public void Alterar()
        {

        }

        /// <summary>
        /// Método para excluir Funcionário no banco de dados
        /// </summary>
        public void Excluir()
        {

        }
    }
}
