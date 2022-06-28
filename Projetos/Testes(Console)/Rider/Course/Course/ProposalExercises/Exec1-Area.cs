using System.Globalization;
using System;

namespace Course.ProposalExercises;

public class Exec1_Area
{
    public static void Area(string[] args)
    {
        // ReSharper disable all SuggestVarOrType_BuiltInTypes
        char continua = 'S';
        double pi = 3.14159;
        
        do
        {
            Console.WriteLine("Insira o raio do círculo a ser cálculado:");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            Console.WriteLine($"A área do círculo em questão é: {(pi * Math.Pow(num1, 2)):F4}.");

            Console.WriteLine("Quer continuar? \n S=SIM\n N=NÃO");
            continua = char.Parse(Console.ReadLine());

        } while ((continua == 'S') | (continua == 's'));
    }
}