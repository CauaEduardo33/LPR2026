using System.Collections;

double pont1=0, pont2=0, pont3=0, pont4=0, pont5=0;
string nome1="",nome2="",nome3="",nome4="",nome5="";
string poder1, poder2, poder3, poder4, poder5;



string searchNullHeroi()
{
    
    if(nome1 == "") return "heroi1";
    if(nome2 == "") return "heroi1";
    if(nome3 == "") return "heroi1";
    if(nome4 == "") return "heroi1";
    if(nome5 == "") return "heroi5";
    else return "noNULLHeroi";
   


}
void cadastrarHeroi(){
    string result_searchNullheroi = searchNullHeroi();


     if(result_searchNullheroi == "noNullHeroi")
    {
        Console.WriteLine("Número máximo de heróis já cadastrados.");
        return;
    }

    Console.Write("Insira o nome do heróiz\n> ");
    string nome_heroi = Console.ReadLine();

    while (String.IsNullOrWhiteSpace(nome_heroi))
    {
        Console.WriteLine("O nome do herói nâo pode ficar em branco.");
        Console.Write("Insira o nome do herói\n> ");
        nome_heroi = Console.ReadLine();
    } 
    
    Console.Write("Insira o poder do herói\n>");
    string poder_heroi = Console.ReadLine();
    while (String.IsNullOrWhiteSpace(poder_heroi))
    {
        Console.WriteLine("O poder do herói nâo pode ficar em branco.");
        Console.Write("Insira o poder do herói\n> ");
        poder_heroi = Console.ReadLine();
    } 
   
    double pont_heroi;

    Console.Write("insira a pontuação do herói\n>");
    while(!double.TryParse(Console.ReadLine(), out pont_heroi))
    {
        Console.Write("insira a pontuação do herói\n>");
    }

    if(result_searchNullheroi== "heroi1")
    {
        nome1 = nome_heroi;
        poder1 = poder_heroi;
        pont1 = pont_heroi;
    }
    else if(result_searchNullheroi== "heroi2")
    {
        nome2 = nome_heroi;
        poder2 = poder_heroi;
        pont2 = pont_heroi;
    }

    else if(result_searchNullheroi== "heroi3")
    {
        nome3 = nome_heroi;
        poder3 = poder_heroi;
        pont3 = pont_heroi;
    }

    else if(result_searchNullheroi== "heroi4")
    {
        nome4 = nome_heroi;
        poder4 = poder_heroi;
        pont4 = pont_heroi;
    }

    else
    {
        nome5 = nome_heroi;
        poder5 = poder_heroi;
        pont5 = pont_heroi;
    }

}

void exibirHeroisCadastrados()
{
     if(searchNullHeroi() == "heroi1")
    {
        Console.WriteLine("Não há heróis cadastrados.");
        return;
    }

    Console.WriteLine($"Heróis disponíveis:\n {nome1}- poder: {poder1}");
    if(searchNullHeroi()!="heroi2") Console.WriteLine($"{nome2}-")
}

void selecionarEquipe()



