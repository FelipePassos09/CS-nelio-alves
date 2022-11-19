using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ExempleCourse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string sourcePathFile = @"S:\Courses\CS-nelio-alves\TrabalhandoComArquivos\ExempleCourse\.files\file1.txt";
            string targetPathFile = @"S:\Courses\CS-nelio-alves\TrabalhandoComArquivos\ExempleCourse\.files\file2.txt";

            string sourcePathDirectory = @"S:\Courses\CS-nelio-alves\TrabalhandoComArquivos\ExempleCourse\.files\";
            string targetPathDirectory = @"S:\Courses\CS-nelio-alves\TrabalhandoComArquivos\ExempleCourse\.files\newFolder";

            /*
             // FileInfo
             try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                //fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occoured on open file.");
                Console.WriteLine(e.Message);
            }*/

            /*
             // StreamWriter: 
             try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = new StreamWriter(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occoured:");
                Console.WriteLine(e.Message);
                throw;
            } */

            /*
                // Directory & DirectoryInfo:
             try
            {
                var folder = Directory.EnumerateDirectories(sourcePathDirectory,"*.*", SearchOption.AllDirectories);
                foreach (var iFolder in folder)
                {
                    Console.WriteLine(iFolder);
                }
                
                var files = Directory.EnumerateFiles(sourcePathDirectory, ".", SearchOption.AllDirectories);
                foreach (var iFiles in files)
                {
                    Console.WriteLine(iFiles);
                }

                Directory.CreateDirectory(targetPathDirectory + @"/newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }*/

            try
            {
                sourcePathFile = @"./.files/file1.txt";
                
                Console.WriteLine("Folder: " + Path.GetDirectoryName(sourcePathFile));
                Console.WriteLine("Separator Path: " + Path.DirectorySeparatorChar);
                Console.WriteLine("Separator File: " + Path.PathSeparator);
                Console.WriteLine("GetFileName: "+Path.GetFileName(sourcePathFile));
                Console.WriteLine("GetFileNameWithoutExtension: "+ Path.GetFileNameWithoutExtension(sourcePathFile));
                Console.WriteLine("GetExtension: "+Path.GetExtension(sourcePathFile));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(sourcePathFile));
                Console.WriteLine("Get temp folder: "+ Path.GetTempPath());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}