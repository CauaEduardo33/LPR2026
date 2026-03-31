#include <iostream>
#include <vector>

using namespace std;

double media_pares(vector<int>& nums){

int soma=0;

  for(int i=0; i<nums.size(); ++i){
   soma+= nums[i];
  }

  return static_cast<double>(soma)/nums.size();

    
}

int soma_50_500(){
    int sum = 0;
    for(int i= 51; i<500; ++i){
    if( i % 3 ==0  && i % 2 !=0){
        sum += i;
    }
  }
  return sum;
}

int soma_algs(int num){
       int quadrado = num * num;
    int somaDigitos = 0;

    // Usando um loop while para iterar sobre os dígitos do quadrado do número
    while (quadrado > 0) {
        somaDigitos += quadrado % 10; // Adicionando o último dígito à soma
        quadrado /= 10; // Removendo o último dígito
    }

    return somaDigitos;
}


int main(){
    bool sair = false;

    while(!sair){
        int option;
        cout<<"Digite: \n 1-Para calcular a media dos numeros pares de um conjunto dado. \n 2- Para calcular a soma dos numeros impares multiplos de 3 de 50 a 500\n 3-Para calcular a soma dos algarismos do quadrado do numero que voce inserir\n 4-Sair\n" ;
        cin>>option;
        switch(option){
            case 1:{
              int quantidade;
              vector<int>user_nums;
              cout<<"Insira quantos numeros serao digitados:  ";
              cin>>quantidade;

              for(int i=0; i<quantidade; ++i){
                int num;
                cout<<"Insira um numero: ";
                cin>>num;
                if(num % 2 ==0) user_nums.push_back(num);
               
              }
             double result_media = media_pares(user_nums);

             if(result_media==0){
                cout << "Nenhum numero par foi digitado.\n";
             }

             else{
                cout << "A media dos numeros pares eh " << result_media << '\n';
             }

            break;
            }

            case 2:{
                 cout<<"Soma numeros impares multiplos de 3 que se encontrem no conjunto dos numeros de 50 a 500:\n "<< soma_50_500()<<'\n';
               
                 break;   
                }
            
            case 3:{
                int num;
                cout<<"Insira um numero inteiro: ";
                cin>>num;
                cout << "A soma dos digitos do quadrado de " << num << " eh: " << soma_algs(num)<<'\n';
                
                break;
            }

            case 4:
            sair = true;
            break;

            default:
            cout<<option<<" nao eh uma opcao valida\n";

        }

    }
}