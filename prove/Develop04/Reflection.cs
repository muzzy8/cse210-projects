using System;
namespace Mindfulness;

public class Reflection : Activity {
    
    List<string> _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you went out of your comfort zone.", "Think of a time when you asked for help.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    List<string> _questions = new List<string>{ "Why was this experience meaningful to you?", "Had you ever done anything anything like this when this happened?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not successful?", "What is something you want to remember about this experience?", "What is your favorite thing about this experience?", "What did you learn about yourself through this experience?", "Has this experienced changed the way you approach situations like these?" };

    public Reflection() : base() 
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resillience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Execute()
    {
        StartMessage();
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {RandomizePrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        
        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            
        }

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        PauseCountdown(5000);
        Console.Clear();
        //write code to do this as many times as _timer allows. while something something..
        DateTime presentTime = DateTime.Now;
        DateTime endTime = presentTime.AddMilliseconds(_timer);

        while (presentTime < endTime)
        {
        Console.Write($"\n> {RandomizeQuestion()} ");
        PauseCountdown(5000);
        presentTime = DateTime.Now;
        }

        EndMessage();
    }   

    string RandomizePrompt()
    {
        string randomPrompt;
        int promptsListLength = _prompts.Count; // Save the count of the _scriptures list.
        Random randomGenerator = new Random(); // Prepare an instance of Random.
        // Using random, pick a random index within the length of the list.
        int randomIndex = randomGenerator.Next(0, promptsListLength);
        // Select the scripture at the random index. This is now _scroipture.
        randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }

    string RandomizeQuestion()
    {
        string randomQuestion;
        int questionsListLength = _questions.Count;
        Random randomGenerator = new Random(); // Prepare an instance of Random.
        // Using random, pick a random index within the length of the list.
        int randomIndex = randomGenerator.Next(0, questionsListLength);
        // Select the scripture at the random index. This is now _scroipture.
        randomQuestion = _questions[randomIndex];
        return randomQuestion;
    }
}