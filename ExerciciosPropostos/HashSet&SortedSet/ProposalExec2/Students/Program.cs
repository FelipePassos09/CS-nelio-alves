using System;
using System.Collections.Generic;
using Students.Entities;

namespace Students
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            List<string> coursesOptions = new List<string>() { "A", "B", "C" };
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();
            List<HashSet<int>> courses = new List<HashSet<int>>() { courseA, courseB, courseC };

            int count = 0;
            
            foreach (var course in courses)
            {
                Console.Write($"How many students for course {coursesOptions[count]}? ");
                int loop = int.Parse(Console.ReadLine());
                
                for (int s = 0; s < loop; s++)
                {
                    Console.Write("Insert student code: ");
                    int studentCode = int.Parse(Console.ReadLine());
                    
                    AdStudents(course, studentCode);
                }
                
                count++;
            }

            Console.Write("Total Students: ");
            Console.WriteLine(TotalStudens(courses));
        }

        static void AdStudents(HashSet<int> course, int student_code)
        {
            course.Add(student_code);
        }

        static int TotalStudens(List<HashSet<int>> courses)
        {
            courses[0].UnionWith(courses[1]);
            for (int i = 1; i < courses.Count; i++)
            {
                courses[0].UnionWith(courses[i]);
            }

            return courses[0].Count;
        }
    }
}