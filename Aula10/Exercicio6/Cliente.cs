using System.Globalization;

namespace Exercicio6;

public class Cliente
{

    public string nome;
    
    public List<Reserva> Reservas = new List<Reserva>();

    public Cliente(string nome)
    {
        this.nome = nome;
    }

    public Cliente(string nome, List<Reserva> reservas)
    {
        this.nome = nome;
        Reservas.AddRange(reservas);
    }

    public void listReservas()
    {
        int it = 1;
        foreach(Reserva r in Reservas)
        {
            Console.WriteLine($"Reserva {it}: {r.Dia}");
            it++;
        }
    }

    public void addReserva(Reserva reserva)
    {
        Reservas.Add(reserva);
    }


}
