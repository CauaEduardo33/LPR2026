// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public struct Classe_de_Personagem
{
    public string Tipo_Classe {get; set;}
    public string Descricao {get; set;}
   public Classe_de_Personagem(string tipo_classe, string descricao)
    {
      Tipo_Classe = tipo_classe;
      Descricao = descricao;
         
    }

};

class Program
{
    static void Main(){

        Classe_de_Personagem guerreira = new Classe_de_Personagem("Guerreira" , "Ataque Pesado, Defesa Total ");
        Classe_de_Personagem mago = new Classe_de_Personagem("Mago", "Bola de Fogo, Escudo de Gelo");
        Classe_de_Personagem arqueira = new Classe_de_Personagem("Arqueira", "Flecha Precisa, Disparo Triplo");

        bool sair = false;
        bool escolha_feita = false;
        while (!sair)
        {
                        if (escolha_feita)
            {
                 Console.WriteLine("Digite:\n1-Sair\n2-Reescolher");
                  int reescolha;
                  
                  if(!int.TryParse(Console.ReadLine(), out reescolha))
                            {
                                Console.WriteLine("você deve insierir o número referente a opção.");
                            }

                        switch (reescolha)
                        {
                            case 1:
                            sair = true;
                            break;

                            case 2:
                            break;
                            
                            default:
                            Console.WriteLine("Opção inválida");
                            continue;

                        }
            }


            Console.WriteLine("Insira o número correspondente a classe desejada(ou 4 para sair):\n1-Guerreira\n2-Mago\n3-Arqueira\n4-Sair");
            int option;
            while(!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Você deve inserir o número correspondente a escolha.");
                Console.WriteLine("Insira o número correspondente a classe desejada(ou 4 para sair):\n1-Guerreira\n2-Mago\n3-Arqueira\n4-Sair");

            }

            switch (option)
            {
                case 1:
                Console.WriteLine("Classe \t Habilidades\n");
                Console.WriteLine($"{guerreira.Tipo_Classe} \t {guerreira.Descricao}");

                escolha_feita = true;
                break;

                case 2:
                Console.WriteLine("Classe \t Habilidades\n");
                Console.WriteLine($"{mago.Tipo_Classe} \t {mago.Descricao}\n");

                escolha_feita = true;
                break;
              
                case 3:
                Console.WriteLine("Classe \t Habilidades\n");
                Console.WriteLine($"{arqueira.Tipo_Classe} \t {arqueira.Descricao}\n");

                escolha_feita = true;
                 break; 

                case 4:
                sair = true;
                break;

                default:
                Console.WriteLine("Opção inválida.");
                break;
       
                    }

            }

        }

}