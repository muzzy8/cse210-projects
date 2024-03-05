using System;
namespace Mindfulness;

public class Reflection : Activity {
    
    List<string> _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you went out of your comfort zone.", "Think of a time when you asked for help.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    List<string> _questions = new List<string>{ "Why was this experience meaningful to you?", "Had you ever done anything anything like this when this happened?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not successful?", "What is something you want to remember about this experience?", "What is your favorite thing about this experience?", "What did you learn about yourself through this experience?", "Has this experienced changed the way you approach situations like these?" };

// I need help here vvv
    public Reflection(string name, string description, int timer) : base(name, description, timer) 
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resillience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _timer = timer;
    }

    void Execute()
    {
        StartMessage();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {RandomizePrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        //Console read key enter
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        PauseCountdown(5000);
        Console.Clear();
        //write code to do this as many times as _timer allows. while something something..
        Console.Write($"\n> {RandomizeQuestion()}");
        EndMessage();
    }   

    string RandomizePrompt()
    {
        string randomPrompt = "";
        return randomPrompt;
    }

    string RandomizeQuestion()
    {
        string randomQuestion = "";
        return randomQuestion;
    }
}