using System.IO.Enumeration;
using System.IO;

namespace MyJournal;

class Journal
{
    List<Entry> _entries = new List<Entry>();

    public Journal()
    {
        
    }

    public void Display()
    {
        int index = 0;
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"---------------\n{entry.GetDate()}\n{entry.GetPrompt()}\n\n{entry.GetResponse()}\n");
            index += 1;
        }

    }
    public List<string> GetEntriesString()
    {
        List<string> entriesStrings = new List<string>();
        int index = 0;

        foreach (Entry entry in _entries)
        {
            entriesStrings.Add(_entries[index].GetRendered());
            index += 1;
        }

        return entriesStrings;
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Reset()
    {
        _entries = new List<Entry>();
    }
}
