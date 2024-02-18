namespace ScriptureMemorizer;
using System;

/*
    A Word has a string (_wordText) and a bool (_isHidden) that indicates whether the _wordText has been set to a 
    blank space yet. It has no methods besides its getters and setters. 
    
    _isHidden ended up not having a purpose because my program checks for the length of the _visibleIndexes list in the Verse class instead of checking for _isHidden. But I left it so that this could still be a meaningful class.
    I guess it would still be without it.
*/

class Word
{
    //                  Attributes:
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