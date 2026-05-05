using System;
using System.Collections.ObjectModel;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<int> List = new();
        ListMaker(List);
        Console.WriteLine($"The sum is: {ListSum(List)}");
        Console.WriteLine($"The average is: {ListAverage(List)}");
        Console.WriteLine($"The largest number is: {ListGreatestInt(List)}");
    }

    static void ListMaker(List<int> list)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true) {
            Console.Write("Enter a number: ");
            list.Add(int.Parse(Console.ReadLine()));
            if (list[^1] == 0)
            {
                break;
            }
        }
    }

    static int ListSum(List<int> list)
    {
        int sum = 0;
        foreach (int number in list)
        {
            sum += number;
        }
        return sum;
    }

    static double ListAverage(List<int> list)
    {
        int sum = ListSum(list);
        double average = sum / list.Count();
        return average;
    }

    static int ListGreatestInt(List<int> list)
    {
        int greatest = 0;
        foreach (int number in list)
        {
            if (greatest < number)
            {
                greatest = number;
            }
        }
        return greatest;
    }
}