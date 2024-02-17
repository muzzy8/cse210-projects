namespace ScriptureMemorizer;
using System;

class Verse
{
    private List<Word> _words = new List<Word>();
    private string _text;
    private int _index;
    // private int _wordsLeft;
    private List<int> _visibleIndexes = new List<int>();
    private bool _isCompressed;
    private Program _program;

    //              Constructors:
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
        PopulateList(); //sets _words
    }

    public Verse(string _text, List<Word> _words)
    {//From both
        this._text = _text;
        this._words = _words;
    }


    //              Getters and setters:
    
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

    public int GetWordsLeft()
    {
        return _wordsLeft;
    }



    //              Methods:
    public void PopulateList()
    {
        foreach (string word in GetText().Split(" "))
            {
                _words.Add(new Word(word));
            }
    }

    void RandomizeIndex()
    { //Can set _index
        int wordListLength = _words.Count;
        // _wordsLeft = wordListLength;
        Random randomGenerator = new Random();
        _index = randomGenerator.Next(0, wordListLength);
        // _scripture = _scriptures[randomIndex];
    }

    public void HideWord() //or words
    {
        do {
            RandomizeIndex();
        } while (_words[_index].GetIsHidden() == true);

        _words[_index].SetWordText("____");
        _words[_index].SetIsHidden(true);

        RandomizeIndex();
        _words[_index].SetWordText("____");
        _words[_index].SetIsHidden(true);

        // _wordsLeft -= 2;
    }

    public void BuildFromWords()
    {
        _text = "";
        foreach (Word word in _words)
        {
            _text += word.GetWordText();
            _text += " ";
        }
    }

    void InitializeVisibleIndexes()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            _visibleIndexes.Add(i);
        }
    }

    // public void CheckWordsLeft()
    // {
    //     if (_wordsLeft == 0)
    //     {
    //         _program.SetRun(false);
    //     }
    // }



}