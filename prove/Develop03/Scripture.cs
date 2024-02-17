namespace ScriptureMemorizer;
using System;
using System.Reflection;

class Scripture
{
    private List<Verse> _verses = new List<Verse>();
    private Verse _verse = new Verse();
    private Reference _reference;
    private string _rendered;
    private bool _continue = true;

    //              Constructors:
    public Scripture() //Empty
    {

    }

    public Scripture(Reference _reference, Verse _verse) //Single verse
    {
        this._reference = _reference;
        this._verse = _verse;
    }

    public Scripture(Reference _reference, List<Verse> _verses) //Multiple verse
    {
        this._reference = _reference;
        this._verses = _verses;
    }

    //              Getters and setters:

    public bool GetContinue()
    {
        return _continue;
    }

    //              Methods:
    public void Display()
    { //Clears the console & displays the current scripture.
        // Console.Clear();
        // Console.Out.Flush();
        // System.Diagnostics.Process.Start("bash", "-c \"clear\"");
        Render();
        // Console.WriteLine($"\n \n \n \n \n \n" + _rendered);
        Console.WriteLine(_rendered);
    }

    public void Enter()
    {//Triggered when the user presses the enter key in Program.
        _verse.HideWord();
        // Render();
        Display();
    }

    void Render()
    {//Can set _renderd. Scriptures with multiple entries are rendered differently than scriptures with one verse.
        _verse.BuildFromWords();
        if (_reference.GetIsRange() == false)
        { // For a single verse
            _rendered = $"{_reference.GetReferenceText()} {_verse.GetText()}";
        }

        else if (_reference.GetIsRange() == true)
        { // For multiple verses
            if (_verse.GetIsCompressed() == false)
            {
                CompressText();
            }
            _rendered = $"{_reference.GetReferenceText()} {_verse.GetText()}";
        }
    }

    void CompressText()
    {
        _verse.SetText(GetEachVerseText());
        _verse.PopulateList();
        _verse.SetIsCompressed(true);
    }

    // void RenderFromWords()
    // {
    //     if (_reference.GetIsRange() == false)
    //     {
    //         for (word in _words)
    //     }

    //     else if (_reference.GetIsRange() == true)
    //     {
            
    //     }
    // }

    string GetEachVerseText()
    {
        string verseStrings = "";
        foreach (Verse verse in _verses)
        {
           verseStrings += verse.GetText() + " ";
        }
        return verseStrings;
    }

    public void CheckWordsLeft()
    {
        if (_verse.GetWordsLeft() <= 0)
        {
            _continue = false;  
        }
    }
}