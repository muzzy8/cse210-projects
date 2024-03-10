using System;
namespace Mindfulness;

public class Listing : Activity {
    
    List<string> _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "How did you, or can you, show appreciation today?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost recently?", "Who is your personal hero?", "What is something you are thankful  for today?", "When was the last time you felt happy, and why?", "What's something you have learned recently?"};

    public Listing() : base() 
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    int StartEntry()
    {
        int number = 0;
        return number;
    }

    void Results()
    {

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
    
    public void Execute()
    {
        StartMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {RandomizePrompt()} ---");
        Console.Write("You may begin in: ");
        PauseCountdown(5000);
        Console.Write("\n");

        DateTime presentTime = DateTime.Now;
        DateTime endTime = presentTime.AddMilliseconds(_timer);

        while (presentTime < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            presentTime = DateTime.Now;
        }

        EndMessage();
    }
}