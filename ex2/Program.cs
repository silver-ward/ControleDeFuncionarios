using ex2.Controllers;

var funcionarioController = new FuncionarioController();

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
string option = Console.ReadLine().ToLower().Trim();
switch (option)
{
    case "1":
        // CADASTRO DE FUNCIONÁRIOS
        funcionarioController.Cadastrar();
        break;
}

