Produto[] produtos = new Produto[3];

Decimal CalcularPrecoTotal(Produto produto)
{
    return produto.Preco*produto.Quantidade;
}

void ExibirValorTotal(Produto[] produtos)
{
    foreach(Produto produto in produtos)
    {
        Console.WriteLine($"O valor total de {produto.Nome} é R${CalcularPrecoTotal(produto)}");
    }
    
}

for (int i=0; i<produtos.Length; i++)
{

    Console.WriteLine($"Produto {i+1}\n");

    Console.Write("Nome: ");
    produtos[i].Nome = Console.ReadLine();

    Console.Write("Codigo: ");
    produtos[i].Codigo = Console.ReadLine();

    Console.Write("Preco: ");
    produtos[i].Preco = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Quantidade: ");
    produtos[i].Quantidade = Convert.ToInt32(Console.ReadLine());
    
}

ExibirValorTotal(produtos);



public struct Produto
{
  public string Nome;
  public string Codigo;
  public decimal Preco;
  public int Quantidade;

};