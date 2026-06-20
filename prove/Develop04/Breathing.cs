using System.Diagnostics;

class Breathing : Activity
{
    public Breathing() : base()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. (minimum durration of 10 seconds)";
    }
    public override void Run()
    {
        StartMessage();
        Console.Write("Get Ready . . . ");
        Timer.Spinner(5);
        Console.Clear();
        var stopwatch = Stopwatch.StartNew();
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("\nBreathe in . . .");
            Timer.Spinner(5);
            Console.Write("\nBreathe out . . .");
            Timer.Spinner(5);
            Console.WriteLine();
        }
        EndMessage();
    }
}