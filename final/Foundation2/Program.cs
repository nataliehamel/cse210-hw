using System;

class Program
{
    static void Main(string[] args)
    {
        address a1 = new address("1431 W Elm St", "Lodi", "CA", "USA");
        customer c1 = new customer("Brynn Tucker", a1);

        address a2 = new address("561 George St", "London", "Providence", "UK");
        customer c2 = new customer("Hayden Gill", a2);

        product p1 = new product("Purple Tiger Keychain", "1", 10.95m, 2);
        product p2 = new product("'Hikes' Book", "2", 24.50m, 1);
        product p3 = new product("Volcano Candle", "3", 22.45m, 4);

        order o1 = new order(new List<product> {p1, p3}, c1);
        order o2 = new order(new List<product> {p1, p2, p3}, c2);

        Console.WriteLine("Order 1: ");
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + o1.GetTotalCost());
        Console.WriteLine();

        Console.WriteLine("Order 2: ");
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + o2.GetTotalCost());

        Console.ReadLine();
    }
}