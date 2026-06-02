#include <iostream>

using namespace std;
void preencherMatriz_3x3(int matriz[3][3]){

    for (int i=0; i<3; i++){
        for (int j=0; j<3; j++){
            cout<<"("<<i+1<<", "<<j+1<<"): ";
            int num;
            cin>>num;
            matriz[i][j] = num;
            cout<<'\n';
        }
    }
}

void ProdutoMatrizes(int A[3][3], int B[3][3], int C[3][3]){

    for(int i=0; i<3; i++ ){

        for(int j=0; j<3; j++){
            C[i][j] = A[i][0]*B[0][j] + A[i][1]*B[1][j] + A[i][2]*B[2][j];
        }
    }

}

void displayMatriz3x3(int matriz[3][3]){
    cout<<"[ ";

    for(int i=0; i<3; i++){

        cout<<" { ";
        for(int j=0; j<3; j++){
         
            cout<<matriz[i][j];
            if(j!=2) cout<<", ";
        }

        cout<<" }";
        if(i!=2) cout<<", ";

    }

    cout<<" ]\n";
}

int main(){
    int A[3][3], B[3][3], C[3][3];
    
    cout<<"Preencha a matriz A:\n";
    preencherMatriz_3x3(A);

    cout<<"\nPreencha a matriz B:\n ";
    preencherMatriz_3x3(B);

    ProdutoMatrizes(A, B, C);

    cout<<"Produto A*B:\n ";

    displayMatriz3x3(C);
    

}
