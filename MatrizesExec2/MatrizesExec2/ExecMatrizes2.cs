using System;
using System.Globalization;

class Matrizes2
{
    static void Main(string[] args)
    {
        /*Fazer um programa para ler dois números inteiros (M e N) e depois criar uma matriz de M linhas por N colunas
         contendo números inteiros. Em seguida ler um número inteiro X que pertence à matriz. 
         Para cada ocorrência de X mostrar os valores acima, à esquerda, à direita e abaixo de X, quando houver.*/

        Console.WriteLine("Bem vindo ao programa de Matrizes!!");
        Console.Write($"Primeiro vamos inserir quantas linhas iremos querer na nossa matriz: ");
        int qlines = int.Parse(Console.ReadLine());
        Console.Write("Agora vamos configurar a quantidade de colunas: ");
        int qcolumns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[qlines, qcolumns];

        
        for (int line = 0;  line < qlines; line++)
        {
            Console.WriteLine($"Insira os {qcolumns} valores da linha {line+1} separados por espaço: ");
            string[] values = Console.ReadLine().Split(' ');

            for (int column = 0; column < qcolumns; column++)
            {
                matrix[line, column] = int.Parse(values[column]);
            }
        }

        int opt = int.Parse(Console.ReadLine());

        for (int line = 0; line < qlines; line++)
        {
            for (int column = 0; column < qcolumns; column++)
            {
                if (matrix[line, column] == opt)
                {
                    if (column > 0)
                    {
                        Console.WriteLine($"Position: {line} , {column}.");    
                    }
                    
                {
                    
                }
            }
        }

    }
}