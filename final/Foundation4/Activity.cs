namespace Exercise;
public class Activity
{
    // Attributes
    string _date;
    double _lengthMinutes;
    protected string _type;

    // Constructors
    public Activity(string date, double lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    // Methods
    public virtual double CalculateDistanceMiles()
    {
        
    }

    public virtual double CalculateSpeedMph()
    {
        double speedMph = (CalculateDistanceMiles() / _lengthMinutes) * 60;
        return speedMph;
    }

    public virtual double CalculatePaceMpm()
    { //Minutes per pile
        double paceMpm = _lengthMinutes / CalculateDistanceMiles();
    }

    public string GetSummary()
    {
        string summary = $"{_date} {_type} ({_lengthMinutes} min) - Distance: {CalculateDistanceMiles()} miles, Speed: {CalculateSpeedMph()}mph, Pace: {CalculatePaceMpm()} min per mile";
        return summary;
    }
}