class Dog : Animal
{
    //constructor
    public Dog(string name) : base(name)
    {
        
    }

    //overridden behavior
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says 'bark'");
    }
    
}