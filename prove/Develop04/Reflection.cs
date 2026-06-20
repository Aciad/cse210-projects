using System.Diagnostics;
class Reflection : Activity
{
    //attributes
    private List<string> _questionList;
    private List<string> _promptList;
    //constructor
    public Reflection() : base ()
    {
        _promptList = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
        _questionList = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _timed = false;
    }
    //behavior
    public override void Run()
    {
        StartMessage();
        Console.Write("Get Ready . . . ");
        Timer.Spinner(5);
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"-- {Prompt()} --");
        Console.WriteLine();
        Timer.Spinner(5);
        Console.WriteLine("When you have something in mind press enter to continue");
        Console.ReadLine();
        EndMessage();
    }
    private string Prompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_promptList.Count);
        return _promptList[r];
    }
    private string Question()
    {
        Random rnd = new Random();
        int r = rnd.Next(_questionList.Count);
        return _questionList[r];
    }
}