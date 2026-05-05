using System;

class Program
{
    static void GuessNumber(int magicNumber, ref bool done, ref int guesses)
    {
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        guesses ++;
        if(magicNumber == guess){
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"That took you {guesses} guesses!");
            done = false;}
        else if (magicNumber < guess){
            Console.WriteLine("Lower");
        }
        else if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
    }

    static void Game()
    {
        int guesses = 0;
        Console.Write("What is your magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        bool done = true;
        while (done)
        {
            GuessNumber(magicNumber, ref done, ref guesses);
        }

    }

    static void Main(string[] args)
    {
        bool go = false;
        do
        {
            Game();
            Console.WriteLine("Would you like to go again? (y/n) ");
            string goAgain = Console.ReadLine(); 
            
            if (goAgain == "yes" || goAgain == "Yes" || goAgain == "y" || goAgain == "Y")
            {
                go = true;
            }
            else
            {
                go = false;
            }
        }   while (go);
    }
}