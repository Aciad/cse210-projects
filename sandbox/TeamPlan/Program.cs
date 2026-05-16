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
        if (Exists(__Filepath))
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
            File.Create(__Filepath);
        }
    }
}

class Entry
{
    public string __Date;
    public string __Prompt;
    public string __Response;
    public Entry(string date, string prompt, string response)
    {
        __Date = date;
        __Prompt = prompt;
        __Response = response;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {__Date}");
        Console.WriteLine($"Prompt: {__Prompt}");
        Console.WriteLine($"{__Response}");
    }
}
