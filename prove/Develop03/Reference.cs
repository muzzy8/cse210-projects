namespace ScriptureMemorizer;
using System;

/*
    A Reference has a string (_referenceText) and a bool (_isRange) that shows whether or not the Reference refers to
    a range of Verses. This class needs no methods outside of the two getters.

    Only one of its constructors are being used but I kept them all for fun.
*/

class Reference
{
    //                  Attributes:
    private string _referenceText;
    private bool _isRange;

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
}