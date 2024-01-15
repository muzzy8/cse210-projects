// Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.

// 1. Compute the sum, or total, of the numbers in the list.
//
// 2. Compute the average of the numbers in the list.
//
// 3. Find the maximum, or largest, number in the list.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        // Initialize values
        string inputString = "1";
        List<int> numbers = new List<int>();

        // Print opening message
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Loop for the user to enter numbers. It stops when the user enters 0.
        while (int.Parse(inputString) != 0)
        {
            Console.Write("Enter number: ");
            inputString = Console.ReadLine();

            // User input is copied as an int
            int inputInt = int.Parse(inputString);

            // This condition prevents 0 from being added to the list
            if (inputInt != 0)
            {
                // Add the number as an int to the list
                numbers.Add(inputInt);
            }
        }

        // Compute sum of all numbers
        double sum = 0;

        foreach (int number in numbers)
        {
            sum = number + sum;
        } 

        // Compute average of all numbers
        double quantityNumbers = numbers.Count;
        double average = sum / quantityNumbers;

        // Compute the largest number
        int highestNumber = numbers.Max();

        // Print calculations
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {highestNumber}");
        Console.WriteLine();
    }
}