#include <iostream>
#include <string>

using namespace std;

int reverse(int num){
  int reverse=0;
 while(num!=0){
   reverse=reverse*10+num%10;
   num=num/10;
 }
 return reverse;
}

int main(){
  int num;
  cout<<"Digite um número inteiro: ";
  cin>>num;
  cout<<"O número invertido é: "<<reverse(num)<<endl;

}