// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Globalization;

int[] nums = new int[5];

int max = 0;
int max_pos = 0;
for(int i=0; i<nums.Length; i++)
{   
    Console.Write("Insira um número inteiro: ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
    if(i==0) max = nums[i];
    else if(nums[i]> max) {
        max = nums[i];
        max_pos = i;
    }
}

Console.Write("Vetor: ");
foreach(int num in nums)Console.Write($"{num} ");

Console.WriteLine($"\nMaior Valor: {max}");
Console.WriteLine($"Posição: {max_pos}");