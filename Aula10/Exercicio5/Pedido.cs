namespace Exercicio5;

public class Pedido
{
    public Produto Produto;

   public int Quantidade=1;


    public Pedido(Produto produto, int quantidade)
    {
        Produto = produto;

        if(quantidade<=0) throw new ArgumentException("A quantidade mínima é 1");
        
        Quantidade = quantidade;
    }

    public Pedido(Produto produto)
    {
        Produto = produto;
    }

    public double precoTotal()
    {
        return Produto.preco*Quantidade;
    }

}
