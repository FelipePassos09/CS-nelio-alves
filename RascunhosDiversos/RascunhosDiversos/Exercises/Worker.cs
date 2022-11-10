using System.Collections.Generic;
namespace RascunhosDiversos.Exercises;

public class Worker
{
    public string Name { get; set; }
    public WorkerLevels Level { get; set; }
    public Department Department { get; set; }
    public double Salary { get; set; }
    public List<Contract> Contracts { get; set; } = new List<Contract>();


    public Worker()
    {
    }

    public Worker(string name, WorkerLevels level, double salary, Department department)
    {
        Name = name;
        Level = level;
        Salary = salary;
        Department = department;
    }

    public void AddContract(Contract contract)
    {
        Contracts.Add(contract);
    }

    public void RemoveContract(Contract contract)
    {
        Contracts.Remove(contract);
    }

    public double Income(int year, int month)
    {
        double sum = Salary;
        
        foreach (var cnt in Contracts)
        {
            if (cnt.DateContract.Year == year && cnt.DateContract.Month == month)
            {
                sum += cnt.TotalValue();
            }
        }

        return sum;
    }
    
    public override string ToString()
    {
        return
            $"Name: {Name}\nDepartments: {Department}\nLevel: {Level}\nBase Salary: {Salary}\nNumber of Contracts: {Contracts.Count}";
    }
}