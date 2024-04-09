using System;
class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.AddProduct("Scotch Transparent Tape", "1006", 2.89, 7);
        order1.AddProduct("Post-It Sticky Notes - Neon (6 pad pack)", "1026", 6.28, 3);
        order1.AddProduct("Oxford 3-Hole Sheet Protectors (Box of 200)", "1014", 13.09, 2);
        order1.MakeCustomer("Betsy Ross", "321 Liberty Lane", "Philadelphia", "PA", "USA");

        Order order2 = new Order();
        order2.AddProduct("Pyrex 4-Cup Liquid Measuring Cup", "4047", 12.98, 1);
        order2.AddProduct("KitchenAid Stainless Steel Measuring Spoon Set", "4055", 7.89, 2);
        order2.MakeCustomer("Betty Crocker", "22 Expat Road", "Windsor", "Berkshire", "United Kingdom");

        Console.WriteLine("- - - - - - - - - - - - -");
        Console.WriteLine(order1.CreateShippingLabel());
        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine($"Total: $ {order1.CalculateTotalCost()}");

        Console.WriteLine("- - - - - - - - - - - - -");
        Console.WriteLine(order2.CreateShippingLabel());
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine($"Total: $ {order2.CalculateTotalCost()}");

    }
}