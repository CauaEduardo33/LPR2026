// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Runtime.InteropServices;

string[] nomes = new string[10];
float[] notas = new float[10];


void InputAlunos()
{
    for(int i =0; i<nomes.Length; i++)
    {
        Console.Write("Nome do aluno:");
        nomes[i] = Console.ReadLine();

        Console.Write("Nota do aluno: ");
        notas[i] = Console.ReadLine();
    }
    
}

string ClassificarAluno(float nota)
{
    if(nota<60) return "reprovado";
    else if(nota>=60 && nota<=79) return "recuperação";
    else return "aprovado";
}

void exibirRelatorio(){
    int aprovados =0, em_recuperacao=0, reprovados = 0;
    string classificacoes = new string[10];
    
    for (int i=0; i<nomes.Length; i++)
    {
        classificacoes[i] = ClassificarAluno(notas[i]);
        if(classificacoes[i] == "aprovado") aprovados++;
        else if(classificacoes[i] == "reprovado") reprovados++;
        else em_recuperacao++;
        Console.WriteLine($"{nomes[i]} = {notas[i]} - {classificacoes[i]}");
    }

}