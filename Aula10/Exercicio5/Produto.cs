using System.Diagnostics;

namespace Exercicio5;

public class Produto
{

    public string nome;
    public double preco;

    public Produto(string nome, double preco)
    {
        
        this.nome = nome;
        
        if(preco<0) throw new ArgumentException("O preço mínimo é zero.");
        
        this.preco = preco;

    }
}
