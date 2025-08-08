using ex2.Controllers;

var funcionarioController = new FuncionarioController();

string option;
do
{
    Console.WriteLine("Bem-vindo ao sistema de Funcionários!");
    Console.WriteLine(@"
Digite a sua opção e pressione Enter:
[1] Cadastrar funcionário.
[2] Consultar todos os funcionários.
[3] Consultar um funcionário.
[4] Alterar um funcionário.
[5] Excluir um funcionário.
[s] Sair.
");
    option = Console.ReadLine().ToLower().Trim();
    switch (option)
    {
        case "1":
            Console.WriteLine("CADASTRO DE FUNCIONÁRIOS");
            Console.WriteLine("Por favor, informe os seguintes dados do funcionário a ser cadastrado:");
            funcionarioController.Cadastrar();
            Console.WriteLine();
            Console.WriteLine("Cadastro efetuado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("CONSULTA DE FUNCIONÁRIOS");
            Console.WriteLine("Aqui está a lista de funcionários disponível no banco de dados:");
            funcionarioController.ConsultarTodos();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("CONSULTA DE UM FUNCIONÁRIO");
            funcionarioController.ConsultarPorNome();

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
            Console.ReadKey();
            break;
        case "4":

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
            Console.ReadKey();
            break;
        case "5":

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
            Console.ReadKey();
            break;
        case "s":

            Console.WriteLine();
            Console.WriteLine("Saindo...");
            Console.WriteLine("Até mais!");
            break;
    }

} while (option != "s");