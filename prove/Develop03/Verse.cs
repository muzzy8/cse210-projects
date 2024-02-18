namespace ScriptureMemorizer;
using System;

/*
    A Verse has a list of Words (_words) and a text string (_text). The _words List is populated by splitting _text
    into many Words. It also has an _isCompressed attribute that says whether the text of a range of Verses have been 
    compressed into one string by Compress().

    A Verse has a universal index (_index). It also has List of which indexes of  _words are not hidden 
    (_visibleIndexes). 
    
    When an element from _words is changed to a blank ("___"), _visibleIndexes removes the corresponding index of the
    newly hidden Word from its own List. Once every Word is hidden, and the Scripture class finds that _visibleIndexes
    is empty (via GetVisibleIndexes()), it changes its _continue bool to false to that Program knows to end.
*/

class Verse
{
    //                  Attributes:
    private List<Word> _words = new List<Word>();
    private string _text;
    private bool _isCompressed;
    private int _index;
    private List<int> _visibleIndexes = new List<int>();

    //                   Constructors:
    public Verse()
    {//Empty

    }

    public Verse(List<Word> _words)
    {//From words
        this._words = _words;
    }

    public Verse(string _text)
    {//From text string
        this._text = _text;
        PopulateLists(); //sets _words
    }

    public Verse(string _text, List<Word> _words)
    {//From both
        this._text = _text;
        this._words = _words;
    }


    //                   Getters and setters:
    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public bool GetIsCompressed()
    {
        return _isCompressed;
    }

    public void SetIsCompressed(bool isCompressed)
    {
        _isCompressed = isCompressed;
    }

    public List<int> GetVisibleIndexes()
    {
        return _visibleIndexes;
    }


    //                   Methods:
    public void PopulateLists()
    { // The _words List is filled out by splitting the text of the verse. _visibleIndexes is also populated.
        int indexValue = 0; // Initialize the indexValue.
        // Add Words from their _text by splitting each Word in the Verse's _text.
        foreach (string word in GetText().Split(" "))
        {
            if (word != "") // Don't include spaces that shouldn't be there so that they aren't made into Words.
            {
                _words.Add(new Word(word));
                _visibleIndexes.Add(indexValue);
                indexValue += 1; // The indexValue increases by 1 with each loop-through.
            }
        }
    }


    public void HideWords()
    { // Replaces the _text of a random Word in the Verse with a blank space.
        // This condition prevents the function from trying to hide a word after the _visibleIndexes list is empty.
        if (_visibleIndexes.Count > 0)
        {
            RandomizeIndex(); // Generate a random index
            _index = _visibleIndexes[_index]; // Using the randm index, pick an index from _visibleIndexes
            _words[_index].SetWordText("____"); // Replace the Word with a blank space
            _words[_index].SetIsHidden(true); // Word is now hidden
            _visibleIndexes.Remove(_index); // Remove the hidden Word's index from _visibleIndexes
        }

        if (_visibleIndexes.Count > 0)
        {
            RandomizeIndex();
            _index = _visibleIndexes[_index];
            _words[_index].SetWordText("____");
            _words[_index].SetIsHidden(true);
            _visibleIndexes.Remove(_index);
        }
    }

    public void BuildFromWords()
    { // Sets _text by getting the Word's _wordText attribute. This allows the Verse to be updated with blank spaces. 
        _text = ""; // Clear _text.
        foreach (Word word in _words)
        {
            _text += word.GetWordText(); // Get the _wordText of a Word.
            _text += " "; // Add a space after the Word.
        }
    }

    void RandomizeIndex()
    { // Sets _index to a random integer chosen from the _visibleIndexes List.
        int indexListLength = _visibleIndexes.Count; 
        Random randomGenerator = new Random();
        _index = randomGenerator.Next(0, indexListLength);
    }
}