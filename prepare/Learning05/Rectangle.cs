class Rectangle : Shape 
{
    private double _length;
    private double _width;



    public Rectangle(string _color, double _length, double _width) : base(_color)
    {
        this._color = _color;
        this._length = _length;
        this._width = _width;
    }

    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }

}