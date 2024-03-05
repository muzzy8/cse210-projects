using System;
namespace Mindfulness;

public class Breathing : Activity {
    public Breathing(string name, string description, int timer) : base(name, description, timer) 
    {
        _name = name;
        _description = description;
        _timer = timer;
    }

    void Execute()
    {
        StartMessage();
        
    }
}