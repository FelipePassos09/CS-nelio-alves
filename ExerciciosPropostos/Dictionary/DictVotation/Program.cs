using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;

namespace DictVotation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> votos = new Dictionary<string, int>();


            Console.Write("Enter file full path: ");
            string file = Path.GetFullPath(Console.ReadLine());
            
            using (StreamReader sr = File.OpenText(file))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    if (votos.ContainsKey(line.Split(',')[0]))
                    {
                        int qntVotos = int.Parse(line.Split(',')[1]);
                        votos[line.Split(',')[0]] += qntVotos;
                    }
                    else
                    {
                        votos[line.Split(',')[0]] = int.Parse(line.Split(',')[1]);
                    }
                }
            }

            foreach (var item in votos)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}