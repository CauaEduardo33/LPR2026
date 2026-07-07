using System.Collections.Generic;

Dictionary<string, double> pessoas = new Dictionary<string, double>()
        {
            { "Ana", 25.0 },
            { "Bruno", 32.0 },
            { "Carlos", 19.0 },
            { "Daniela", 41.0 },
            { "Eduardo", 28.0 },
            { "Fernanda", 35.0 },
            { "Gabriel", 22.0 },
            { "Helena", 30.0 },
            { "Igor", 27.0 },
            { "Juliana", 24.0 }
        };

double media = 0.0;

foreach(var pessoa in pessoas)
{
    media += pessoa.Value;
}

media /= pessoas.Count;

foreach(var pessoa in pessoas)
{
    if(pessoa.Value > media) Console.WriteLine($"{pessoa.Key} tem idade maior que a média.");

}

var maxPair = pessoas.MaxBy(kvp => kvp.Value);
Console.WriteLine($"\n\n{maxPair.Key} é a pessoa mais velha.");

var minPair =  pessoas.MinBy(kvp => kvp.Value);
Console.WriteLine($"\n\n{minPair.Key} é a pessoa mais nova.");

Console.WriteLine("\n\nInsira a idade proibida: ");
double idade_proibida = Convert.ToDouble(Console.ReadLine());

foreach(var pessoa in pessoas)
{
    if (pessoa.Value == idade_proibida)
    {
        pessoas.Remove(pessoa.Key);
    }
}

foreach (var pessoa in pessoas)
{
    Console.WriteLine(pessoa.Key);
}