// See https://aka.ms/new-console-template for more information
Console.Write("Insira um número: ");
int num1;
while(!int.TryParse(Console.ReadLine(), out num1))
{
  Console.WriteLine("insira número inteiro: "); 
}

if(num1 % 2 == 0)
{
    Console.WriteLine("O número é par.");
}

else
{
    Console.WriteLine("O número é ímpar");
}

