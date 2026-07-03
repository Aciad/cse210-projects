class Animal
{
    //attribtues
    protected string _name;

    //constructor
    public Animal(string name)
    {
        _name = name;
    }
    public virtual void MakeNoise()
    {
        Console.WriteLine($"{_name} says the same thing every animal says");
    }
}