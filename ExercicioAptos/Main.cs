using System.Globalization;
#pragma warning disable CS8600
#pragma warning disable CS8604

namespace ExercicioAptos;

public class main
{
    static void Main()
    {
        Console.WriteLine("Programa de acompanhamento de quartos");
        Apartamento[] list = new Apartamento[3];

        Console.WriteLine("Vamos começar com os cadastros:");
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write($"Insira o nome do {i+1}º inquilino: ");
            string inq = Console.ReadLine();
            Console.Write("Insira, agora, o e-mail do inquilino: ");
            string email = Console.ReadLine();
            Console.Write("Agora insira o número do apartamento: ");
            int apto = int.Parse(Console.ReadLine());
            Console.Write("Por fim, insira o valor a pagar de aluguel: ");
            double alg = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n");
                
            list[apto-1] = new Apartamento(inq, email, apto, alg);
        }

        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine("\n");
            Console.WriteLine(list[i]);
        }

        Console.WriteLine($"O valor total, mensal, recebido será: {list[0].TotalCash(list).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}