using System.Collections.Generic;

List<int> num_list = new List<int>{84, 70, 71, 67, 62, 81, 47, 88, 96, 69, 50, 39, 1, 79, 22, 9, 12, 13, 66, 45, 55, 64, 33, 4, 59, 43, 25, 68, 27, 8, 34, 24, 6, 75, 73, 83, 76, 58, 26, 18, 48, 94, 28, 72, 80, 11, 30, 5, 61, 32, 95, 41, 49, 29, 93, 16, 77, 60, 87, 37, 98, 67, 53, 91, 57, 89, 2, 10, 100, 51, 86, 90, 82, 19, 3, 35, 42, 99, 20, 36, 7, 31, 85, 54, 14, 17, 38, 92, 44, 21, 23, 40, 65, 97, 52, 63, 56, 78, 46, 15};
List<int []> nums_repetidos= new List<int []>();
for(int i=0; i<num_list.Count; i++)
{
    for(int j=0; j<num_list.Count-i-1; j++)
    {
        if (num_list[j] > num_list[j + 1])
        {
            int aux = num_list[j+1];
            num_list[j+1] = num_list[j];
            num_list[j] = aux;
        }
    }
}


for(int i=0; i<num_list.Count; i++)
{
    Console.Write($"{num_list[i]} ");
    if(num_list[i]%2==0) num_list.Remove(num_list[i]);
}

Console.WriteLine("\n\n");
int num_atual = num_list[0];
int qnt_repeticoes = 1;
for(int i=1; i<num_list.Count; i++)
{  
    Console.Write($"{num_list[i]} ");
    if(num_list[i]== num_atual) qnt_repeticoes++;
    else
    {
        if(qnt_repeticoes>1)nums_repetidos.Add([num_atual, qnt_repeticoes]);
        num_atual = num_list[i];
        qnt_repeticoes =1;
            
    }
    
}

Console.WriteLine("\n\n");

if (nums_repetidos.Count == 0)
{
    Console.WriteLine("Não há números repetidos");

}
else
{
    foreach(int[] v_repetido in nums_repetidos)
    {
        Console.WriteLine($"O número {v_repetido[0]} repetiu {v_repetido[1]} vezes.");
    }
}