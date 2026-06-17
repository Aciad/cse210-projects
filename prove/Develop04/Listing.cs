class Listing : Activity
{
    private List<string> _promptList;
    public Listing(int duration) : base(duration: duration)
    {
        _promptList = new List<string>{"example 1", "example 1", "example 1"};
        _name = "listing";
        _description = "";
        
    }
    private void Run()
    {
        
    }
    private string Prompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_promptList.Count);
        return _promptList[r];
    }

}