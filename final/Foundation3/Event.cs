// along with derived classes for each type of event
// These classes should contain the necessary data and provide methods to return strings for each of the messages the company desires.

// Remember that any data or methods that are common among all types of events should be in the base class.


// They would like the ability to generae three different messages:

//Standard details - Lists the title, description, date, time, and address.

//Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.

//Short description - Lists the type of event, title, and the date.

public class Event{
    // Attributes
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _type;

    // Constructors
    public Event()
    {

    }

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Methods
    public string StandardDetails()
    { // Lists the title, description, date, time, and address.
        string message = $"\n-- {_title} --\n\n{_description}\n\n{_date}, {_time}\n{_address}";
        return message;
    }

    public string ShortDescription()
    { // Lists the type of event, title, and the date.
        string message = $"{_type}   {_title}   {_date}";
        return message;
    }


}