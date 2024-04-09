namespace Exercise;
class Swimming : Activity
{
    // Child Attributes
    double _laps;

    // Constructors
    public Swimming(string date, double lengthMinutes, double laps) : base(date, lengthMinutes)
    {
        _laps = laps;
        _type = Swimming;
    }

    // Child Methods
    public override double CalculateDistanceMiles()
    {
        double distanceMiles = _laps * 50 / 1000 * 0.62;
        return distanceMiles;
    }

}