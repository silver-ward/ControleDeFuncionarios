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
        /// Método para cadastrar um funcionário no banco de dados
        /// </summary>
        public void Cadastrar()
        {

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
        /// Método para consultar funcionários no banco de dados
        /// </summary>
        public void ConsultarTodos()
        {
            
            var repository = new FuncionarioRepository();
            IEnumerable<Funcionario> funcionarios = repository.RetrieveAll();

            foreach(var funcionario in funcionarios)
            {
                Console.WriteLine();
                Console.WriteLine($"ID.........: {funcionario.Id}");
                Console.WriteLine($"Nome:......: {funcionario.Nome}");
                Console.WriteLine($"Matrícula..: {funcionario.Matricula}");
                Console.WriteLine($"CPF........: {funcionario.Cpf}");
            }

        }

        /// <summary>
        /// Método para consultar um funcionário por nome no banco de dados
        /// </summary>
        public void ConsultarPorNome()
        {
            string nome;
            do
            {
                Console.WriteLine("Escreva o nome completo do funcionário a ser consultado: ");
                nome = Console.ReadLine().Trim();
            } while (string.IsNullOrWhiteSpace(nome));

            var repository = new FuncionarioRepository();
            var funcionario = repository.Retrieve(nome);
            if (funcionario != null)
            {
                Console.WriteLine("Aqui estão os dados desse funcionário:");
                Console.WriteLine();
                Console.WriteLine($"ID.........: {funcionario.Id}");
                Console.WriteLine($"Nome:......: {funcionario.Nome}");
                Console.WriteLine($"Matrícula..: {funcionario.Matricula}");
                Console.WriteLine($"CPF........: {funcionario.Cpf}");
            }
            else
            {
                Console.WriteLine("Nenhum dado encontrado.");
            }

        }

        /// <summary>
        /// Método para alterar um funcionário no banco de dados
        /// </summary>
        public void Alterar()
        {
            var repository = new FuncionarioRepository();
            var funcionario = new Funcionario();

            Guid id;
            bool guidIsValid = false;
            do
            {
                Console.WriteLine("Informe o ID do funcionário que deseja alterar.");
                string input = Console.ReadLine().Trim();
                guidIsValid = Guid.TryParse(input, out id);
            } while (!guidIsValid);
            
            funcionario.Id = id;

            Console.WriteLine("Ok! Agora informe Nome, Matrícula e CPF desejados para esse funcionário.");
            Console.Write("Nome.......: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Matrícula..: ");
            funcionario.Matricula = Console.ReadLine();
            Console.Write("CPF........: ");
            funcionario.Cpf = Console.ReadLine();
            
            repository.Update(funcionario);
        }

        /// <summary>
        /// Método para excluir um funcionário no banco de dados
        /// </summary>
        public void Excluir()
        {
            var repository = new FuncionarioRepository();
            var funcionario = new Funcionario();

            Guid id;
            bool guidIsValid = false;
            do
            {
                Console.WriteLine("Informe o ID do funcionário que deseja DELETAR.");
                string input = Console.ReadLine().Trim();
                guidIsValid = Guid.TryParse(input, out id);
            } while (!guidIsValid);

            funcionario.Id = id;

            repository.Delete(funcionario.Id);
        }
    }
}
