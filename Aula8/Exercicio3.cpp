#include <iostream>
#include <string>
#include <vector>


using namespace std;

struct Livro
{
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco;    
};


double CalcularPrecoTotal(vector<Livro> livros){
    double soma =0;

    for(Livro livro : livros){
        soma += livro.Preco;
    }

    return soma;
}

double CalcularMediaPaginas(vector<Livro> livros){
    
    double somaPaginas =0;
    for(Livro livro : livros){
        somaPaginas += livro.NumeroPaginas;
    }

    return somaPaginas/(livros.size());
}




int main(){

vector<Livro> livros(3);

for(int i=0; i<livros.size(); i++){
    cout<<"\nTitulo: ";
    getline(cin, livros[i].Titulo);
    cout<<"\nAutor: ";
    getline(cin, livros[i].Autor);
    cout<<"\nAno de publicacao: ";
    cin>>livros[i].AnoPublicacao;
    cout<<"\nNumero de paginas: ";
    cin>>livros[i].NumeroPaginas;
    cout<<"\nPreco: ";
    cin>>livros[i].Preco;

    cin.ignore();
}


double precoTotal = CalcularPrecoTotal(livros);

cout<<"O preco total eh R$ "<<precoTotal<<".\n";

cout<<"A media de paginas por livro eh "<<CalcularMediaPaginas(livros)<<'.'<<endl;


}