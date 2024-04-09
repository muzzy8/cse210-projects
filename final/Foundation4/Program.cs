using System;
namespace Exercise;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Running exercise1 = new Running("4/10/24", 25, 2.5);
        Cycling exercise2 = new Cycling("4/12/24", 60, 18.9);
        Swimming exercise3 = new Swimming("4/16/24", 30, 36);

        var exerciseLogs = new List<Activity>() {exercise1, exercise2, exercise3};

        foreach (Activity log in exerciseLogs)
        {
            log.GetSummary();
        }
    }
}