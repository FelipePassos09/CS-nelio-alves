using System;

namespace ExerciseEquals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string a = "Maria";
            string b = "maria";

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        
        }
    }
}