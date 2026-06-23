#include <iostream>
#include <string>
#include <vector>

#define MAX_NUM_HEROIS 5
using namespace std;



struct Heroi {
    string nome;
    string poder;
    int pontuacao;    
};


int num_herois = 0;

vector<Heroi> Herois;

void cadastrarHeroi(){

    cin.ignore();
    if(num_herois<MAX_NUM_HEROIS){
        Heroi heroi;

        cout<<"Nome: ";
        getline(cin, heroi.nome);

        cout<<"Poder: ";
        getline(cin, heroi.poder);

        cout<<"Pontuacao: ";
        cin>>heroi.pontuacao;

        Herois.push_back(heroi);

        cout<<"Heroi cadastrado.";

        num_herois++;
    }
    else cout<<"O maximo de herois ja foi atingido\n";

}

void exibirHerois(vector<Heroi> h){
    for(int i=0; i<h.size(); i++){
        cout<<i+1<<"- "<<h[i].nome<<'\n';
    }

}

void  selecionarEquipe(vector<Heroi> &equipe){
    if(Herois.size()<=3)  cout<<"Nao ha herois cadastrados o suficiente.";
    else{
        
        vector<Heroi> aux_herois = Herois;
    
        cout<<"Herois disponiveis \n";
        
        exibirHerois(aux_herois);

        for(int i=0; i<3; i++){
            cout<<"Insira o numero correspondente ao heroi desejado\n";
            if(i!=0) exibirHerois(aux_herois);

            while(true){
                int escolha;
                cin>>escolha;
                
                if(escolha>=1 && escolha<=aux_herois.size()){
                    equipe.push_back(aux_herois[i]);
                    aux_herois.erase(aux_herois.begin()+i);
                    break;
                }
            }
         
        }
    }
}

int CalcularPontuacaoTotal(vector<Heroi> equipe){
    int pontuacao_total = 0;

    for(Heroi heroi : equipe){
        pontuacao_total += heroi.pontuacao;
    }

    return pontuacao_total;
}

void exibirEquipe(vector<Heroi> equipe){
    cout<<"Equipe\n\n";
    for(Heroi heroi : equipe){
        cout<<"Heroi: "<<heroi.nome<<"\nPoder: "<<heroi.poder<<"\n\n";
    }
}

void Menu(){
    vector<Heroi> Equipe;
    while(true){
    
      cout<<"Insira o numero correspondente a acao desejada\n\n"<<"1-Cadastrar heroi\n"
      <<"2-Selecionar equipe\n"<<"3-Exibir equipe\n"<<"4-Sair do programa\n";

      int escolha;
      cin>>escolha;

      switch (escolha)
      {
        case 1:
            cadastrarHeroi();
            break;
        
        case 2:
            selecionarEquipe(Equipe);
            break;
        
        case 3:
            exibirEquipe(Equipe);
            break;

        case 4:
            return;

    
      
        default:
            break;
      }
    }
}





int main(){

    Menu();
}

