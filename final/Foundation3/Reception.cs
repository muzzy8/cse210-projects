//require people to RSVP, or register, beforehand.

class Reception : Event {
    // Child Attributes
    private string _rsvpEmail;

    // Constructors
    public Reception() : base()
    {

    }

    public Reception(string title, string description, string date, string time, string address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
        _type = "Limited Reception";
    }

    // Child Methods
    public string FullDetails()
    { //Lists standard details, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the we
        string message = $"{StandardDetails()}\n{_type} -- RSVP to {_rsvpEmail}";
        return message;
    }
}