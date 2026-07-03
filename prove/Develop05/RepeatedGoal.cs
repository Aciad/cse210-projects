class RepeatedGoal : Goal
{
    //attributes
    private int _maxCount;
    private int _currentCount;
    private bool _completed;
    private int _bonusPoints;
    //constructor
    public RepeatedGoal(string title = "defalut-title", string description = "default-description", int points = 0, bool completed = false, int currentCount = 0, int bonusPoints = 0, int maxCount = 1) : base(title, description, points)
    {
        _bonusPoints = bonusPoints;
        _maxCount = maxCount;
        _currentCount = currentCount;
    }
    public override string GetSaveString()
    {
        string saveString = base.GetSaveString();
        saveString = saveString + $"|{_completed}|{_currentCount}|{_maxCount}|{_bonusPoints}";
        return saveString;
    }
    public override void Display()
    {
        string checkMark = " ";
        if (_completed)
        {
            checkMark = "X";
        }
        Console.WriteLine($"[Points:{_points}] - {_title} - {_description} : [{_currentCount}/{_maxCount}] : [{checkMark}]");
    }
    public override int GetPoints()
    {
        AdvanceGoal();
        int points = 0;
        if (_currentCount == _maxCount)
        {
            points += _bonusPoints;
        }
        if (_currentCount <= _maxCount)
        {
            points += _points;
            return points;
        }
        else
        {
            return 0;
        }
        
    }
    public override void AdvanceGoal()
    {
        _currentCount ++;
        if (_currentCount >= _maxCount)
        {
            _completed = true;
        }
    }
}