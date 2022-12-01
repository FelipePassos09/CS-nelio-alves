using System;
using System.Collections.Generic;
using ExecHashSortedSet.Entities;

namespace ExecHashSortedSet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*HashSet<string> words = new HashSet<string>();

            words.Add("Felipe");
            words.Add("Joao");
            words.Add("Marianna");

            Console.WriteLine(words.Contains("Jose"));

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }*/

            /*SortedSet<int> numbers = new SortedSet<int>() {12, 32, 5, 16, 0, 9, 56};
            SortedSet<int> numbers2 = new SortedSet<int>() { 5, 12, 54, 9, 0, 14 };
            
            numbers.ExceptWith(numbers2);

            PrintCollection(numbers);*/

            HashSet<Product> products = new HashSet<Product>();
            products.Add(new Product("TV", 2500.00));
            products.Add(new Product("Notebook", 4000.00));

            Product prod = new Product() { Name = "Notebook", Price = 4000.00 };
            Console.WriteLine(products.Contains(prod));

            HashSet<Point> pointers = new HashSet<Point>();
            pointers.Add(new Point(10, 25));
            pointers.Add(new Point(5, 9));

            Point point = new Point(10, 25);
            
            //PrintCollection(pointers);

            Console.WriteLine(pointers.Contains(point));

        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.WriteLine(obj + " ");
            }

            Console.WriteLine();
        }

    }
}