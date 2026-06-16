using System.Globalization;

int[] inteiros = new int[10];

int quant_pares = 0;
int quant_impares = 0;

void printVector(int[] v)
{
    foreach(int num in v)
    {
        Console.Write($" {num}");
    }
}

for(int i=0; i<inteiros.Length; i++)
{
    Console.Write("Insira um número inteiro: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num % 2 == 0) quant_pares++;
    else quant_impares++;

    inteiros[i] = num;

}

int[] pares = new int[quant_pares];
int[] impares = new int[quant_impares];

int i_pares=0,i_impares=0;

for(int i=0; i<inteiros.Length; i++)
{
    if (inteiros[i] % 2 == 0)
    {
        pares[i_pares] = inteiros[i];
        i_pares++;
    }
    else
    {
        impares[i_impares];
        i_impares++;
    }
}

Console.Write("Pares: "); printVector(pares);

Console.Write("\nÍmpares: "); printVector(impares);


