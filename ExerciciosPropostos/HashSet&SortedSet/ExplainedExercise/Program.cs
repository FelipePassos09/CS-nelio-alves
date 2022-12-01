using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using ExplainedExercise.Entities;

namespace ExplainedExercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Path.GetFullPath(Console.ReadLine());
            
            StreamReader file = File.OpenText(path);

            HashSet<User> users = new HashSet<User>();

            try
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    users.Add(new User(line.Split(' ')[0], DateTime.ParseExact(line.Split(' ')[1], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture)));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            Console.Write("Total users: ");
            Console.Write(users.Count);

        }
    }
}