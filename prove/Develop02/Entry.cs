using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace MyJournal;

class Entry
{
    string _response;
    string _prompt;
    string _date;
    string _rendered;

    public Entry()
    {

    }
    
    public Entry(string _response, string _prompt, string _date, string _rendered)
    {
        this._response = _response;
        this._prompt = _prompt;
        this._date = _date;
    }

    public void SetResponse(string response)
    {
        _response = response;
    }

    public string GetResponse()
    {
        return _response;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

   public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }

    public void SetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date = dateText;
    }

    public string GetDate()
    {
        return _date;
    }

    public void Make(string prompt)
    {   
        SetPrompt(prompt);
        Console.WriteLine(_prompt);
        string newResponse = Console.ReadLine();
        SetResponse(newResponse);
        SetDate();
        Render();
        Entry _entry = new Entry(_response, _prompt, _date, _rendered);
    }

    public void Render()
    {
        _rendered = $"{_date}\n{_prompt}\n\n{_response}\n\n---------------";
        // Give to Journal class
    }

    public string GetRendered()
    {
        return _rendered;
    }

    // public bool Serialize()
    // {
    //     // Adds delimiters?
    // }
}