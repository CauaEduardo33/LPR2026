using System.Diagnostics.Tracing;

namespace Exercicio6;

public class Reserva
{

    public Cliente Cliente;

    public string Dia;

    public Reserva(Cliente cliente, string dia)
    {
        Cliente = cliente;
        Dia = dia;
    }

}
