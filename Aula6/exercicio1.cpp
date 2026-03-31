#include <iostream>
#include <string>

using namespace std;

int reverse_num(int num){

  string str_num = to_string(num);

  string str_reversed_num(str_num.rbegin(), str_num.rend());

  return stoi(str_reversed_num);
}

int main(){
    int user_num;
    
    cout<<"Insira um numero inteiro: ";
    cin>>user_num;

    cout<<"O reverso de "<< user_num<<" eh "<<reverse_num(user_num)<<endl;


}