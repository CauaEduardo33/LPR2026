using System.Collections.Generic;

List<double> notas = new List<double>();


for(int i = 0; i<5; i++)
{
    Console.Write("Nota do aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());

    notas.Add(nota);
}

double soma = 0.0;

foreach(double nota in notas)
{
    soma += nota;

    Console.WriteLine(nota);

}

Console.WriteLine("Media das notas: " + soma/Convert.ToDouble(notas.Count));
Console.WriteLine("Maior nota: " + notas.Max());
Console.WriteLine("Menor nota: " + notas.Min());
