using System;
namespace Mindfulness;

public class Activity {
    protected string _name = "";
   protected string _description = "";
    protected int _timer = 0;

    public Activity()
    {
    }
    
    public Activity(string name, string description, int timer)
    {
        _name = name;
        _description = description;
        _timer = timer;
    }
    
    public void StartMessage()
    { // start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        TimePrompt();
        // Console.Clear(); or \r in line below
        Console.WriteLine("\rGet ready...\n");
        PauseAnimation(5000);
    }

    protected void EndMessage()
    { // Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
    Console.WriteLine($"Well done!!\n\nYou have completed another {_timer} seconds of the {_name} Activity.");
    PauseAnimation(5000);
    }

    void TimePrompt()
    { // Sets _timer
        _timer = int.Parse(Console.ReadLine());
    }

    void PauseAnimation(int milliseconds)
    {
        Console.WriteLine(milliseconds);
    }

    protected void PauseCountdown(int milliseconds) 
    {

    }
}
