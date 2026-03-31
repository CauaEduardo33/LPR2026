Console.Write("Insira um número natural : ");
string base_num_string = Console.ReadLine();

int num = Convert.ToInt32(base_num_string);

num*= num;

string pow_num_string =  Convert.ToString(num);

int soma = 0;

for(int i=0; i<pow_num_string.Length; ++i)
{
    char c= pow_num_string[i];

    soma+= int.Parse(c.ToString());


}

Console.WriteLine($"A soma dos algarismos do quadrado de {base_num_string}({pow_num_string}) é {soma}.");



