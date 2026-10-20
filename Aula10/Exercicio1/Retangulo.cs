using System.Diagnostics.Contracts;
using System.Reflection;

namespace Exercicio1;

public class Retangulo
{
    public double Altura;
    public double Largura;

    public double calcArea()
    {
        return Altura*Largura;   
    }

    public double calcPerimetro()
    {
        return 2*(Altura+Largura);
    }

    public Retangulo(double Altura, double Largura)
    {
        this.Altura = Altura;
        this.Largura = Largura;
    }
  
}
