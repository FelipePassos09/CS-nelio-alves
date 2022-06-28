using System;

namespace Course;
class Exercicio2
{
    public static void ExercicioDois(string[] args)
    {
        double a = 1.0;
        double b = -3.0;
        double c = -4.0;

        double delta = Math.Pow(b,2.0) - (4.0*a*c);

        double resultPos = (-b + Math.Sqrt(delta))/(2.0*a);
        double resultNeg = (-b - Math.Sqrt(delta))/(2.0*a);

        System.Console.WriteLine(delta);
        System.Console.WriteLine(resultPos);
        System.Console.WriteLine(resultNeg);
    }
}