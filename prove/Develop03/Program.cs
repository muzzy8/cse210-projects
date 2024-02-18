namespace ScriptureMemorizer;
using System;

class Program
{

    static void Main(string[] args)
    {
        //                  Attributes:
        Scripture _scripture;
        List<Scripture> _scriptures = new List<Scripture>();
        bool _run = true;


        //                  Methods:
        void Prompt()
        { // Collects key input to control the program.
            Console.WriteLine("\nPress Enter to continue or any key to quit...");

            ConsoleKeyInfo keyInfo = Console.ReadKey(); // Read a key from the console input

            if (keyInfo.Key == ConsoleKey.Enter) // If the key pressed is the enter key, continue hiding words.
            {
                _scripture.Enter();
            }
            else // If any other key is pressed, the program stops.
            {
                _run = false;
            }

        }

        void PickScripture()
        { // Generates a random index value and sets _scripture using the random index value.
            int scripturesListLength = _scriptures.Count; // Save the count of the _scriptures list.
            Random randomGenerator = new Random(); // Prepare an instance of Random.
            // Using random, pick a random index within the length of the list.
            int randomIndex = randomGenerator.Next(0, scripturesListLength);
            // Select the scripture at the random index. This is now _scroipture.
            _scripture = _scriptures[randomIndex];
        }

        void PopulateList()
        { // Constructs Scriptures and adds them to the _scriptures List.

            // Old Testament
            _scriptures.Add(
                new Scripture(
                    new Reference("Moses 1:39", false),
                    new Verse("For behold, this is my work and my glory — to bring to pass the immortality and eternal life of man.")
                )
            );

            _scriptures.Add(
                new Scripture(
                    new Reference("Moses 7:18", false),
                    new Verse("And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.")
                )
            );

            _scriptures.Add(
                new Scripture( // This scripture has multiple verses.
                    new Reference("Proverbs 3:5-6", true),
                    new List<Verse>()
                    {
                        new Verse("Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
                        new Verse("In all thy ways acknowledge him, and he shall direct thy paths.")
                    }
                )
            );
        }


        //                  Main Program
        Console.Clear(); // Clear output from the last session
        PopulateList(); // Get what scriptures we have to choose from
        PickScripture(); // Choose a random scripture
        _scripture.Display(); // Display the chosen scripture
        while (_run == true)
        {
            Prompt(); // Collect console key input 
            if (_run == true) // I had troube with the while statement being "ignored". So I added an if statement.
            {
                _scripture.CheckWordsLeft(); // How many words are left?
                _run = _scripture.GetContinue(); // Based on how many words are left, can the program continue?
            }
        }
    }
}