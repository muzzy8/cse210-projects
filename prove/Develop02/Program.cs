namespace MyJournal;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {        
        string _userInput;
        bool _run = true;

        Journal _journal = new Journal();
        Entry _entry = new Entry();

        //The list of possible prompts
        List<string> _prompts = new List<string> {"What was the highlight of your day?"
        ,"Did you learn something new today?" 
        ,"How did you see the hand of the Lord in your life today?"
        ,"What emotions did you feel today?"
        ,"What is something you appreciated about the day?"
        ,"Describe an interesting person you saw or talked to today."
        ,"If you had one thing you had to do over today, what would it be?"
        ,"What is something you wondered about today?"};
        
        void ShowMenu()
        {
            // Displays a menu to the user.
            Console.WriteLine("Welcome to your personal journal. Enter a number to get started:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        }

        void Select()
        { 
            // Collect input from the user and activate the menu item chosen.
            // This might even go in main and not be a function.

            bool error = false;

            do
            {
                ShowMenu(); // Show the menu
                _userInput = Console.ReadLine(); // Prompt the user to enter a choice and store it
                Console.Clear();

                if (_userInput == "1")
                { // 1. Write
                    string _randomPrompt = ChooseRandomPrompt(); // Store a random prompt
                    _entry.Make(_randomPrompt);
                    _journal.WriteEntry(); // Updates the _entry attribute
                    Console.Clear();
                    _journal.AddEntry(_entry);

                }

                else if (_userInput == "2")
                { // 2. Display
                    Console.Clear();
                    _journal.Display();
                    Console.WriteLine("\nPress any key to return to the menu.");
                    Console.ReadKey();
                    Console.WriteLine();
                }

                else if (_userInput == "3")
                { // 3. Load
                    // Journal.Load();
                    Console.WriteLine("3");
                }

                else if (_userInput == "4")
                { // 4. Save
                    // Journal.Export();
                    Console.WriteLine("4");
                }

                else if (_userInput == "5")
                { // 5. Quit
                    _run = false;
                    error = false;
                }

                else
                {
                    Console.WriteLine("Invalid input. Please try again.\n");
                    error = true;
                }
            } while (error == true);
        }

        string ChooseRandomPrompt()
        { // Choose a random prompt from the _prompts list and return it
            int promptsListLength = _prompts.Count;
            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(0, promptsListLength);
            string randomPrompt = _prompts[randomIndex];
            return randomPrompt;
        }

        
        while (_run == true)
        {
            Select();
        }
    }
}