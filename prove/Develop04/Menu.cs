class Menu
{
    private List<Activity> _activityList;
    public Menu(List<Activity> activityList)
    {
        _activityList = activityList;
    }
    public void Run()
    {
        Console.Clear();
        bool menuLoop = true;
        while(menuLoop)
        {
            Console.Clear();
            Console.WriteLine("Please Select An Activity");
            int x = 1;
            int selection = 0;
            Console.WriteLine($"Type 0 to exit.");
            foreach (Activity activity in _activityList)
            {
                Console.WriteLine($"Type {x} to select {activity.GetName()}");
                x ++;
            }
            selection = int.Parse(Console.ReadLine());
            switch(selection)
            {
                case 0:
                    menuLoop = false;
                    break;
                case 1:
                    _activityList[0].Run();
                    break;
                case 2:
                    _activityList[1].Run();
                    break;
                case 3:
                    _activityList[2].Run();
                    break;
                case 4:
                    _activityList[3].Run();
                    break;

            }
        }
    }
}