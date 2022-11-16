using System;
using ExexExceptions.Entities.Exceptions;

namespace ExexExceptions.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut < checkIn)
            {
                throw new DomainExceptions("CheckOut Date must be after CheckIn");
            }
            
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainExceptions("Reservation dates must be future dates.");
            }

            if (checkOut < checkIn)
            {
                throw new DomainExceptions("CheckOut Date must be after CheckIn");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + "checkIn: "
                + CheckIn.ToString("dd/MM/yyyy")
                + "checkOut: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights.";
        }
    }
}