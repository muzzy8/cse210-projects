using System;
namespace Mindfulness;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _timer = 0;

    public Activity()
    {
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    { // start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        TimePrompt();
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseAnimation(3500);
    }

    protected void EndMessage()
    { // Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
        Console.WriteLine("\n\nWell done!");
        PauseAnimation(3500);
        Console.WriteLine($"\nYou have completed another {_timer / 1000} seconds of the {_name} Activity.");
        PauseAnimation(4000);
    }

    protected void TimePrompt()
    { // Sets _timer
        _timer = int.Parse(Console.ReadLine()) * 1000;
    }

    void PauseAnimation(int milliseconds)
    {
        DateTime animationStart = DateTime.Now;
        DateTime animationEnd = animationStart.AddMilliseconds(milliseconds);

        while (DateTime.Now < animationEnd)
        {
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(":");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("'");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(":");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        // for (int i = milliseconds; i > 0; i--)
        // {
        //     Console.Write(".");
        //     Thread.Sleep(500);
        //     Console.Write("\b \b");
        //     Console.Write(":");
        //     Console.Write("\b \b");
        //     Console.Write("'");
        //     Console.Write("\b \b");
        // }
    }

    protected void PauseCountdown(int milliseconds)
    {
        int seconds = milliseconds / 1000;

        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
