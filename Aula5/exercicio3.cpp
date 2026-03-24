#include <iostream>
#include <locale>

using namespace std;

int main(){
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int soma=0;
  for(int i= 51; i<500; ++i){
    if( i % 3 ==0  && i % 2 !=0){
        soma += i;
    }
  }
  
  cout<<"Soma números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 a 500:\n "<< soma;
}
