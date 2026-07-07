using System.Collections.Generic;

Dictionary <string,string> jogos = new Dictionary<string, string>();

for(int i=0; i<5; i++)
{
    Console.Write("Insira o nome do jogo: ");
    string jogo = Console.ReadLine() ?? "Não inserido";

    Console.Write("Insira o gênero do jogo: ");
    string genero = Console.ReadLine() ?? "Não inserido";

    jogos.Add(jogo, genero);
}

Console.Write("Insira o nome de um jogo: ");
string nome_jogo = Console.ReadLine() ?? "Nome não inserido";

if (jogos.ContainsKey(nome_jogo))
{
  Console.WriteLine($"O gênero do jogo é {jogos[nome_jogo]}.");
}
else
{
    Console.WriteLine("Jogo não encontrado.");
}