using System;
using System.Globalization;
using ExerciciosPropostos;

namespace ExerciciosPropostos
{
    class Principal
    {
        static void Main(string[] args)
        {
            /*int option;
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
            Console.WriteLine($"Agora que removemos {qte} temos {p.Quantity} {p.Name}");*/

            /*a = new Produto("TV", 1200.00, 1);
            Console.WriteLine(a);*/

            /*a = new Produto()
            {
                Name = "Geladeira",
                Price = 273.00,
                Quant = 2
            };
            Console.WriteLine(a);
            int quant = 2;
            a.AddProducts(quant);
            Console.WriteLine(a);

            b = new Produto()
            {
                Name = "Fogão",
                Price = 1200.00,
                Quant = 1
            };
            Console.WriteLine(b);
            quant = 3;
            b.AddProducts(quant);
            Console.WriteLine(b);*/

            /*Console.WriteLine("Informe o nome do produto:");
            string prod = Console.ReadLine();
            Console.WriteLine("Informe o preço a pagar: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos produtos busca comprar? ");
            int qtd = int.Parse(Console.ReadLine());

            Produto a = new Produto(prod, price, qtd);
            Console.WriteLine(a);

            Produto b = new Produto(prod, price);
            Console.WriteLine(b);

            Console.WriteLine(b.Name);
            Console.WriteLine("Insira um novo nome para o produto: ");
            b.Name = Console.ReadLine();
            Console.WriteLine(b.Name);*/

            int n = int.Parse(Console.ReadLine());
            Product[] vet = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                vet[i] = new Product { Name = name, Price = price};
            }

            double tot = 0.00;

            for (int i = 0; i < n; i++)
            {
                tot += vet[i].Price;
            }

            double avg = tot / vet.Length;
            Console.WriteLine($"A média de preços é {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
