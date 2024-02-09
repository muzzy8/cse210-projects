namespace MyJournal;
using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string _userInput;
        bool _run = true;

        Journal _journal = new Journal();

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
                    Entry _entry = new Entry();
                    _entry.Make(_randomPrompt);
                    Console.Clear();
                    _journal.AddEntry(_entry);

                }

                else if (_userInput == "2")
                { // 2. Display
                    _journal.Display();
                    Console.WriteLine("\nPress any key to return to the menu.");
                    Console.ReadKey();
                    Console.WriteLine();
                }

                else if (_userInput == "3")
                { // 3. Load
                    LoadFile();
                    Console.Write("-- Journal loaded. --\n\n");
                }

                else if (_userInput == "4")
                { // 4. Save
                    SaveFile();
                    Console.Write("-- Journal saved! --\n\n");
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

        void LoadFile()
        {
            Console.WriteLine("Load File");
            Console.Write("Please enter a filename that ends with .txt  ");
            string fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            _journal.Reset();

            foreach (string line in lines)
            {
                string[] parts = line.Split("*");

                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Entry loadedEntry = new Entry(response, prompt, date);
                loadedEntry.Render();
                _journal.AddEntry(loadedEntry);
            }

        }

        void SaveFile()
        {
            List<string> strings = _journal.GetEntriesString();

            Console.WriteLine("Save File");
            Console.Write("Please enter a filename that ends with .txt  ");
            string fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (string onestring in strings)
                {
                    outputFile.WriteLine(onestring);
                }
            }
        }


        while (_run == true)
        {
            Select();
        }
    }
}