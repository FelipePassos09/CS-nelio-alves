using System;
using System.Globalization;
using ExemploInterfaces.Entities;
using ExemploInterfaces.Services;

namespace ExemploInterfaces
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ENTRE RENTAL DATA:");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (DD/MM/YYYY HH:MM): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (DD/MM/YYYY HH:MM): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            
            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nINVOICE:");
            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());
            
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine(carRental.Invoice);
        }
    }
}