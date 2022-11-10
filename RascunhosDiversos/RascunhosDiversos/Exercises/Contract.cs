namespace RascunhosDiversos.Exercises;

public class Contract
{
    public DateTime DateContract { get; set; }
    public double ValueHour { get; set; }
    public int DurationHours { get; set; }

    public Contract()
    {
        
    }

    public Contract(DateTime date, double value_hour, int duration_hours)
    {
        DateContract = date;
        ValueHour = value_hour;
        DurationHours = duration_hours;
    }

    public double TotalValue()
    {
        return ValueHour * DurationHours;
    }
}