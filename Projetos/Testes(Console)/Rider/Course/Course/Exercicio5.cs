using System;

namespace Course;
class Exercicio5
{
    public static void Exe5 (string[] args)
    {
        var cond1 = "Sim";
        var cond2 = "Não";

        do {
            System.Console.WriteLine("Digite o nome de uma pessoa:");
            string nomePessoa = Console.ReadLine();

            if (nomePessoa == null)
            {
                System.Console.WriteLine("Precisa digitar\nDigite o nome de uma pessoa:");
            nomePessoa = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"O nome da pessoa é: {nomePessoa}");
                break;
            }
 
        } while (true);

    }
}