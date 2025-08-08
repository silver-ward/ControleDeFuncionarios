using ex2.Controllers;

var funcionarioController = new FuncionarioController();

string option;
do
{
    Console.WriteLine("Bem-vindo ao sistema de Funcionários!");
    Console.WriteLine(@"
Digite a sua opção e pressione Enter:
[1] Cadastrar funcionário.
[2] Consultar Todos os funcionários.
[3] Consultar um funcionário.
[4] Alterar um funcionário.
[5] Excluir um funcionário.
[s] Sair.
");
    option = Console.ReadLine().ToLower().Trim();
    switch (option)
    {
        case "1":
            // CADASTRO DE FUNCIONÁRIOS
            funcionarioController.Cadastrar();
            break;
        case "2":
            funcionarioController.ConsultarTodos();
            Console.ReadKey();
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "s":
            Console.WriteLine("Saindo...");
            Console.WriteLine("Até mais!");
            break;
    }

} while (option != "s");