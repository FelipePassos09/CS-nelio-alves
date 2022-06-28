using System;
using System.Globalization;

namespace Course;
class Exercicio4
{
    public static void execicioQuatro(string[] args)
    {
        System.Console.WriteLine(" Entre com seu nome completo:");
        string nomeComp = Console.ReadLine();
        System.Console.WriteLine("Quantos quartos tem na sua casa:");
        int quantQuartos= int.Parse(Console.ReadLine());
        System.Console.WriteLine("Entre com o valor de um produto:");
        double precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.WriteLine("Entre seu último nome, idade, sexo e altura:");
        string[] cad = Console.ReadLine().Split(' ');

        string sobrenome = cad[0];
        int idade = int.Parse(cad[1]);
        char sexo = char.Parse(cad[2]);
        double altura = (double) double.Parse(cad[3], CultureInfo.InvariantCulture);

        System.Console.WriteLine($"Olá {nomeComp}!");
        System.Console.WriteLine($"Sua casa tem {quantQuartos} quartos.");
        System.Console.WriteLine($"O produto escolhido custa R$ {precoProd}.");
        System.Console.WriteLine($"Seu sobrenome é {sobrenome}.");
        System.Console.WriteLine($"Tem {idade} anos.");
        System.Console.WriteLine($"É do sexo {sexo}.");
        System.Console.WriteLine($"E mede {altura} de altura.");

        

    }
}