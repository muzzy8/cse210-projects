class Circle : Shape 
{
    private double _radius;

    public Circle(string _color, double _radius) : base(_color)
    {
        this._color = _color;
        this._radius = _radius;
    }

    public override double GetArea()
    {
        double area = Math.Pow((Math.PI * _radius), 2);
        return area;
    }

}