using System.Diagnostics;
class Timer
{
    public static void Spinner(int duration)
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
    public static void Counter(int duration)
    {
        var stopwatch = Stopwatch.StartNew();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write($"{stopwatch.Elapsed.TotalSeconds}");
        }
    }
}