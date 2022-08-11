using System.Globalization;

namespace ExerciciosPropostos;

public class Vectors
{
    public void vetor()
    {
        int n = int.Parse(Console.ReadLine());

        double[] vet = new double[n];

        for (int i = 0; i < n; i++)
        {
            vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double tot = 0.0;
        for (int i = 0; i < n; i++)
        {
            tot += vet[i];
        }
        
        Console.WriteLine($"A média é {tot / vet.Length}");
        
        
    }


}