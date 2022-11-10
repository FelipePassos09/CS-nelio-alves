namespace RascunhosDiversos;

public class Tern
{
    public static void Op(int option)
    {
        string resultado = (option >= 1) ? "Primeiro" : "Segundo";

        Console.WriteLine(resultado);
        
    }

    private static void Primeiro()
    {
        Console.WriteLine("Selected primeiro.");
        
    }

    private static void Segundo()
    {
        Console.WriteLine("Selected segundo");
    }
}