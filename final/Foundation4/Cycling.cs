namespace Exercise;
class Cycling : Activity{
    // Child Attributes
    double _speed;

    // Constructors
    public Cycling(string date, double lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        _speed = speed;
        _type = "Cycling";
    }

    // Child Methods
    public override double CalculateSpeedMph(double distance)
    {
        double speedMph = (distance / _lengthMinutes) * 60;
        return speedMph;
    }

    public override double CalculatePaceMpm(double distance)
    { //Minutes per pile
        double paceMpm = _lengthMinutes / distance;
    }

}