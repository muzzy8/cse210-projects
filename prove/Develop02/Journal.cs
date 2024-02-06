using System.IO.Enumeration;

namespace MyJournal;

class Journal
{
    List<Entry> _entries = new List<Entry>();

    // public Dealer()
    // {
    //     cars = new List<Car>();
    // }

    // public Dealer(string[] importLines)
    // {
    //     cars = new List<Car>();
    //     foreach (var line in importLines)
    //     {
    //         var car = new Car(line);
    //         cars.Add(car);
    //     }
    // }

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // public Journal(string[] importLines);
    //     {
    //         _entries = new List <Entry>;
    //         foreach (var line in importLines)
    //         {
    //             var _entry = new Entry(line);
    //         }
    //     }

    
    // Entry _entry = new Entry();

    public void Display()
    {
        int index = 0;
        // Console.WriteLine(_entries.Count());
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(_entries[index].GetRendered());
            index += 1;
        }
        
    }

    // public void Load(filename)
    // {

    // }

    // public void Export(filename)
    // {

    // }

    // For each entry in entries List, entry.render

    // public void Write(string newEntry)
    // {
    //     newEntry
    //     _entries.Add(newEntry);
    // }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void WriteEntry()
    {
        Entry _blank = new Entry();
        string prompt = _blank.GetPrompt();
        string date = _blank.GetDate();
        string response = _blank.GetResponse();
        string rendered = _blank.GetRendered();
        Entry _entry = new Entry(response, prompt, date, rendered);
        AddEntry(_entry);
    }
        
    
}

