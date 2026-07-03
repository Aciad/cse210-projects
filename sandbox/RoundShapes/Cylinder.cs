class Cylinder : Circle
{
    //attributes
    private double _height;
    public Cylinder(double r, double h) : base(r)
    {
        _height = h;
    }
    public override double Area()
    {
        return 2.0 * (Math.PI * _radius * _radius + Math.PI * _radius * _height);
    }
}