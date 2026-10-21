using System.Runtime.ConstrainedExecution;
using Exercicio2;

Console.Write("Insira o nome do funcionário: ");
string nome = Console.ReadLine();

Console.Write("Insira o sálario bruto do funcionário: ");
decimal bruto = Convert.ToDecimal(Console.ReadLine());

Funcionario funcionario = new Funcionario(nome, bruto);

Console.WriteLine($"Nome: {funcionario.nome}\nSalário Líquido: {funcionario.salario}");

funcionario.aumentarSalario(20);

Console.WriteLine($"Quando for promovido para sênior, o funcionário ganhará {funcionario.salario}");