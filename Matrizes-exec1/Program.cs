using System;
using System.Globalization;

namespace exec1
{
    class ExercicioMatrizes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tamanho da matriz:");
            int tam = int.Parse(Console.ReadLine());

            int[,] mat = new int[tam, tam];

            for (int line=0; line < tam; line++)
            {
                Console.Write($"Insira os valores da linha {line + 1} separados por espaço: ");
                string[] values = Console.ReadLine().Split(' ');
                
                for (int column = 0; column < tam; column++)
                {
                    mat[line, column] = int.Parse(values[column]);
                }
            }

            Console.WriteLine(mat[1,1]);
        }
    }
}