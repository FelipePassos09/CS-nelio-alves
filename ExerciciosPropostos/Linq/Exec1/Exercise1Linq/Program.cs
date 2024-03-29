﻿using System;
using System.Collections.Generic;
using System.Linq;
using Exercise1Linq.Entities;

namespace Exercise1Linq
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Category c1 = new Category()
            {
                Id = 1,
                Name = "Tools",
                Tier = 2
            };
            Category c2 = new Category()
            {
                Id = 2,
                Name = "Computers",
                Tier = 1
            };
            Category c3 = new Category()
            {
                Id = 3,
                Name = "Electronics",
                Tier = 1
            };

            List<Product> Products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };
            
            var result = Products.Where(p => p.Price < 900.00 && p.Category.Tier == 1);
            Print("TIER 1 AND PRICE < 900.00: ", result);

            var result2 = Products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS: ", result2);

            var result3 = Products.Where(p => p.Name[0] == 'C')
                .Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});
            Print("First letter is C: ", result3);

            var result4 = Products.Where(p => p.Category.Tier == 1)
                .OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("PRODUCTS WITH TIER 1: ", result4);

            var result5 = result4.Skip(2).Take(4);
            Print("SKIP FIRST 2 AND TAKE 4 ITEMS: ", result5);

            var results6 = Products.First();
            Console.WriteLine("\nFIRST ITEM: " + results6);

            var result7 = Products.Max(p => p.Price);
            Console.WriteLine("Better price: " + result7);

            var result8 = Products.Min(p => p.Name);
            Console.WriteLine("Better price: " + result8);

            var result9 = Products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Total price per category 1: "+result9);
            
            var result10 = Products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Total price per category 1: "+result10);

            var result11 = Products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine(result11);
            
            var result12 = Products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine(result12);

            var result13 = Products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in result13)
            {
                Console.WriteLine("Category: "+ group.Key.Name);
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }
            

        }

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine("\n"+message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}