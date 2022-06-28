namespace Course.ProposalExercises;

public class Exec1
{
    public static void Soma(string[] args)
    {

        char continua = 'S';

        do
        {
            Console.WriteLine("Insira o primeiro número da soma:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número da soma");
            int num2 = int.Parse((Console.ReadLine()));

            Console.WriteLine($"O total da soma é: {num1 + num2}.");

            Console.WriteLine("Quer continuar? \n S=SIM\n N=NÃO");
            continua = char.Parse(Console.ReadLine());

        } while (continua != 'N');

    }
}