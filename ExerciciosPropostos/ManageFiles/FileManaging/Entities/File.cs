using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FileManaging
{
    public class ManageFile
    {
        public string FileInputPath { get; set; }
        public string FileOutputPath { get; set; }
        public string Pattern { get; set; }

        public ManageFile(string fileInputPath, string fileOutputPath, string pattern)
        {
            FileInputPath = fileInputPath;
            FileOutputPath = fileOutputPath;
            Pattern = pattern;
        }

        public void Test()
        {
            using (var sr = new StreamReader(FileInputPath))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr);
                }
            }
        }
        
        public void Totalizar()
        {
            using (var sr = new StreamReader(FileInputPath))
            {
                    
            }
        }

        public override string ToString()
        {

            return ;
        }
    }
}