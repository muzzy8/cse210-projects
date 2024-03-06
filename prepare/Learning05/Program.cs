using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("red", 5.0);

        Console.WriteLine(mySquare.GetArea());
        Console.WriteLine(mySquare.GetColor());
        Console.WriteLine();

        Rectangle myRectangle = new Rectangle("orange", 5.0, 6.0);

        Console.WriteLine(myRectangle.GetArea());
        Console.WriteLine(myRectangle.GetColor());

        Circle myCircle = new Circle("blue", 5.0);

        Console.WriteLine(myCircle.GetArea());
        Console.WriteLine(myCircle.GetColor());
        Console.WriteLine();
        
        List<Shape> shapesList = new List<Shape>()
        {
            new Square("black", 1.5), new Rectangle("gray", 2.5, 1), new Circle("white", 3.5)
        };

        foreach (Shape shape in shapesList)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
            Console.WriteLine();
        }


    }
}