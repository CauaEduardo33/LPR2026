using System.Drawing;
using System.Runtime.InteropServices;

Filme[] filmes = new Filme[3];

void ExibirFilmes(Filme[] filmes)
{
    Console.WriteLine("Filmes Cadastrados\n");

    foreach(Filme filme in filmes)
    {
        Console.WriteLine($"T´tulo: {filme.Titulo}");
        Console.WriteLine($"Diretor: {filme.Diretor}");
        Console.WriteLine($"Ano de lançameto: {filme.AnoLancamento}");
        Console.WriteLine($"Duração: {filme.DuracaoMinutos} minutos\n");

    }

    Console.WriteLine($"O filme mais antigo é '{FilmeMaisAntigo(filmes)}'.");
}

string FilmeMaisAntigo(Filme[] filmes)
{
    string filme_antigo = filmes[0].Titulo;
    int ano_filme_antigo = filmes[0].AnoLancamento;

    foreach(Filme filme in filmes)
    {
        if (filme.AnoLancamento < ano_filme_antigo)
        {
            filme_antigo = filme.Titulo;
            ano_filme_antigo = filme.AnoLancamento;
        }
    }

    return filme_antigo;
}

for(int i=0; i<filmes.Length; i++)
{
    Console.Write("Título: ");
    filmes[i].Titulo = Console.ReadLine();

    Console.Write("Diretor: ");
    filmes[i].Diretor = Console.ReadLine();

    Console.Write("Ano de lançamento: ");
    filmes[i].AnoLancamento = Convert.ToInt32(Console.ReadLine());

    Console.Write("Duração do filme em minutos: ");
    filmes[i].DuracaoMinutos = Convert.ToDouble(Console.ReadLine());

}


ExibirFilmes(filmes);
public struct Filme
{
    public string Titulo;
    public string Diretor;
    public int AnoLancamento;
    public double DuracaoMinutos;

};




