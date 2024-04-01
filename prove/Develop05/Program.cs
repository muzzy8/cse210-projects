using System;
using System.ComponentModel.DataAnnotations;
// 1. Create New Goal, 2. List Goals, 3. Save Goals, 4. Load Goals, 5. Record Event, 6. Quit
// Make sure your terminal window is expanded 
class Program
{
    static void Main(string[] args)
    {
        FileManager _fileManager = new FileManager();
        bool _run = true;
        int _score = 0;
        List<Goal> _goals = new List<Goal>();
        Session _session = new Session();
        string _topMenuText = @"
Choose an action:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
> ";
        string _createMenuText = @"
What type of goal would you like to create?
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
> ";



        void TopMenu()
        {
            // GetScore() or just print _score
            Console.WriteLine($"Points: {_score}");
            Console.Write(_topMenuText);

            Select();
        }

        void NewGoalMenu()
        {
            Console.Clear();
            Console.Write(_createMenuText);
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Simple simpleGoal = new Simple();
                    // simpleGoal.Create();
                    _goals.Add(simpleGoal);
                    break;
                case "2":
                    Eternal eternalGoal = new Eternal();
                    // eternalGoal.Create();
                    _goals.Add(eternalGoal);
                    break;
                case "3":
                    Checklist checklistGoal = new Checklist();
                    // checklistGoal.Create();
                    _goals.Add(checklistGoal);
                    break;
            }
            Console.Clear();
        }

        void Select()
        {
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    NewGoalMenu();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    _fileManager.SaveFile();
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    _run = false;
                    break;
            }
        }

        void ListGoals()
        {
            Console.Clear();
            Console.WriteLine("My goals:");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"   [ ] {goal.GetTitle()} ({goal.GetDescription()})"); // need to add capability for the x. Have it be diffrent for checklist type goals! I can probably use ifs or switch case for this and just print different statements.
            }
            Console.WriteLine("");
        }

        // Session - this could be a class and loading could construct a new instance of it

        void Reset()
        {

        }

        // string PrepareSave(List<Goal> mygoals)
        // {
        //     foreach (Goal onegoal in mygoals)
        //     {
        //         string line = onegoal.MakeDelimitedFormat() + $",{_score}";
        //         goalsString +=
        //     }
        //     return goalsString;
        // }

        Console.Clear();
        while (_run == true)
        {
            TopMenu();
        }
    }
}