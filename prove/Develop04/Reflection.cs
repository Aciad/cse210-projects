
class Reflection : Activity
{
    private List<string> _questionList;
    private List<string> _promptList;
    public Reflection(int duration) : base (duration: duration)
    {
        _questionList = new List<string>{"example 1", "example 1", "example 1"};
        _promptList = new List<string>{"example 1", "example 1", "example 1"};
        _name = "Reflection";
        _description = "";
    }
    public void Run()
    {
        
    }
    private string Prompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_promptList.Count);
        return _promptList[r];
    }
    private string Question()
    {
        Random rnd = new Random();
        int r = rnd.Next(_questionList.Count);
        return _questionList[r];
    }
}