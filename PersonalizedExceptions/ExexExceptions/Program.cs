using System;
using ExexExceptions.Entities;
using ExexExceptions.Entities.Exceptions;

namespace ExexExceptions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                Console.Write("Room number: ");
                int rNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                Console.Write("CheckIn date (dd/mm/yyyy): ");
                DateTime rCheckIn = DateTime.Parse(Console.ReadLine());
                Console.Write("CheckOut date (dd/mm/yyyy): ");
                DateTime rCheckOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(rNumber, rCheckIn, rCheckOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.Write("New CheckIn: ");
                rCheckIn = DateTime.Parse(Console.ReadLine());
                Console.Write("New CheckOut: ");
                rCheckOut = DateTime.Parse(Console.ReadLine());
                reservation.UpdateDates(rCheckIn, rCheckOut);

                Console.WriteLine("New reservation: " + reservation);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Error reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error room number: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}