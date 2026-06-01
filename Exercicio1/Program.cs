using System.Globalization;

int[] inteiros = new int[10];

int quant_pares = 0;
int quant_impares = 0;

void atributeToNullIndex(ref int[] v, int val)
{
    for(int i=0; i<v.Length; i++)
    {
        if(v[i] == 0) {
         v[i] = val;
         return;
        }

   }
}

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

 foreach(int num in inteiros)
{
    if(num % 2 == 0) atributeToNullIndex(ref pares, num);
    else atributeToNullIndex(ref impares, num);
}

Console.Write("Pares: "); printVector(pares);

Console.Write("\nÍmpares: "); printVector(impares);


