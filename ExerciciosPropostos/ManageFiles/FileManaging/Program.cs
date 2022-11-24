using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using FileManaging.Entities;

namespace FileManaging
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            string inputPath;
            string outputPath = @"/out";
            string root = Path.GetTempPath();
            string inputFileName = "/vendas.csv";
            string outputFilename = "/summary.csv";
            List<Product> products = new List<Product>();

            inputPath = "/csharp-files";

            try
            {
                string[] lines = File.ReadAllLines(Path.Combine(root+inputPath+inputFileName));

                foreach (var line in lines)
                {
                    Product nProduct = new Product(
                        line.Split(',')[0],
                        double.Parse(line.Split(',')[1], CultureInfo.InvariantCulture),
                        int.Parse(line.Split(',')[2])
                    );
                    
                    products.Add(nProduct);

                    Console.WriteLine(nProduct.ToString());

                }

                Directory.CreateDirectory(Path.Combine(root + inputPath + outputPath));
                File.Delete(Path.Combine(root + inputPath + outputPath + outputFilename));

                using (var nStreamWriter =
                       File.AppendText(Path.Combine(root + inputPath + outputPath + outputFilename)))
                {
                    foreach (var product in products)
                    {
                        nStreamWriter.WriteLine(product.Name + ',' + product.TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}