class Circle : RoundShape
{
    //attributes
    protected double _radius;
    //behaviors
    public Circle(double r)
    {
        _radius = r;
    }
    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }
}