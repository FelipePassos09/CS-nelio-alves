using System;

namespace RascunhosDiversos;

public class principal
{
    public static void Main(string[] args)
    {
        //ExecSwitch.SCase(int.Parse(Console.ReadLine()));

        var duration = new TimeSpan(5, 2, 46, 18);
        Console.WriteLine(duration);

        var dataInit = new DateTime(2022, 11, 8, 12, 00, 00);
        var dateEnd = new DateTime(2022, 11, 8, 14, 00, 00);

        var newduration = (dateEnd) - dataInit;

        Console.WriteLine(newduration);
    }
}