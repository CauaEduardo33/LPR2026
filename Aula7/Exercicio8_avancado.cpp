#include <iostream>
#include <string>
#include <iomanip>

using namespace std;


int cinema[6][8];

string VerificarAssento(int l, int c){
    if(cinema[l-1][c-1]==0) return "Livre";
    else return "Ocupado";
}

void ReservarAssento(){
    int l,c;
    cout<<"Insira a linha e a coluna do assento desejado.\n";
   cin>>l>>c;

   string verificacao = VerificarAssento(l,c);
   if(verificacao == "Livre"){
    cinema[l-1][c-1] = 1;
    cout<<"Assento reservado com sucesso.\n";
   }
   else cout<<"Desculpe-nos, assento ja ocupado.\n";

}

void CancelarReserva(){
    int l,c;
    cout<<"Insira a linha e a coluna do assento.\n";
    cin>>l>>c;
    if(cinema[l-1][c-1]==1){
    cinema[l-1][c-1] = 0;
    cout<<"Reserva cancelada.\n";
    }
    else cout<<"O assento ja estava livre.";
}

void ConsultarAssento(){
    int l,c;
    string resposta;
    cout<<"Insira a linha e a coluna do assento a ser consultado.\n";
    cin>>l>>c;
    resposta = VerificarAssento(l,c);
    if(resposta=="Livre") cout<<"O assento esta livre.\n";
    else cout<<"O asssento esta ocupado.\n";
}

void MostrarMapaDaSala(){
    for(int i=0; i<6; i++){
        for(int j=0; j<8; j++){
            if(j==4)cout<<'\t';
            cout<<setw(2)<<setfill('0')<<1+i*8+j<<" ";
        }
        cout<<'\n';
    }
}

void menu(){
    while(true){
        cout<<"1 - Reservar assento\n2 - Cancelar Reserva\n3 - Consultar assento\n4 - Mostra mapa da sala\n5 - Encerrar\n";
        int escolha;
        cin>>escolha;
        switch(escolha){
            case 1:
            ReservarAssento();
            break;
            
            case 2:
            CancelarReserva();
            break;

            case 3:
            ConsultarAssento();
            break;

            case 4:
            MostrarMapaDaSala();
            break;

            case 5:
            return;
            
        }
    }
}

int main(){

    menu();
}