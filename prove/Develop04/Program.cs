using System;
namespace Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        bool _run = true;
        string _menuText;
        Activity _activity = new Activity();

        int Menu()
        { // Display a menu and get user input
            int integer = 0;
            return integer;
        }

        void Select(int menuOption)
        { // Get the menu choice and direct the program to the right place

        }

        void Quit() //environment.exit(0)
        { // End the program by changing _run to false.

        }

        while (_run == true)
        {
            Menu();
            _activity.StartMessage();
        }

    }
}