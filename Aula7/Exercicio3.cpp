#include <iostream>
#include <string>


using namespace std;


int matriz[4][4] = {
    {0,524,521, 882}, {524, 0, 434, 586}, {521, 434, 0, 429}, {882, 586, 429, 0} 
};

int obterDistancia(const string cidade1, const string cidade2){

    if(cidade1 == cidade2) return 0;

   if((cidade1 == "Vitoria" && cidade2== "BH") || (cidade1 == "BH" && cidade2 == "Vitoria")) return matriz[0][1];
   if((cidade1 == "Vitoria" && cidade2== "RJ") || (cidade1 == "RJ" && cidade2 == "Vitoria")) return matriz[0][2];
   if((cidade1 == "Vitoria" && cidade2 == "SP") || (cidade1 == "SP" && cidade2 == "Vitoria")) return matriz[0][3];
   if((cidade1 == "BH" && cidade2 == "RJ") || (cidade1 == "RJ" && cidade2 == "BH")) return matriz[1][2];
   if((cidade1 == "BH" && cidade2 == "SP") || (cidade1 == "SP" && cidade2 == "BH")) return matriz[1][3];
   if((cidade1 == "RJ" && cidade2 == "SP") || (cidade1 == "SP" && cidade2 == "RJ")) return matriz[2][3];
   return 0;
}
int main(){

    while(true){
        cout<<"Cidades disponiveis: Vitoria, BH, RJ e SP.(Deve-se escrever dessa forma).\n";
        cout<<"Insira a cidade de partida: ";
        string cidade1="";
        cin>>cidade1;
        cout<<"\nInsira a cidade de destino: ";
        string cidade2="";
        cin>>cidade2;

        int distancia = obterDistancia(cidade1, cidade2);
        if(distancia == 0) break;

        cout<< "\nA distancia entre "<<cidade1<<" e "<<cidade2<<" eh "<< distancia<<" km. \n";

    }

}
