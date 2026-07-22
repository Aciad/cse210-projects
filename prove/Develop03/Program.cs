using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the scripture memorizer");
        Console.WriteLine("Please enter the number of the scripture you would like to memorize (only 1 is implimented so please only write '1' '2' '3' or '4')");
        Console.Write("Enter your number: ");
        Scripture scripture = NewScripture(int.Parse(Console.ReadLine()));
        Console.WriteLine("To exit the memorizer press any key but enter");
        MemorizerLoop(scripture);
    }
    static public void MemorizerLoop(Scripture scripture)
    {
        while (true)
        {
            if (Console.ReadLine() != "")
            {
                break;
            }
            Console.Clear();
            if (!scripture.AnyUnhidden())
            {
                Console.WriteLine($"{scripture.GetDisplayString()}");
                scripture.ShowWords();
            }
            else
            {
                Console.WriteLine($"{scripture.GetDisplayString()}");
            scripture.HideAWord();
            }
        }
    }
    static public Scripture NewScripture(int scriptureNumber)
    {
        // string filePath = @"prove//Develop03//scriptures.csv";
        scriptureNumber --;
        string[] fileData = File.ReadLines("scriptures.csv").ToArray();
        List<string> lines = fileData.ToList();
        Scripture scripture = new Scripture(lines[scriptureNumber]);
        return scripture;
    }
}