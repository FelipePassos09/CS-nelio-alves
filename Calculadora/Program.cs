﻿using System.Globalization;

namespace Calculadora
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insira seu nome:");
            var nome = Console.ReadLine();
            int option = 00;
            double n1, n2;
            int exp;

            while (option != 99)
            {
                Console.WriteLine($"Olá, {nome}.\n\nBem vindo ao app Calculadora");
                Console.WriteLine("Para usar a calculadora entre com a opção desejada:" +
                    "\n1 = Soma" +
                    "\n2 = Subtração" +
                    "\n3 = Multiplicação" +
                    "\n4 = Divisão" +
                    "\n5 = Potenciação" +
                    "\n6 = Raiz" +
                    "\n7 = Resto da divisão" +
                    "\n8 = Fatorial" +
                    "\nOu digite 99 para sair.");

                option = int.Parse(s: Console.ReadLine());


                if (option == 99)
                {
                    break;
                }
                else
                {
                    if (option == 1)
                    {
                        Console.Write("Informe o primeiro número:   ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Informe o segundo número:   ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.WriteLine($"A soma entre {n1} e {n2} é: {Soma(n1, n2)}.\n\n");
                    }
                    else if (option == 2) 
                    {
                        Console.Write("Informe o primeiro número:   ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Informe o segundo número:   ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.WriteLine($"A diferença entre {n1} e {n2} é: {Subtracao(n1, n2)}.\n\n");
                    }
                    else if (option == 3)
                    {
                        Console.Write("Informe o primeiro número:   ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Informe o segundo número:   ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.WriteLine($"O produto entre {n1} e {n2} é: {Multi(n1, n2)}.\n\n");
                    }
                    else if (option == 4)
                    {
                        Console.Write("Informe o primeiro número:   ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Informe o segundo número:   ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.WriteLine($"O coeficiente entre {n1} e {n2} é: {Div(n1, n2)}.\n\n");
                    }
                    else if (option == 5)
                    {
                        Console.Write("Informe o primeiro número:   ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("ATENÇÃO!!!\nEste número precisa ser inteiro!");
                        Console.Write("Informe o expoente:   ");
                        exp = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.WriteLine($"{n1} elevado à {exp}: {Pot(n1, exp)}");
                    }
                    else if (option == 6)
                    {
                        Console.Write("Informe o primeiro número:   ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("ATENÇÃO!!!\nEste número precisa ser inteiro!");
                        Console.Write("Informe o expoente:   ");
                        exp = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.WriteLine($"A raiz {exp} de {n1}: {Raiz(n1, exp)}");
                    }
                    else if (option == 7)
                    {
                        Console.Write("Informe o primeiro número:   ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Informe o segundo número:   ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.WriteLine($"O o resto da divisão é: {Resto(n1, n2)}");
                    }                   
                    else if (option == 8)
                    {
                        Console.Write("Informe o número:   ");
                        exp = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.WriteLine($"O fatorial de {exp} é {Fat(exp)}");
                    }
                }
            }
        }
        private static double Soma(double n1, double n2)
        {
            return n1 + n2;
        }

        private static double Subtracao(double n1, double n2)
        {
            return n1 - n2;
        }

        private static double Multi(double n1, double n2)
        {
            return n1 * n2;
        }

        private static double Div(double n1, double n2)
        {
            return n1 / n2;
        }

        private static int Resto(double n1, double n2)
        {
            return (int) (n1 % n2);
        }
        private static double Pot(double n1, int n2)
        {
            int count = 1;
            double result = 1;

            while (count <= n2)
            {
                result *= n1;
                count++;
            }

            return result;
        }
        private static double Raiz(double n1, int n2)
        {
            double radicando = 1 / n2;
            return Math.Pow(n1, radicando);
        }
        private static double Fat(int n1)
        {
            int n2 = n1;

            for (int i = 1; i < n2; i++)
            {
                n1 *= i;
            }
            return n1;
        }
    }
}