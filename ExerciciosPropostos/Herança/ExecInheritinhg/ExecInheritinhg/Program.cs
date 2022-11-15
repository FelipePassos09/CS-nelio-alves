using System;
using System.Collections.Generic;
using System.Globalization;
using ExecInheritinhg.Entities;

namespace ExecInheritinhg
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int nProducts = int.Parse(Console.ReadLine());

            List<Product> pList = new List<Product>();

            for (int i = 0; i < nProducts; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported ( c / u / i )? ");
                char pType = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Name: ");
                string pName = Console.ReadLine();
                Console.Write("Price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (pType)
                {
                    case 'I':
                        Console.Write("Customs Fee: ");
                        double pFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        pList.Add(new ImportedProduct(pName, pPrice, pFee));
                        break;
                    
                    case 'C':
                        pList.Add(new Product(pName, pPrice));
                        break;
                    
                    case 'U':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime pDate = DateTime.Parse(Console.ReadLine());
                        pList.Add(new UsedProduct(pName, pPrice, pDate));
                        break;
                }
            }
            
            foreach (var pItem in pList)
            {
                Console.WriteLine(pItem.PriceTag());
            }
        }
    }
}