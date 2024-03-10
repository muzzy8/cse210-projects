using System;
using System.Collections;
namespace Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        bool _run = true;
        string _menuText = "Menu Options:\n1. Start Breathing Activity\n2. Start Reflection Activity\n3. Start Listing Activity\n4. Quit\n";
        string _userInput;
        Breathing _breathingActivity = new Breathing();
        Reflection _reflectionActivity = new Reflection();
        Listing _listingActivity = new Listing();


        string Menu()
        { // Display a menu and get user input
            Console.WriteLine(_menuText);
            string choice = Console.ReadLine();
            return choice;
        }

        // void Select(int menuOption)
        // { // Get the menu choice and direct the program to the right place

        // }

        // void Quit() //environment.exit(0)
        // { // End the program by changing _run to false.

        // }

        while (_run == true)
        {
            Console.Clear();
            _userInput = Menu();
            switch (_userInput)
            {
                case "1":
                    _breathingActivity.Execute();
                    break;
                case "2":
                    _reflectionActivity.Execute();
                    break;
                case "3":
                    _listingActivity.Execute();
                    break;
                case "4":
                    _run = false;
                    break;
            }
        }

    }
}