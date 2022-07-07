using System;

namespace Course
{
    class Exercicio6
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Digite tr~es números: ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine()); 

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine($"O maior é: {resultado}");

        }

        static int Maior(int a, int b, int c){
            int m;
            if(a > b && a > c){
                m = a;
            }
            else if(b > a && b > c){
                    m = b;
                }
            else{
                m = c;
            }
            return m;
        }
    }
}