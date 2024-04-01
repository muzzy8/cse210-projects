class FileManager
{
    string _filename;
    string _location;
    Session _session = new Session();
    public FileManager()
    {

    }

    // void Compress()
    // {

    // }

    // void Format()
    // {

    // }

    void Save()
    { // save points and goals

    }

    void Load()
    { // load points and goals

    }

    public void SaveFile()
    {
        // List<string> strings = new List<string>();
        // List<string> strings = _journal.GetEntriesString();
        Console.Clear();
        Console.WriteLine("Save File\n");
        Console.Write("Name this file: ");
        _filename = Console.ReadLine();
        if (!_filename.Contains(".txt"))
        {
            _filename = _filename + ".txt";
        }

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            string sessionSummary = _session.GetSessionSummary();
            // string[] lines = sessionSummary.Split(new[] { '\n' });
            // foreach (string line in lines)
            // {
            outputFile.Write(sessionSummary);
            // }
        }
    }

    // void LoadFile()
    // {
    //     Console.WriteLine("Load File");
    //     Console.Write("Please enter a filename that ends with .txt  ");
    //     string fileName = Console.ReadLine();
    //     string[] lines = System.IO.File.ReadAllLines(fileName);
    //     _journal.Reset();

    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split("*");

    //         string date = parts[0];
    //         string prompt = parts[1];
    //         string response = parts[2];
    //         Entry loadedEntry = new Entry(response, prompt, date);
    //         loadedEntry.Render();
    //         _journal.AddEntry(loadedEntry);
    //     }

    // }

}