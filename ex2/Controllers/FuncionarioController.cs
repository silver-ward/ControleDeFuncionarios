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

            Funcionario funcionario = new Funcionario();

            do
            {
                Console.Write("Nome Completo: ");
                funcionario.Nome = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(funcionario.Nome));

            do
            {
                Console.Write("Matrícula: ");
                funcionario.Matricula = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(funcionario.Matricula));

            do
            {
                Console.Write("CPF: ");
                funcionario.Cpf = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(funcionario.Cpf));

            var repository = new FuncionarioRepository();
            repository.Insert(funcionario);


        }

        /// <summary>
        /// Método para consultar Funcionários no banco de dados
        /// </summary>
        public void ConsultarTodos()
        {

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
