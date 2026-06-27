using System.Collections.Generic;

List<string> nomes = new List<string>();

int num_nomes = Convert.ToInt32(Console.ReadLine());


for(int i=0; i<num_nomes; i++)
{
    string nome = Console.ReadLine() ?? "Nome Padrao";
    nomes.Add(nome);
}


string name_toprint = nomes[0];

for(int i=1; i<num_nomes; i++)
{
    if(name_toprint.Length>nomes[i].Length){
    name_toprint = nomes[i];
    }
}

PrintName();

while(nomes.Count != 0)
{

    FindNameToPrint();
    PrintName();
   
    
            
}

void FindNameToPrint()
{
    int lgth_last_ptd_name = name_toprint.Length; 
    bool found_valid_number = false;

    for(int i=0; i<nomes.Count; i++)
    {
       
        if(nomes[i].Length > lgth_last_ptd_name)
        {
            if(!found_valid_number){
                found_valid_number = true;
                name_toprint = nomes[i];
                
            }
            else if(nomes[i].Length<name_toprint.Length) name_toprint = nomes[i];
            
        }

        
    }

    if (!found_valid_number)
    {
        Console.WriteLine();
        name_toprint = "";
        FindNameToPrint();
    }


}

void PrintName()
{
    Console.Write($"{name_toprint}\t");
    nomes.Remove(name_toprint);
}
