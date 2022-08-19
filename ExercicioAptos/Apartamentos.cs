using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ExercicioAptos;

public class Apartamento
{
    private string Inquilino { set; get; }
    private string Email { set; get; }
    private int Apto { set; get; }
    private double Aluguel { set; get; }

    public Apartamento(string name, string email, int apto, double price)
    {
        Inquilino = name;
        Email = email;
        Apto = apto;
        Aluguel = price;
    }

    public static double TotalCash(Apartamento[] vetor)
    {
        double total = 0.00;
        for (int i = 0; i < vetor.Length; i++)
        {
            total += vetor[i].Aluguel;
        }

        return total;
    }
    
    public override string ToString()
    {
        return $"Nome: {Inquilino}\nE-mail: {Email}\nApartamento: {Apto}\nAluguel: {Aluguel.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}