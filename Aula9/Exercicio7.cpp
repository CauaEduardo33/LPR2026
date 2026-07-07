#include <iostream>
#include <map>

using namespace std;

int main(){
      map<string, int> cidades =
    {
        {"Sao Paulo", 12325232},
        {"Rio de Janeiro", 6748000},
        {"Belo Horizonte", 2315560},
        {"Brasília", 2817381},
        {"Curitiba", 1773733},
        {"Salvador", 2417678},
        {"Fortaleza", 2428678},
        {"Manaus", 2063547},
        {"Recife", 1488920},
        {"Porto Alegre", 1332570}
    };

    int media =0;
    for(auto cidade : cidades){
        media += cidade.second;
    }

    media /= cidades.size();

    for(auto cidade : cidades){
        if(cidade.second > media){
            cout<<cidade.first<<" tem populacao acima da media."<<endl;
        }
    }

    int Max_cidade = INT_MIN;
    string Max_cidade_nome ="";
    for(auto cidade : cidades){
        if(cidade.second>Max_cidade){
            Max_cidade_nome = cidade.first;
            Max_cidade - cidade.second;
        }
    }

    cout<<Max_cidade_nome<<" eh a cidade mais populosa."<<endl;


    int Min_cidade = INT_MAX;
    string Min_cidade_nome ="";
    for(auto cidade : cidades){
        if(cidade.second<Min_cidade){
            Min_cidade_nome = cidade.first;
            Min_cidade = cidade.second;
        }
    }

    cout<<Min_cidade_nome<<" eh a cidade menos populosa."<<endl;

    int populacao_proibida;
    cout<<"\nInsira o numero de habitantes proibido: ";
    cin>>populacao_proibida;

    for(auto cidade : cidades){
        if(cidade.second == populacao_proibida){
            cidades.erase(cidade.first);
        }
    }

    for(auto cidade : cidades){
        cout<<cidade.first<<endl;
    }

}