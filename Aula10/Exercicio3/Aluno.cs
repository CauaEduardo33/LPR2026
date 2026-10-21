using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Numerics;

namespace Exercicio3;

public class Aluno
{
    public string matricula{get; private set;}
    public string nome{get; private set;}

    public double nota_prova1;

    public double nota_prova2;

    public double nota_trabalho;

    public Aluno(string matricula, string nome, double nota_prova1, double nota_prova2,double nota_trabalho)
    {
        this.matricula  = matricula;
        this.nome = nome;
        this.nota_prova1 = nota_prova1;
        this.nota_prova2 = nota_prova2;
        this.nota_trabalho = nota_trabalho;
    }

    public double media()
    {
        return (2.5*(nota_prova1+nota_prova2)+2*nota_trabalho)/7;
    }

    public double final()
    {
        double media = this.media();
        
        if(media>=60) return 0;

        return (9.5*60-2.5*(nota_prova1+nota_prova2)-2.0*nota_trabalho)/2.5;

    }
}
