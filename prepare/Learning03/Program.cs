using System;
namespace Fractions;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        // fraction1.SetTop(2);
        // fraction1.SetBottom(3);

        // fraction2.SetTop(4);
        // fraction2.SetBottom(5);

        // fraction3.SetTop(8);
        // fraction3.SetBottom(9);

        // Console.WriteLine($"{fraction1.GetTop()}/{fraction1.GetBottom()}");
        // Console.WriteLine($"{fraction2.GetTop()}/{fraction2.GetBottom()}");
        // Console.WriteLine($"{fraction3.GetTop()}/{fraction3.GetBottom()}");

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction3.GetFractionString());

        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}