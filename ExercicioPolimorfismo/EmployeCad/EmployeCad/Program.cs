using System;
using EmployeCad.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace EmployeCad
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter with total of employees: ");
            int employees = int.Parse(Console.ReadLine());

            List<Employee> totalEmployees = new List<Employee>();
            
            for (int emp = 0; emp < employees; emp++)
            {
                Console.WriteLine($"Employee #{emp +1} data:");
                Console.Write("Outsourced (y/n): ");
                char outsourced = char.Parse(Console.ReadLine().ToUpper());
                
                Console.Write("Name: ");
                string empName = Console.ReadLine();
                Console.Write("Hours: ");
                int empHours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double empValueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (outsourced == 'Y')
                {
                    Console.Write("Aditional charge: ");
                    double empAdditional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    totalEmployees.Add(new OutsourceEmployee(empName, empHours, empValueHour, empAdditional));
                }

                if (outsourced == 'N')
                {
                    totalEmployees.Add(new Employee(empName,empHours,empValueHour));
                }

            }
            
            Console.WriteLine("PAYMENTS:");

            foreach (var emp in totalEmployees)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}