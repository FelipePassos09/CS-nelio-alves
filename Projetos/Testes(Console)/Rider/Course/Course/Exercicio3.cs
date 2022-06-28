using System;

namespace Course;
class Exercicio3
{
    public static void ExercicioTres(string[] args)
    {
        string frase, x, y, z, a, b, c;

        System.Console.WriteLine("Insira uma frase:");
        frase = Console.ReadLine();
        System.Console.WriteLine("Insira uma cor:");
        x = Console.ReadLine();
        System.Console.WriteLine("Insira outra cor:");
        y = Console.ReadLine();
        System.Console.WriteLine("Insira outra cor:");
        z = Console.ReadLine();
        System.Console.WriteLine("Insira uma fruta:");
        a = Console.ReadLine();
        System.Console.WriteLine("Insira outra fruta:");
        b = Console.ReadLine();
        System.Console.WriteLine("Insira mais uma fruta:");
        c = Console.ReadLine();

        System.Console.WriteLine($"Olá, {frase}");
        System.Console.WriteLine($"Quer dizer que você gosta das frutas {a}, {b}, {c}");
        System.Console.WriteLine($"E suas cores favoritas são: {x} { y} e { z}");

        
        string[] fraseNew = Console.ReadLine().Split(',');

        System.Console.WriteLine(fraseNew[0]);
        System.Console.WriteLine(fraseNew[1]);
        System.Console.WriteLine(fraseNew[2]);

    }
}