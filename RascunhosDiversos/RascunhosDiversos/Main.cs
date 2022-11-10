using System;
using System.Diagnostics.Contracts;
using RascunhosDiversos.Entities;
using RascunhosDiversos.Entities.Enums;
using System.Globalization;
using System.Transactions;
using RascunhosDiversos.Exercises;
using Contract = RascunhosDiversos.Exercises.Contract;

namespace RascunhosDiversos;

public class main
{
    public static void Main(string[] args)
    {
        Console.Write("Enter department's name: ");
        string department = Console.ReadLine();
        Console.WriteLine("Enter the worker data:");
        Console.Write("Name: ");
        string workerName = Console.ReadLine();
        Console.Write("Level (Junior, MidLevel, Senior, Especialist, TechLead): ");
        WorkerLevels level = Enum.Parse<WorkerLevels>(Console.ReadLine());
        Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("How many contracts have that worker: ");
        int numContracts = int.Parse(Console.ReadLine());

        
        Worker Felipe = new Worker(name: workerName, level:level, salary: salary, new Department(department));
        
        for (int i = 0; i < numContracts; i++)
        {
            Console.WriteLine($"Enter contract #{i+1} data: ");
            Console.Write("Date (DD/MM/YYYY)");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duração do Contrato: ");
            int dur = int.Parse(Console.ReadLine());

            Felipe.AddContract(
                new Contract(
                    date: date,
                    value_hour: val,
                    duration_hours: dur));
        }
        
        Console.WriteLine(Felipe.ToString());
        Console.WriteLine("");
    }
}