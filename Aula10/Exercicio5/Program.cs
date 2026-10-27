using Exercicio5;


Produto lenovoGM2 = new Produto("Lenovo GM2 Pro", 60.00);
Pedido pedido = new Pedido(lenovoGM2, 2);

Console.WriteLine($"Preço total do pedido: R${pedido.precoTotal().ToString("F2")}");
