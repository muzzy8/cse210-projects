using System;
using System.ComponentModel.Design;
// Then, for event event, call each of the methods to generate the marketing messages and output their results to the screen.

// your program must:

//Use inheritance to avoid duplicating shared attributes and methods.
//Use an address class for the addresses.
//Follow the principles of encapsulation, making sure each member variable is private.
class Program
{
    static void Main(string[] args)
    {
        Lecture event1 = new Lecture("Improve Your Memory: New Findings in Neuroscience", "Don't miss out on this exciting report. Includes practical instruction on improving memory and mental stamina.", "1 June, 2025", "3:00 pm", "Wisdom Auxilary Center, Suite 5, 789 Birch Street", "Dillian Brisbee", "400");

        Reception event2 = new Reception("Math Tutor Appreciation Gathering", "Pizza! Cake! Charity raffle! Live music! Please RSVP.", "13 September, 2025", "6:00 pm", "Waldorf Hall Lounge, 456 University Boulevard", "samwiggins18@yahoo.com");

        Outdoor event3 = new Outdoor("Back to School Bash", "Start the school year off with a bang! Free sack lunches, fair rides, face painting, and outdoor activities for kids. School district administration are attending to answer questions from parents.", "20 August, 2025", "11 am - 4 pm", "Riverside Park, 9 Levy Drive", "Sunny. High: 83 degrees. Low: 72 degrees");

        Console.WriteLine("* * * * *\n");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event1.StandardDetails());
        Console.WriteLine(event2.StandardDetails());
        Console.WriteLine(event3.StandardDetails());
        Console.WriteLine("* * * * *\n");

        Console.WriteLine("* * * * *\n");
        Console.WriteLine("Full Details:");
        Console.WriteLine(event1.FullDetails());
        Console.WriteLine(event2.FullDetails());
        Console.WriteLine(event3.FullDetails());
        Console.WriteLine("* * * * *\n");

        Console.WriteLine("* * * * *\n");
        Console.WriteLine("Short Description:");
        Console.WriteLine(event1.ShortDescription());
        Console.WriteLine(event2.ShortDescription());
        Console.WriteLine(event3.ShortDescription());
        Console.WriteLine("* * * * *\n");


    }
}