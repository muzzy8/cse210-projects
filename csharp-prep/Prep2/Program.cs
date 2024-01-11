using System;
// Write a program that determines the letter grade for a course according to the following scale:

// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60

// Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade. (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.Write("Enter grade percentage: ");
        var gradePercentEntry = Console.ReadLine();
        int gradePercent = int.Parse(gradePercentEntry);
        Console.WriteLine($"{gradePercent}%");

        string letterGrade = "";
        
        if (gradePercent > 100)
        {
            letterGrade = "?!";
        }
        else if (gradePercent >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercent >= 60)
        {
            letterGrade = "D";
        }
        else if (gradePercent < 60)
        {
            letterGrade = "F";
        }
        else
        {
            letterGrade = "?!";
        }
        
        Console.WriteLine(letterGrade);
        Console.WriteLine();
        

        // You must have a 70 to pass.

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations, you passed! :)");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("You didn't pass. Surely next time you'll do better.");
            Console.WriteLine();
        }

    }
}