// have a speaker and have a limited capacity.

class Lecture : Event {
    // Child Attributes
    string _speaker;
    string _maxCapacity;

    // Constructor
    public Lecture() : base()
    {

    }

    public Lecture(string title, string description, string date, string time, string address,string speaker, string maxCapacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
        _type = "Lecture";
    }

    // Child Methods

    public string FullDetails()
    { //Lists standard details, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the we
        string message = $"{StandardDetails()}\n{_type}: {_speaker}\nMax Capacity: {_maxCapacity}";
        return message;
    }

}