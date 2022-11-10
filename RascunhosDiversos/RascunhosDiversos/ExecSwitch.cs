namespace RascunhosDiversos;

public class ExecSwitch
{
    public static void SCase(int valor)
    {
        switch (valor)
        {
            case 1:
                Console.WriteLine("Segunda");
                break;
            case 2:
                Console.WriteLine("Terça");
                break;
            case 4:
                Console.WriteLine("Quarta");
                break;
            case 5:
                Console.WriteLine("Quinta");
                break;
            case 6:
                Console.WriteLine("Sexta");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            case 8:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Valor inválido!");
                break;
        } 
    } 
}