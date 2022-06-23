using System;
using System.Globalization;

namespace Course;
class NewBaseType
{
    private static void exercicio1(string[] args)
    {
        //double saldo = 10.35784;

        // Console.WriteLine(saldo);
        // Console.WriteLine(saldo.ToString("F2"));
        // Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

        string produto1 = "Computador";
        string produto2 = "Mesa de Escritório";

        byte idade = 30;
        int codigo = 53268;
        char sexo = 'M';

        double preco1 = 210.50;
        double preco2 = 560.00;
        double medidas = 56.569835412;

        System.Console.WriteLine("Produtos:");
        Console.WriteLine($"O produto {produto1} tem o preço de: R${preco1}.");
        Console.WriteLine($"O produto {produto2} tem o preço de: R${preco2}.");
        System.Console.WriteLine($"--------------------------");
        System.Console.WriteLine($"O cliente código {codigo} tem {idade} anos e é do sexo {sexo}.");
        System.Console.WriteLine($"--------------------------");
        System.Console.WriteLine($"A medida da {produto2} é: {medidas}.");
        System.Console.WriteLine($"A medida da {produto2} com três casas decimais é: {medidas:F3}");
        System.Console.WriteLine($"A medida da {produto2} com três casas e formatado é: {medidas.ToString("F3", CultureInfo.InvariantCulture)}");



    }
}