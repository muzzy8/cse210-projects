using System;
namespace Mindfulness;

public class Listing : Activity {
    
    List<string> _prompts;

    public Listing(string name, string description, int timer) : base(name, description, timer) 
    {
        _name = name;
        _description = description;
        _timer = timer;
    }

    int StartEntry()
    {
        int number = 0;
        return number;
    }

    void Results()
    {

    }
    
    void Execute()
    {

    }
}