class calc
{
    
    static public void Main(string[] args){

        System.Console.WriteLine("Aplicativo de cálculos simples:\nSelecione abaixo uma opção: ");
        System.Console.WriteLine("1 - Soma\n2 - Divisão\n3 - Subtração\n4 - Multiplicação\n5 - Resto ad divisão\n6 - Raiz Quadrada\n7 - Potencia\n0 - Sair");
        int menu = System.Console.Read();

        while (true){
            if (menu == '1')
            {
                System.Console.WriteLine("Informe o primeiro número:");
                float num1 = Console.Read();
                System.Console.WriteLine("Informe o segundo número:");
                float num2 = Console.Read();
                float result = num1 + num2;

                System.Console.WriteLine("O resultado de %d + %d é %d", num1, num2, result);
            }

            if (menu == '0')
            {
                System.Console.WriteLine("Passou!");
                break;
            }
        };

    }
}