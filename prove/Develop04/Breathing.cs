using System;
namespace Mindfulness;

public class Breathing : Activity {
    public Breathing() : base() 
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Execute()
    {
        StartMessage();

        DateTime presentTime = DateTime.Now;
        DateTime endTime = presentTime.AddMilliseconds(_timer);

        while (presentTime < endTime)
        {
            Console.Write("\nBreathe in...");
            PauseCountdown(4000);
            Console.Write("\nBreathe out...");
            PauseCountdown(6000);
            Console.Write("\n");
            presentTime = DateTime.Now;
        }

        EndMessage();
    }
}