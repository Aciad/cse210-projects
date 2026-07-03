class Goal
{
    //attributes
    protected string _title;
    protected string _description;
    protected int _points;
    //constructor
    public Goal(string title = "defalut-title", string description = "default-description", int points = 0)
    {
        _title = title;
        _description = description;
        _points = points;
    }
    //methods
    public virtual void Display()
    {
        Console.WriteLine($"[Points:{_points}] - {_title} - {_description}: ");
    }
    public virtual string GetSaveString()
    {
        string saveString = $"{GetType().Name}|{_title}|{_description}|{_points}";

        return saveString;
    }
    public virtual int GetPoints()
    {
        return _points;
    }
    public virtual void AdvanceGoal(){}
}