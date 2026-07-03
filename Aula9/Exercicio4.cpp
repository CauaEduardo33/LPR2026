#include <list>
#include <iostream>
#include <string>

#define MAX_PILOTOS 10

using namespace std;

struct Piloto {
    string nome;
    string equipe;
    int pontuacao;

    bool operator<(const Piloto& outro) const {
        return pontuacao < outro.pontuacao;
    }
};

struct Equipe {
    string nome;
    int pontuacao=0;
};



list<Piloto> pilotos;
list<Equipe> equipes;

void AtualizarEquipes(Piloto piloto){

    bool equipe_encontrada = false;
    auto it = equipes.begin();
    for(int i=0; i<int(equipes.size()); i++){
        
        if(i>0)advance(it,1);
        if(piloto.equipe == (*it).nome){
            (*it).pontuacao += piloto.pontuacao;
            equipe_encontrada = true;
        }
    }

    if(!equipe_encontrada){
        Equipe nova_equipe ={piloto.equipe, piloto.pontuacao};
        equipes.push_back(nova_equipe);
    }
}
void cadastrarPiloto(){

    if(int(pilotos.size())<MAX_PILOTOS){
        Piloto piloto;

        cin.ignore(); 
        
        cout<<"Nome do piloto: ";
        getline(cin, piloto.nome);


        cout<<"Equipe: ";
        getline(cin, piloto.equipe);

        

        cout<<"Pontuacao: ";
        cin>>piloto.pontuacao;

        

        pilotos.push_back(piloto);
        AtualizarEquipes(piloto);


    }
    else cout<<"O numero maximo de pilotos foi cadastrado."<<endl;


}

float calcularPontuacaoMedia(){
    float soma = 0.0;
    for(Piloto piloto : pilotos){
        soma+= piloto.pontuacao;
    }
    
    return soma/float(pilotos.size());
}

void exibirRanking(){

    pilotos.sort();
    pilotos.reverse();

    auto it = pilotos.begin();
    for(int i=0; i<int(pilotos.size()); i++){
        if(i>0)advance(it,1);
        cout<<i+1<<!"- "<<(*it).nome<<"  "<<(*it).pontuacao<<endl;
    }

}

void exibirMelhorEquipe(){

    auto it = equipes.begin();

    Equipe melhor_equipe = {(*it).nome, (*it).pontuacao};

    for(Equipe equipe : equipes){
        if(equipe.pontuacao>melhor_equipe.pontuacao){
            melhor_equipe = equipe;
        }

    }

    cout<<"Melhor Equipe: "<<melhor_equipe.nome<<endl;

}


void menu(){
    
    while(true){

        int escolha;
        cout<<"1-Cadastrar piloto\n2-Exibir ranking\n3-Exibir melhor Equipe\n4-Visualizar pontuacao media\n5-Sair"<<endl;
        cin>>escolha;

        switch (escolha)
        {
        case 1:
            
        cadastrarPiloto();
            break;
        
        case 2:{
            if(int(pilotos.size())==0){
                cout<<"Nao ha pilotos cadastrados."<<endl;
            }
            else exibirRanking();
            break;    
        }
        
        
        case 3:{

            if(int(pilotos.size())==0){
                cout<<"Nao ha pilotos cadastrados."<<endl;
            }
            else exibirMelhorEquipe();

            break;
        }

        case 4:{
            if(int(pilotos.size())==0){
                cout<<"Nao ha pilotos cadastrados."<<endl;
            }
            else{
                cout<<"Pontuacao media: "<<calcularPontuacaoMedia()<<endl;
            }

            break;
        }

        case 5:
        return;

            
        default:
            break;
        }

        

    }
    
}
int main(){
    
    menu();

}