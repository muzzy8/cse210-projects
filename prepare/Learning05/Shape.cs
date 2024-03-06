class Shape
{
    protected string _color = "";
    
    public Shape(string _color)
    {
       this._color = _color;
    }

    public string GetColor()
    {
        return _color;
    }

    void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        double area = 0;
        return area;
    }
}