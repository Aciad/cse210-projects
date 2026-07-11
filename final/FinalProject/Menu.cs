class Menu
{
    
    public static void StartMenu()
    {
        bool inMenu = true;
        while (inMenu)
        {
            int selection = 0;
            //intro
            Console.Clear();
            Console.WriteLine("WELCOME TO A WORLD OF TERROR(?)");
            Console.WriteLine("Please select an option from the following: ");
            Console.WriteLine("1 - Exit");
            Console.WriteLine("2 - Load Scenario");
            Console.WriteLine("3 - Start Scenario");
            //get selection
            while (true)
            {
                try
                {
                    selection = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("That was not a valid seleciton");
                }
            }
            //switch statements
            switch (selection)
            {
                case 1:
                    //exit
                    inMenu = false;
                    break;
                case 2: 
                    //load scenario
                    LoadScenario();
                    break;
                case 3:
                    //start scenario
                    
                    break;
            }

        }
    }
    private static void LoadScenario()
    {
        //ideally this would be set up to load multipule scenarios but for the sake of me not writing a save and load function for this project It's just going to load the one scenario.
        Map gameMap = new Map(10, 10, "MAP");
        Turn turnKeeper = new Turn(gameMap);
        Player player = new Player();
        gameMap.AddContent(player, [3, 7]);
        Skeleton skeleton1 = new Skeleton();
        gameMap.AddContent(skeleton1, [2, 2]);
        turnKeeper.GameLoop();
    }
}