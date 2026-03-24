#include <iostream>
#include <locale>
#include <vector>

using namespace std;

double media(vector<int>& nums){
 double soma=0;
    for(int num :nums){
        soma += num;
    }
    return soma/nums.size();
}


int main(){
   setlocale(LC_ALL, "pt_BR.UTF-8");
   vector<int> user_nums;
   int qtd;

   cout<<"Insira a quantidade de números que serão digitados\n>";
   cin>>qtd;
   
   cout<<"Insira os números(devem ser números pares)\n>";

   int i=0;
   while(i<qtd){
    int n;
    cin>>n;
    if(n%2==0){
        user_nums.push_back(n);
    }
    ++i;
   }

   cout<<"A média dos números é "<<media(user_nums)<<'.';


}