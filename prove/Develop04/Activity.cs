class Activity
{
    //attributes
    protected string _name;
    protected string _description;
    protected int _duration;
    protected bool _timed;
    //constructor
    public Activity(string name = "N/A", string description = "N/A", int duration = 0, bool timed = true)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _timed = timed;
    }
    //setters
    public string GetName()
    {
        return _name;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    //functionality
    public virtual void Run()
    {
        StartMessage();

        EndMessage();
    }

    protected void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        if (_timed)
        {
            Console.WriteLine($"How long in seconds would you like your session to be?:");
            this.SetDuration(int.Parse(Console.ReadLine()));
        }

    }
    protected void EndMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine($"You Completed {_duration} seconds of the {_name} activity.");
        Timer.Spinner(5);
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }
}