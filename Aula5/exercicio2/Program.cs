// See https://aka.ms/new-console-template for more information

Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);
int num;
int tentativas=0;
do
{
    Console.Write("Chute um valor\n>");
     num = Convert.ToInt32(Console.ReadLine());

    if (num < valorInteiro)
    {
        Console.WriteLine("Chutou baixo.");
    }

   else if (num > valorInteiro)
    {
        Console.WriteLine("Chutou alto.");
    }
    else
    {
        Console.WriteLine("Acertou!");
    }

    ++tentativas;
} while(num != valorInteiro);

Console.WriteLine($"Número de tentativas: {tentativas}");


