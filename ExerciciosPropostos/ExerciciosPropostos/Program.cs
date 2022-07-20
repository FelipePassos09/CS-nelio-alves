using System;
using System.Globalization;
using ExerciciosPropostos;

namespace ExerciciosPropostos
{
    class Principal
    {
        static void Main(string[] args)
        {
            int option;
            Triangulo x, y;

            x = new Triangulo
            {
                A = 8.0,
                B = 5.0,
                C = 6.0
            };

            y = new Triangulo
            {
                A = 4.0,
                B = 5.0,
                C = 6.0
            };

            double areaX = x.Area();
            Console.WriteLine(areaX);
            
            double areaY = y.Area();
            Console.WriteLine(areaY);

            Exercicios1 novo;
            novo = new Exercicios1 { n1 = 2, n2 = 3};

            Console.WriteLine(novo.Exercicio01());

        }

        
    }
}
