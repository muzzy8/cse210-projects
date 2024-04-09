// which do not have a limit on attendees, but need to track the weather forecast.
class Outdoor : Event {
    // Child Attributes
    private string _weather;

    // Constructors
    public Outdoor() : base()
    {

    }

    public Outdoor(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
        _type = "Outdoor";
    }

    // Child Methods
    public string FullDetails()
    { //Lists standard details, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the we
        string message = $"{StandardDetails()}\n{_type}: {_weather}";
        return message;
    }
}