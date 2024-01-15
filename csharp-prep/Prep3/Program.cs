using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string inputString = Console.ReadLine();
        // int magicNumber = int.Parse(inputString);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        string inputString = "";
        
        // Console.WriteLine(magicNumber);
        Console.WriteLine();
        bool guessCorrect = false;

        Console.WriteLine("I'm thinking of a magic number.");

        while (guessCorrect == false)
        {
            Console.Write("What is your guess? ");
            inputString = Console.ReadLine();
            int guessedNumber = int.Parse(inputString);

            if (guessedNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            if (guessedNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            if (guessedNumber == magicNumber)
            {
                guessCorrect = true;
                Console.WriteLine("You guessed it!");
                Console.WriteLine();
            }
        }
    }
}