using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade as a percentage? ");
        string stringGrade = Console.ReadLine();
        int intGrade = int.Parse(stringGrade);
        string letterGrade = "N/A";
        if (intGrade >= 90)
            letterGrade = "A";
        else if (intGrade < 90 || intGrade >= 80)
            letterGrade = "B";
        else if (intGrade < 80 || intGrade >= 70)
            letterGrade = "C";
        else if (intGrade < 70 || intGrade >= 60)
            letterGrade = "D";
        else
            letterGrade = "F";
        
        char signGrade = intGrade.ToString()[1];
        int signGradeNum = int.Parse(signGrade.ToString());
        if (letterGrade != "A")
            if (signGradeNum >= 7)
                letterGrade = "+" + letterGrade;
            else if (signGradeNum < 3)
                letterGrade = "-" + letterGrade;

        Console.WriteLine($"Your grade is {letterGrade}");
        if (intGrade >= 70)
            Console.WriteLine("Congradulations, you have passed the class");
        else
            Console.WriteLine("YOU HAVE FAILED! FAILED! FAILED!");
        
    }
}