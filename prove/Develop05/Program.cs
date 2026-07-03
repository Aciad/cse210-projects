using System;

class Program
{
    static void Main(string[] args)
    {
        // int totalPoints = 0;
        // List<Goal> myGoals = new List<Goal>();
        // myGoals.Add( new Goal("Default Goal", "Default Description", 50));
        // myGoals.Add( new SingleGoal("Single Goal", "Single Description", 50));
        // myGoals.Add( new PersistentGoal("Persistent Example", "Persistent Description", 50));
        // myGoals.Add( new RepeatedGoal("Repeated Goal", "Repeated Description", 50, false, 100, 5));
        // // Menu menu = new Menu(myGoals);
        // foreach (Goal goal in myGoals)
        // {
        //     // int totalPoints = 0;
        //     totalPoints += goal.GetPoints();
        //     goal.Display();
        // }
        // Console.WriteLine($"Printing total points {totalPoints}");
        // Console.WriteLine("repeated goal");
        // for (int i = 0; i < 4; i++)
        // {
            
        //     totalPoints += myGoals[3].GetPoints();
        //     Console.WriteLine($"Printing total points {totalPoints}");
        //     myGoals[3].Display();
        // }
        // Console.WriteLine("persistent goal");
        // for (int i = 0; i < 4; i++)
        // {
            
        //     totalPoints += myGoals[2].GetPoints();
        //     Console.WriteLine($"Printing total points {totalPoints}");
        // }
        // Console.WriteLine("single goal");
        // for (int i = 0; i < 4; i++)
        // {
            
        //     totalPoints += myGoals[1].GetPoints();
        //     Console.WriteLine($"Printing total points {totalPoints}");
        // }
        // Console.WriteLine("default goal");
        // for (int i = 0; i < 4; i++)
        // {
            
        //     totalPoints += myGoals[0].GetPoints();
        //     Console.WriteLine($"Printing total points {totalPoints}");
        // }


        // menu.MenuAccess();
        Menu menu = new Menu();
        menu.MenuAccess();
    }
}