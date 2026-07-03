class Fox : Animal
{
    //constructor
    public Fox(string name) : base(name)
    {
        
    }

    //overridden behavior
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says 'Ringa-dinga-dinga-dingeringerding!'");
    }
    
}