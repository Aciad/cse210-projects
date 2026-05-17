namespace TeamPlan;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    static void Load()
    {
        
    }

}

class Journal
{
    public string __Filepath;
    List<Entry> __Entries = new List<Entry>();
    public Journal(string FilePath) {
        __Filepath = FilePath;
    }
    public void AddEntry()
    {
        
    }
    public void DisplayEntries()
    {
        
    }
    public void Save()
    {
        if (Exists(_Filepath))
        {
            foreach (var entry in __Entries)
            {
                // AppendText(entry.__Date);
                // AppendText(entry.__Prompt);
                // AppendText(entry.__Response);
            }
        }
        else
        {
            File.Create(_Filepath);
        }
    }
}

class Entry
{
    public string _Date;
    public string _Prompt;
    public string _Response;
    public Entry(string date, string prompt, string response)
    {
        _Date = date;
        _Prompt = prompt;
        _Response = response;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_Date}");
        Console.WriteLine($"Prompt: {_Prompt}");
        Console.WriteLine($"{_Response}");
    }
}
