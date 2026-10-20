using System.Buffers;

namespace Exercicio2;




public class Funcionario
{

    const decimal Piso1= 2000.00M;
    const decimal Piso2= 3000.00M;
    public string nome{get; private set;}
    public decimal salario{get;set;}

    public Funcionario(string nome, decimal salarioBruto)
    {
        this.nome = nome;
        salario = calcSalarioLiquido(salarioBruto);
    }

    public void aumentarSalario(double porc)
    {
        salario = Convert.ToDecimal((100+porc)/100 * Convert.ToDouble(salario));
        
    }

    decimal calcSalarioLiquido(decimal bruto)
    {
        if(bruto<=Piso1) return bruto - 0.1M*bruto;
        if(bruto<=Piso2) return bruto - 0.15M*bruto;
        return bruto - 0.20M*bruto;
    }
}
