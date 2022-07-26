using System;
using System.Globalization;
using ExerciciosPropostos;

namespace ExerciciosPropostos
{
    class Principal
    {
        static void Main(string[] args)
        {
            int option;
            Triangulo x, y;

            x = new Triangulo
            {
                A = 8.0,
                B = 5.0,
                C = 6.0
            };

            y = new Triangulo
            {
                A = 4.0,
                B = 5.0,
                C = 6.0
            };

            double areaX = x.Area();
            Console.WriteLine(areaX);
            
            double areaY = y.Area();
            Console.WriteLine(areaY);

            Exercicios1 novo;
            novo = new Exercicios1 { n1 = 2, n2 = 3};

            Console.WriteLine(novo.Exercicio01());

            Console.WriteLine("=-=-=-=-=-=-=-=\n=- NOVO EXERCÍCIO -=\n=-=-=-=-=-=-=-= ");

            Produto p = new Produto();
            
            System.Console.WriteLine("Insira o nome do produto:");
            p.Name = System.Console.ReadLine();
            System.Console.WriteLine("Qual a descrição do produto? ");
            p.Description = System.Console.ReadLine();
            System.Console.WriteLine("Qual o preço do produto? ");
            p.Price = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Quantas unidades do produto precisa?");
            p.Quantity = int.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine(p);

            System.Console.WriteLine("Insira a quantidade de produtos que deseja incluir:");
            int qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.adProducts(qte);
            Console.WriteLine($"Agora que adicionamos {qte} itens, temos {p.Quantity} {p.Name}");

            Console.WriteLine("Agora precisamos remover alguns itens:");
            qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.rmvProducts(qte);
            Console.WriteLine($"Agora que removemos {qte} temos {p.Quantity} {p.Name}");

        }

        
    }
}
