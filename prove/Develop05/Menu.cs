using System.Text;

class Menu
{
    //attributes
    List<Goal> _goalList;
    int _points;
    
    //constructor
    public Menu()
    {
        _goalList = new List<Goal>();
        _points = 0;
        
    }
    public Goal GetGoalListMember(int index)
    {
        return _goalList[index];
    }
    public void MenuAccess()
    {
        bool inMenu = true;
        while (inMenu)
        {
            Console.Clear();
            Console.WriteLine("Current Goals: ");
            int y = 0;
            foreach (Goal goal in _goalList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                y ++;
                Console.Write($"Goal #{y}:");
                goal.Display();
                Console.ResetColor();
            }
            Console.WriteLine($"Points: {_points}");
            Console.WriteLine("Options:");
            int selection = 0;
            Console.WriteLine("Create a Goal - 1:");
            Console.WriteLine("Record an Event - 2:");
            Console.WriteLine("Save your Goals - 3:");
            Console.WriteLine("Load your Goals - 4:");
            Console.WriteLine("Exit - 5:");
            Console.Write("Please Type Your Choice: ");
            selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    //create Goal
                    CreateNewGoal();
                    break;
                case 2:
                    //Record Event
                    RecordEvent();
                    break;
                case 3:
                    //save goals
                    SaveGoals();
                    break;
                case 4:
                    //load goals
                    LoadGoals();
                    break;
                case 5:
                    //exit
                    inMenu = false;
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }
        }
    }
    private void CreateNewGoal()
    {
        bool inMenu = true;
        while (inMenu)
        {
            int selection = 0;
            Console.Clear();
            Console.WriteLine("Single Goal - 1:");
            Console.WriteLine("Persistent Goal - 2:");
            Console.WriteLine("Repeated Goal - 3:");
            
            Console.WriteLine("What type of goal would you like? (type the number):");
            selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                
                case 1:
                    //SingleGoal
                    string singleTitle;
                    string singleDescription;
                    int singlePoints;
                    Console.WriteLine("What is the name of the goal?:");
                    singleTitle = Console.ReadLine();
                    Console.WriteLine("What is the description of the Goal");
                    singleDescription = Console.ReadLine();
                    Console.WriteLine("What is the point value of the goal?");
                    singlePoints = int.Parse(Console.ReadLine());

                    _goalList.Add( new SingleGoal(
                        singleTitle, 
                        singleDescription, 
                        singlePoints
                        ));
                    inMenu = false;
                    break;
                case 2:
                    //PeristentGoal
                    string persistentTitle;
                    string persistentDescription;
                    int persistentPoints;
                    Console.WriteLine("What is the name of the goal?:");
                    persistentTitle = Console.ReadLine();
                    Console.WriteLine("What is the description of the Goal");
                    persistentDescription = Console.ReadLine();
                    Console.WriteLine("What is the point value of the goal?");
                    persistentPoints = int.Parse(Console.ReadLine());

                    _goalList.Add( new PersistentGoal(
                        persistentTitle, 
                        persistentDescription, 
                        persistentPoints
                        ));
                    inMenu = false;
                    break;
                case 3:
                    //RepeatedGoal
                    string repeatedTitle;
                    string repeatedDescription;
                    int repeatedPoints;
                    int repeatedMaxCount;
                    int repeatedBonusPoints;
                    Console.WriteLine("What is the name of the goal?:");
                    repeatedTitle = Console.ReadLine();
                    Console.WriteLine("What is the description of the Goal");
                    repeatedDescription = Console.ReadLine();
                    Console.WriteLine("What is the point value of the goal?");
                    repeatedPoints = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many times will the goal be performed?");
                    repeatedMaxCount = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus point value of the goal?");
                    repeatedBonusPoints = int.Parse(Console.ReadLine());

                    _goalList.Add( new RepeatedGoal(
                        repeatedTitle, 
                        repeatedDescription, 
                        repeatedPoints,
                        false,
                        0,
                        repeatedBonusPoints,
                        repeatedMaxCount
                        ));
                    inMenu = false;
                    break;
            }
        }
    }
    private void RecordEvent()
    {
        while (true)
        {
            int selectedGoal;
            Console.WriteLine("What is the the goal #?:");
            selectedGoal = int.Parse(Console.ReadLine());
            selectedGoal --;
            try
            {
                _points += _goalList[selectedGoal].GetPoints();
                Console.WriteLine("Activity Complete!");
                break;
            }
            catch
            {
                Console.WriteLine("Invalid Goal");
                break;
            }
        }
    }
    private void SaveGoals()
    {
        // List<string> saveStrings = new List<string>();
        // foreach (Goal goal in _goalList)
        // {
        //     saveStrings.Add(goal.GetSaveString());
        // }

        string filePath = "goalsCSV.csv";
        var csvBuilder = new StringBuilder();

        // Add header row
        string[] headers = { "Type", "Title", "Description", "Points", "Completed", "CurrentCount", "MaxCount", "BonusPoints" };
        csvBuilder.AppendLine(string.Join("|", headers));
        string[] points = { "Points", $"{_points}"};
        csvBuilder.AppendLine(string.Join("|", points));

        // Add data rows
        foreach (Goal goal in _goalList) {
            csvBuilder.AppendLine(goal.GetSaveString());
        }
        File.WriteAllText(filePath, csvBuilder.ToString());
    }
    private void LoadGoals()
    {
        _goalList.Clear();
        // List<Goal> goalList = new List<Goal>();
        string path = "goalsCSV.csv";
        // string[] lines = File.ReadAllLines(path);
        foreach (string line in File.ReadAllLines(path))
        {
            
            string[] csValues = line.Split("|");
            switch (csValues[0])
            {
                case "Goal":
                    _goalList.Add( new Goal(csValues[1], csValues[2], int.Parse(csValues[3])));
                    break;
                case "SingleGoal":
                    _goalList.Add( new SingleGoal(
                        csValues[1], 
                        csValues[2], 
                        int.Parse(csValues[3]),
                        bool.Parse(csValues[4])
                        ));
                    break;
                case "PersistentGoal":
                    _goalList.Add( new PersistentGoal(
                        csValues[1], 
                        csValues[2], 
                        int.Parse(csValues[3])
                        ));
                    break;
                case "RepeatedGoal":
                    _goalList.Add( new RepeatedGoal(
                        csValues[1], 
                        csValues[2], 
                        int.Parse(csValues[3]),
                        bool.Parse(csValues[4]),
                        int.Parse(csValues[5]),
                        int.Parse(csValues[6]),
                        int.Parse(csValues[7])
                        ));
                    break;
                case "points":
                    _points = int.Parse(csValues[1]);
                    break;
                default:
                    break;
            }
        }
    }
}