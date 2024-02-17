namespace ScriptureMemorizer;
using System;

class Word
{
    private string _wordText;
    private bool _isHidden = false;

    //                  Constructors:
    public Word()
    {//Empty

    }

   public Word(string _wordText)
    {//Basic
        this._wordText = _wordText;
    }

    //                  Getters and setters:
    public string GetWordText()
    {
        return _wordText;
    }

    public void SetWordText(string wordText)
    {
        _wordText = wordText;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }
}