using System.Diagnostics;

class BodyScan : Activity
{
    List<string> _bodyParts;
    public BodyScan() : base()
    {
        _bodyParts = new List<string>{
        "head",
        "feet",
        "toes",
        "ears",
        "fingers",
        "arms"
        };
        _name = "Body Scan";
        _description = "This activity will help you become mindful by walking you through each part of your body. (minimum durration of 5 seconds)";
    }

    public override void Run()
    {
        StartMessage();
        Console.WriteLine("Get into a comfortable position and breathe deeply while following the instructions");
        Console.WriteLine();
        Console.Write("Get Ready . . . ");
        Timer.Spinner(5);
        Console.Clear();
        var stopwatch = Stopwatch.StartNew();
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write($"\nFeel your {BodyPart()} . . .");
            Timer.Spinner();
        }
        EndMessage();
    }
    private string BodyPart()
    {
        Random rnd = new Random();
        int r = rnd.Next(_bodyParts.Count);
        return _bodyParts[r];
    }
}