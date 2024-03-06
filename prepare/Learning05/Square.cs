using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

class Square : Shape 
{
    private double _side;

    public Square(string _color, double _side) : base(_color)
    {
        this._color = _color;
        this._side = _side;
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }

}