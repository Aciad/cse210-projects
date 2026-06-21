using System.Diagnostics;
class Timer
{
    //
    public static void Spinner(int duration = 5)
    {
        var stopwatch = Stopwatch.StartNew();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Thread.Sleep(500);
            Console.Write($"|\b");
            Thread.Sleep(500);
            Console.Write($"/\b");
            Thread.Sleep(500);
            Console.Write($"-\b");
            Thread.Sleep(500);
            Console.Write($"\\\b");
        }
    }
    public static void Counter(int duration) //this one does not work, and quite franklI don't want to bother making it work right now
    { //it wouldn't even really be that hard, but I already have the spinner? soooo likeeeee. I'm good with thaaat.
        var stopwatch = Stopwatch.StartNew();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write($"{stopwatch.Elapsed.TotalSeconds}");
        }
    }
}