namespace Exercise;
class Running : Activity 
{
    // Child Attributes
    double _distance;

    // Constructors
    public Running(string date, double lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        _distance = distance;
        _type = "Running";
    }

    // Child Methods
    public override double CalculateDistanceMiles()
    {
        return _distance;
    }

}