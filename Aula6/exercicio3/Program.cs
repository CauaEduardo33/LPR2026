using System.Collections;
using System.Reflection;



string searchNullHeroi(string nome1, string nome2, string nome3, string nome4, string nome5)
{
    
    if(nome1 == "") return "heroi1";
    if(nome2 == "") return "heroi2";
    if(nome3 == "") return "heroi3";
    if(nome4 == "") return "heroi4";
    if(nome5 == "") return "heroi5";
    else return "noNULLHeroi";
   


}
void cadastrarHeroi(ref double pont1, ref double pont2, ref double pont3, ref double pont4, ref double pont5, ref string nome1, ref string nome2, ref string nome3, ref string nome4, ref string nome5, ref string poder1, ref string poder2, ref string poder3, ref string poder4, ref string poder5){
    string result_searchNullheroi = searchNullHeroi(nome1, nome2, nome3, nome4, nome5);


     if(result_searchNullheroi == "noNullHeroi")
    {
        Console.WriteLine("Número máximo de heróis já cadastrados.");
        return;
    }

    Console.Write("Insira o nome do herói\n> ");
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

void exibirHeroisCadastrados(string nome1, string nome2, string nome3, string nome4, string nome5, string poder1, string poder2, string poder3, string poder4, string poder5)
{
    string searchNullHeroi_result = searchNullHeroi(nome1, nome2, nome3, nome4, nome5);
     if(searchNullHeroi_result== "heroi1")
    {
        Console.WriteLine("Não há heróis cadastrados.");
        return;
    }

    Console.WriteLine($"Heróis disponíveis:\n{nome1}- poder: {poder1}\n");
    
    if(searchNullHeroi_result!="heroi2") Console.WriteLine($"{nome2}- poder: {poder2}\n");
    if(searchNullHeroi_result!="heroi3") Console.WriteLine($"{nome3}- poder: {poder3}\n");
    if(searchNullHeroi_result!="heroi4") Console.WriteLine($"{nome4}- poder: {poder4}\n");
    if(searchNullHeroi_result!="heroi5") Console.WriteLine($"{nome5}- poder: {poder5}\n");

}

bool validarHeroiEscolhido( string heroi_escolhido, string nome1, string nome2, string nome3, string nome4, string nome5)
{ 
 
   string searchNullHeroi_result = searchNullHeroi(nome1, nome2, nome3, nome4, nome5);
   if(searchNullHeroi_result == "heroi1" && heroi_escolhido == nome1) return false;
   else if(searchNullHeroi_result == "heroi2" && heroi_escolhido == nome2) return false;
   else if(searchNullHeroi_result == "heroi3" && heroi_escolhido == nome3) return false;
   else if(searchNullHeroi_result == "heroi4" && heroi_escolhido == nome4) return false;
   else if(searchNullHeroi_result == "heroi5" && heroi_escolhido == nome5) return false;
   else return true;
}

void atribuirHeroiEscolhido( string heroi_escolhido, ref double pont_heroi_escolhido, ref string poder_heroi_escolhido, string nome1, string nome2, string nome3, string nome4, string nome5,
 double pont1, double pont2, double pont3, double pont4, double pont5,
 string poder1, string poder2, string poder3, string poder4, string poder5
)
{
    if(heroi_escolhido == nome1)
    {
        pont_heroi_escolhido = pont1;
        poder_heroi_escolhido = poder1;
    }
    else if(heroi_escolhido == nome2)
    {
        pont_heroi_escolhido = pont2;
        poder_heroi_escolhido = poder2;
    }

    else if(heroi_escolhido == nome3)
    {
        pont_heroi_escolhido = pont3;
        poder_heroi_escolhido = poder3;
    }

    else if(heroi_escolhido == nome4)
    {
        pont_heroi_escolhido = pont4;
        poder_heroi_escolhido = poder4;
    }

    else
    {
        pont_heroi_escolhido = pont5;
        poder_heroi_escolhido = poder5;
    }
}

void selecionarEquipe(string nome1, string nome2, string nome3, string nome4, string nome5,
 string poder1, string poder2, string poder3, string poder4, string poder5,
 double pont1, double pont2, double pont3, double pont4, double pont5
, ref string heroi_escolhido1, ref string heroi_escolhido2, ref string heroi_escolhido3,
 ref double pont_heroi_escolhido1, ref double pont_heroi_escolhido2, ref double pont_heroi_escolhido3, 
 ref string poder_heroi_escolhido1, ref string poder_heroi_escolhido2, ref string poder_heroi_escolhido3
)
{
   string result_searchNullHeroi = searchNullHeroi(nome1, nome2, nome3, nome4, nome5);
    if(result_searchNullHeroi == "heroi1" || result_searchNullHeroi == "heroi2" || result_searchNullHeroi == "heroi3")
    {
        Console.WriteLine("É necessário cadastrar pelo menos 3 heróis para formar uma equipe.");
        return;
    }
   exibirHeroisCadastrados(nome1, nome2, nome3, nome4, nome5, poder1, poder2, poder3, poder4, poder5);
   Console.WriteLine("Selecione 3 heróis para formar sua equipe.");
    Console.Write("Digite o nome do herói 1\n> ");
    heroi_escolhido1 = Console.ReadLine();
    Console.Write("Digite o nome do herói 2\n> ");
    heroi_escolhido2 = Console.ReadLine();
    Console.Write("Digite o nome do herói 3\n> ");
    heroi_escolhido3 = Console.ReadLine();
    while(!(validarHeroiEscolhido( heroi_escolhido1, nome1, nome2, nome3, nome4, nome5) && validarHeroiEscolhido(heroi_escolhido2, nome1, nome2, nome3, nome4, nome5) && validarHeroiEscolhido(heroi_escolhido3, nome1, nome2, nome3, nome4, nome5) && (heroi_escolhido1 != heroi_escolhido2) && (heroi_escolhido1 != heroi_escolhido3) && (heroi_escolhido2 != heroi_escolhido3)))
    {
        Console.WriteLine("Os heróis escolhidos devem ser os disponíveis e devem ser diferentes entre si.");
        Console.Write("Digite o nome do herói 1\n> ");
        heroi_escolhido1 = Console.ReadLine();
        Console.Write("Digite o nome do herói 2\n> ");
        heroi_escolhido2 = Console.ReadLine();
        Console.Write("Digite o nome do herói 3\n> ");
        heroi_escolhido3 = Console.ReadLine();
    }

    atribuirHeroiEscolhido( heroi_escolhido1, ref pont_heroi_escolhido1, ref poder_heroi_escolhido1, nome1, nome2, nome3, nome4, nome5, pont1, pont2, pont3, pont4, pont5, poder1, poder2, poder3, poder4, poder5);
    atribuirHeroiEscolhido( heroi_escolhido2, ref pont_heroi_escolhido2, ref poder_heroi_escolhido2, nome1, nome2, nome3, nome4, nome5, pont1, pont2, pont3, pont4, pont5, poder1, poder2, poder3, poder4, poder5);
    atribuirHeroiEscolhido( heroi_escolhido3, ref pont_heroi_escolhido3, ref poder_heroi_escolhido3, nome1, nome2, nome3, nome4, nome5, pont1, pont2, pont3, pont4, pont5, poder1, poder2, poder3, poder4,
    poder5);

}

void calcularPontuacaoTotal(double pont_heroi_escolhido1, double pont_heroi_escolhido2, double pont_heroi_escolhido3, ref double pontuacao_total)
{
    pontuacao_total = pont_heroi_escolhido1 + pont_heroi_escolhido2 + pont_heroi_escolhido3;
    
}

void ExibirEquipe(double pontuacao_total, string heroi_escolhido1, string heroi_escolhido2, string heroi_escolhido3, string poder_heroi_escolhido1, string poder_heroi_escolhido2, string poder_heroi_escolhido3)
{
    if(heroi_escolhido1 == "")
    {
        Console.WriteLine("Nenhuma equipe selecionada.");
        return;
    }
    Console.WriteLine($"Equipe:");
    Console.WriteLine($"{heroi_escolhido1} - poder: {poder_heroi_escolhido1}");
    Console.WriteLine($"{heroi_escolhido2} - poder: {poder_heroi_escolhido2}");
    Console.WriteLine($"{heroi_escolhido3} - poder: {poder_heroi_escolhido3}");
    Console.WriteLine($"Pontuação total da equipe: {pontuacao_total}");
}

void MenuPrincipal()
{
double pont1=0, pont2=0, pont3=0, pont4=0, pont5=0;
string nome1="",nome2="",nome3="",nome4="",nome5="";
string poder1="", poder2="", poder3="", poder4="", poder5="";

string heroi_escolhido1="", heroi_escolhido2="", heroi_escolhido3="";
double pont_heroi_escolhido1=0.0, pont_heroi_escolhido2=0.0, pont_heroi_escolhido3=0.0;
string  poder_heroi_escolhido1="", poder_heroi_escolhido2="", poder_heroi_escolhido3="";
double pontuacao_total=0.0;

    Console.WriteLine("Digite:\n1 - Cadastrar herói\n2 - Selecionar equipe\n3 - Exibir equipe\n4 - Sair");
    char opcao = Console.ReadLine()[0];

    while(opcao != '4')
    {
        switch(opcao)
        {
            case '1':
                cadastrarHeroi(ref pont1, ref pont2, ref pont3, ref pont4, ref pont5, ref nome1, ref nome2, ref nome3, ref nome4, ref nome5, ref poder1, ref poder2, ref poder3, ref poder4, ref poder5);
                break;
            case '2':
                selecionarEquipe(nome1, nome2, nome3, nome4, nome5, poder1, poder2, poder3, poder4, poder5, pont1, pont2, pont3, pont4, pont5, ref heroi_escolhido1, ref heroi_escolhido2, ref heroi_escolhido3, ref pont_heroi_escolhido1, ref pont_heroi_escolhido2, ref pont_heroi_escolhido3, ref poder_heroi_escolhido1, ref poder_heroi_escolhido2, ref poder_heroi_escolhido3);
                calcularPontuacaoTotal(pont_heroi_escolhido1, pont_heroi_escolhido2, pont_heroi_escolhido3, ref pontuacao_total);
                break;
            case '3':
                ExibirEquipe(pontuacao_total, heroi_escolhido1, heroi_escolhido2, heroi_escolhido3, poder_heroi_escolhido1, poder_heroi_escolhido2, poder_heroi_escolhido3);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
        Console.WriteLine("Digite:\n1 - Cadastrar herói\n2 - Selecionar equipe\n3 - Exibir equipe\n4 - Sair");
        opcao = Console.ReadLine()[0];
    }
}

MenuPrincipal();