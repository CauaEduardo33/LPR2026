#include <iostream>

using namespace std;

int main(){
  int a,b;
  
  cout<<"Insira dois numeros inteiros: ";
  cin>>a>>b;

  if(a % b == 0  || b % a == 0){
    cout<<"\nSao Multiplos."<<endl;
  }

  else{
    cout<<"\nNao sao multiplos."<<endl;
  }
  
}