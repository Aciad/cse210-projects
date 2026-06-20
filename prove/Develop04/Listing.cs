using System.Diagnostics;

class Listing : Activity
{
    private List<string> _promptList;
    public Listing() : base()
    {
        _promptList = new List<string>{
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };
        _name = "listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
    }
    public override void Run()
    {
        StartMessage();
        Console.Write("Get Ready . . . ");
        Timer.Spinner(5);
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("List as many responses to the following prompt as you can in the time limit:");
        Console.WriteLine();
        Console.WriteLine($"-- {Prompt()} --");
        var stopwatch = Stopwatch.StartNew();
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("");
            Console.Write("> ");
            Console.ReadLine();
        }
        EndMessage();
    }
    private string Prompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_promptList.Count);
        return _promptList[r];
    }

}