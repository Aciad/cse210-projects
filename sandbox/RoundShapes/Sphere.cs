class Sphere : Circle
{
    //behaviors
    public Sphere(double r) : base(r)
    {
        
    }
    public override double Area()
    {
        return 4.0 * (Math.PI * _radius * _radius);
    }
}