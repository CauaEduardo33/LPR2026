using Exercicio1;


Console.Write("Insira a altura do retângulo: ");
double alt = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira a largura do retângulo:");
double larg = Convert.ToDouble(Console.ReadLine());

Retangulo retangulo = new Retangulo(alt,larg);

Console.WriteLine($"A área do retangulo é {retangulo.calcArea()}");
Console.WriteLine($"O perímetro do retangulo é {retangulo.calcPerimetro()}");



