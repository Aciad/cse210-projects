namespace Prac1;

class Program
{
    static void ProcessDeposit(List<int> history, ref int total)
    {
        history.Add(50);
        total += 50;
    }
    static void Main(string[] args)
    {
        List<int> myHistory = [50, 50];
        int myBalance = 100;

        ProcessDeposit(myHistory, ref myBalance);

        Console.WriteLine($"New balance: {myBalance}");
    }
}
