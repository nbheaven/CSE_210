class Circle
{
    private double _radius;

    public Circle(double radius = 0.0)
    {
        _radius = radius;
    }
    
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetDiameter()
    {
        return _radius * 2;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetCircumference()
    {
        return (_radius * 2) / 2 * Math.PI;
    }
}