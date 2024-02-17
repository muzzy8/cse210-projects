namespace ScriptureMemorizer;
using System;

class Reference
{
    private string _referenceText;
    private bool _isRange; //null

    //                  Constructors:
    Reference()
    {//Empty

    }

    public Reference(string _referenceText)
    {//From text only
        
    }

    public Reference(string _referenceText, bool _isRange)
    {//Single or range
        this._referenceText = _referenceText;
        this._isRange = _isRange;
    }

    //                  Getters and setters:
    public string GetReferenceText()
    {
        return _referenceText;
    }

    public bool GetIsRange()
    {
        return _isRange;
    }

    //                  Methods:
    void CheckForRange()
    {//If this method finds a hypen, it sets _isRange to True

    }

}