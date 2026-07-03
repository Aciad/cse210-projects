class Cat : Animal
{
    //constructor
    public Cat(string name) : base(name)
    {
        
    }

    //overridden behavior
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says 'I hate Mondays'");
    }
    
}