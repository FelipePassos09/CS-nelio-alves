using System;
using System.Globalization;


namespace ExercicioBanco;
class Program
{
    static void Main()
    {
        char control;
        do
        {
            Console.WriteLine("Bem vindo ao Banco Bolado!!!\nAqui você pode abrir a sua conta.\n\n");
            Console.Write("Primeiro insira o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.Write($"Agora {nome}, escolha um número para sua conta: ");
            string conta = Console.ReadLine();
            Console.Write($"{nome} Gostaria de realizar um depósito? (s / n) ");
            char choice = char.Parse(Console.ReadLine());

            Cliente a;

            if (choice == 's' || choice == 'S')
            {
                Console.Write("Quanto vai depositar: ");
                double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                a = new Cliente(name: nome, conta:conta, saldo: deposito);
            }
            else
            {
                a = new Cliente(name: nome, conta:conta);
            }

            Console.WriteLine(a);

            Console.Write("Realize um depósito: ");
            a.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(a);

            Console.Write("Realize um saque: ");
            a.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(a);
            
            Console.Write("Quer continuar? (s / n) ");
            control = char.Parse(Console.ReadLine());
        } while (control == 's' || control == 'S');
    }
}