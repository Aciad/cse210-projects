class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name = "N/A", string description = "N/A", int duration = 0)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    protected void StartMessage()
    {
        
    }
    protected void EndMessage()
    {
        
    }
}