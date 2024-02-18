namespace ScriptureMemorizer;
using System;

/*
    A Scripture has two major components: the scripture Reference and the Verse. 
    A Scripture with multiple verses has a Reference and a List of Verses. 

    Two additional attributes of a Scripture are 
    (1) a formatted string, called _rendered, containing both the Reference and the Verse(s).
    (2) a bool, _continue, that stores whether or not the program should continue. It's initially defined
    as true, but it becomes false when every Word in the Verse has been hidden.
    
    The Scripture class cannot terminate the program by itself with _continue. Instead, _continue is regularly
    retrieved by the Program class. The Program class will end the program if GetContinue() returns a false.
*/

class Scripture
{
    //                  Attributes:
    private Reference _reference;
    private Verse _verse = new Verse();
    private List<Verse> _verses = new List<Verse>();
    private string _rendered;
    private bool _continue = true;

    //                  Constructors:
    public Scripture() // Empty
    {

    }

    public Scripture(Reference _reference, Verse _verse) // Single verse
    {
        this._reference = _reference;
        this._verse = _verse;
    }

    public Scripture(Reference _reference, List<Verse> _verses) // Multiple verses
    {
        this._reference = _reference;
        this._verses = _verses;
    }

    //                  Getters and setters:
    public bool GetContinue()
    {
        return _continue;
    }

    //                  Methods:

    public void CheckWordsLeft()
    { // If no visible words remain in the Verse(s), this sets _continue to false.
        if (_verse.GetVisibleIndexes().Count == 0)
        {
            _continue = false;
        }
    }

    public void Enter()
    { // Triggered when the user presses the enter key.
        _verse.HideWords();
        Display();
    }

    public void Display()
    { // Clears the console & displays the current scripture.
        Console.Clear();
        Render(); // Render the most recent version of the scripture.
        Console.WriteLine(_rendered);
    }

    void Render()
    { // Sets _rendered. 
      // Scriptures with multiple entries are "compressed" the first time to allow the call to GetText().

        _verse.BuildFromWords(); // Set _text to the most updated version of the _verse's _text

        if (_reference.GetIsRange() == false)
        { // For a single verse
            _rendered = $"{_reference.GetReferenceText()} {_verse.GetText()}";
        }

        else if (_reference.GetIsRange() == true)
        { // For multiple verses
            if (_verse.GetIsCompressed() == false)
            {
                CompressText(); // Scriptures with multiple Verses need to be merged into one string.
            }
            _rendered = $"{_reference.GetReferenceText()} {_verse.GetText()}";
        }
    }

    void CompressText()
    {   // For Scriptures with multiple Verses, this sets the _text to a string with the Verses' _text combined.
        _verse.SetText(GetEachVerseText()); // Set the _text of _verse to a string representing all the Verses.
        _verse.PopulateLists(); // Populate _words and _visible Indexes using the new value of _text
        // This Verse is now designated as "compressed" so that it doesn't get compressed again.
        _verse.SetIsCompressed(true);
    }

    string GetEachVerseText()
    { // Creates and returns a string of all the Verses in _verses.
        string verseStrings = ""; // Initialize verseStrings
        foreach (Verse verse in _verses)
        { // Add the _text of each Verse in _verses to verseStrings. Pleace a space after each verse.
            verseStrings += verse.GetText() + " ";
        }
        return verseStrings;
    }

}