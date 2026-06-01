int[] inteiros = new int[10];



// Pega 10 números inseridos pelo usuário
for(int i=0; i<inteiros.Length; i++)
{
    Console.Write("Insira um número inteiro: ");
    int num = Convert.ToInt32(Console.ReadLine());
    inteiros[i] = num;

}

// Variável para saída do loop 
bool exit = false;

while (!exit)
{
    Console.WriteLine("Qual número gostaria de pesquisar? ");
    int req_num = Convert.ToInt32(Console.ReadLine());
    int vezes_num = 0;
    
    for(int i=0; i<inteiros.Length; i++)
    {
        
        if(inteiros[i] == req_num)
        {
            Console.WriteLine($"O número foi encontrado na posição {i}.");
            vezes_num++;
        }
    }

    if(vezes_num>0)Console.WriteLine($"O número foi encontrado {vezes_num} vezes.");
    else Console.WriteLine("O número não foi encontrado.");

    Console.WriteLine("Digite 'e' para sair ou qualquer outra tecla para procurar outro número.");
    string ans = Console.ReadLine();

    if(ans == "e") exit = true;
}
