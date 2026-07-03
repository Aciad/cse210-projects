class SingleGoal : Goal
{
    //attributes
    private bool _completed;
    //constructor
    public SingleGoal(string title = "defalut-title", string description = "default-description", int points = 0, bool completed = false) : base(title, description, points)
    {
        _completed = completed;
    }
    //functionality
    public override string GetSaveString()
    {
        string saveString = base.GetSaveString();
        saveString = saveString + $"|{_completed}";
        return saveString;
    }
    public override void Display()
    {
        string checkMark = " ";
        if (_completed)
        {
            checkMark = "X";
        }
        Console.WriteLine($"[Points:{_points}] - {_title} - {_description}: [{checkMark}]");
    }
    public override void AdvanceGoal()
    {
        _completed = true;
    }
    public override int GetPoints()
    {
        if (!_completed)
        {
            AdvanceGoal();
            return base.GetPoints();
        }
        else
        {
            return 0;
        }
    }
}