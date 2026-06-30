#include <list>
#include <iostream>
#include <string>

#define MAX_PILOTOS 10

using namespace std;

struct Piloto {
    string nome;
    string equipe;
    int pontuacao;
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
    for(int i=0; i<equipes.size(); i++){
        
        advance(it,1);
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

    if(pilotos.size()<MAX_PILOTOS){
        Piloto piloto;

        cout<<"Nome do piloto: ";
        getline(cin, piloto.nome);

        cout<<"Equipe: ";
        getline(cin, piloto.equipe);

        cout<<"Pontuacao: ";
        cin>>piloto.pontuacao;

        cin.ignore();


    }

}

int main(){

}