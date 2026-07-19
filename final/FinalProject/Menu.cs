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
            Console.WriteLine("2 - Load & Start Scenario");
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
            }

        }
    }
    private static void LoadScenario()
    {
        //ideally this would be set up to load multipule scenarios but for the sake of me not writing a save and load function for this project It's just going to load the one scenario.
        Map gameMap = new Map(20, 10, "MAP");
        Turn turnKeeper = new Turn(gameMap, true);
        Player player = new Player();
        gameMap.AddContent(player, [3, 7], gameMap);
        turnKeeper.AddCharacter(player);
        Skeleton skeleton1 = new Skeleton();
        gameMap.AddContent(skeleton1, [2, 2], gameMap);
        turnKeeper.AddCharacter(skeleton1);
        Skeleton skeleton2 = new Skeleton();
        gameMap.AddContent(skeleton2, [1, 7], gameMap);
        turnKeeper.AddCharacter(skeleton2);
        Skeleton skeleton3 = new Skeleton();
        gameMap.AddContent(skeleton3, [3, 4], gameMap);
        turnKeeper.AddCharacter(skeleton3);
        Zombie zombie1 = new Zombie();
        gameMap.AddContent(zombie1, [4, 3], gameMap);
        turnKeeper.AddCharacter(zombie1);
        Zombie zombie2 = new Zombie();
        gameMap.AddContent(zombie2, [20, 5], gameMap);
        turnKeeper.AddCharacter(zombie2);
        Sword sword = new Sword();
        gameMap.AddContent(sword, [2, 7], gameMap);
        Bow bow = new Bow();
        gameMap.AddContent(bow, [0, 7], gameMap);
        HealthPotion healthPotion = new HealthPotion();
        gameMap.AddContent(healthPotion, [7, 5], gameMap);
        turnKeeper.GameLoop(player);
    }

    public static void turnMenu(Player player, Turn turnKeeper)
    {
        bool inMenu = true;
        while (inMenu)
        {
            Console.WriteLine($"Health: {player.GetHealth()}");
            Console.WriteLine("Inventory: ");
            try
            {
                int itemNumber = 0;
                foreach (Item item in player.GetInventory())
                {
                    itemNumber ++;
                    Console.WriteLine($"{itemNumber} - {item.GetName()}");
                }
            }
            catch
            {
                Console.WriteLine("Empty Inventory");
            }
            Console.WriteLine($"Held: {player.GetHeld()}");
            Console.WriteLine("Options: ");
            Console.WriteLine("1 - Use Held");
            Console.WriteLine("2 - Move");
            Console.WriteLine("3 - Pick Up Items");
            Console.WriteLine("4 - Hold Item");
            Console.WriteLine("5 - Look Around You");
            Console.WriteLine("6 - Exit");
            Console.WriteLine("Type the corosponding option to select it: ");
            int selection = 0;
            try
            {
                selection = int.Parse(Console.ReadLine());
            }
            catch
            {
                
            }
            switch (selection)
            {
                case 1:
                    //use held
                    if (player.GetHeld() != null)
                    {
                        player.UseHeld();
                    }
                    inMenu = false;
                    break;
                case 2:
                    //move
                    Console.WriteLine("What Direction?");
                    Console.WriteLine("up/down/left/right");
                    string direction = Console.ReadLine();
                    try
                    {
                        switch (direction)
                        {
                            case "up":
                                player.Move(1,[0,1]);
                                break;
                            case "down":
                                player.Move(1,[0,-1]);
                                break;
                            case "left":
                                player.Move(1,[-1,0]);
                                break;
                            case "right":
                                player.Move(1,[1,0]);
                                break;
                        }
                        inMenu = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                    break;
                case 3:
                    //pickup items
                    player.PickUp();
                    inMenu = false;
                    break;
                case 4:
                    //hold;
                    Console.WriteLine("Type the Item number you wish to hold");
                    try
                    {
                        int itemSelection = int.Parse(Console.ReadLine());
                        player.SetHeld(itemSelection-1);
                        inMenu = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                    break;
                case 5:
                    List<GameObject> near = turnKeeper.getMap().GetWithinRange(1, player);
                    foreach (GameObject gameObject in near)
                    {
                        Console.WriteLine($"Object: {gameObject}");
                    }
                    Console.ReadLine();
                    inMenu = false;
                    break;
                case 6:
                    inMenu = false;
                    turnKeeper.SetLoop(false);
                    break;
            }

        }
    }
}