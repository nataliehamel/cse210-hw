using System;

class Program
{
    static void Main(string[] args)
    {
        //events
        var a1 = new address("8940 Westmore Road", "San Diego", "California", "92126");
        var e1 = new lectureEvent("Learn Networking", "Basics to Networking Successfully", new DateTime(2023, 6, 20), new TimeSpan(3, 0 , 0), a1, "Robin Stoker", 300);

        var a2 = new address("1300 Cole Street", "Wheatland", "Wyoming", "82201");
        var e2 = new receptionEvent("Moon Wedding Reception", "Wedding Reception of Ryan Moon and Halle Sever", new DateTime(2023, 8, 14), new TimeSpan(4, 0 , 0), a2, "rsvp@weddings.com");

        var a3 = new address("510 Garfield Street", "Medford", "Oregon", "97501");
        var e3 = new outdoorGatheringEvent("Memorial Day Picnic", "Annual Memorial Day Picnic Brunch", new DateTime(2023, 5, 29), new TimeSpan(4, 0, 0), a3, "Sunny");


        //messages
        Console.WriteLine("Standard Details:");
        Console.WriteLine(e1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(e2.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(e3.GetStandardDetails());

        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(e1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(e2.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(e3.GetFullDetails());

        Console.WriteLine();

        Console.WriteLine("Short Description: ");
        Console.WriteLine(e1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(e2.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(e3.GetShortDescription());
    }
}