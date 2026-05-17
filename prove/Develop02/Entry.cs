using System.Runtime.InteropServices.Swift;
using System.Security.Cryptography.X509Certificates;

class Entry
{
    
    //attribute
    public string _date;
    public string _response;
    public string _prompt;

    public Entry(string Date, string Prompt, string Response)
    {
        _date = Date;
        _prompt = Prompt;
        _response = Response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
    }

    public List<string> GetEntryList()
    {
        List<string> EntryData = [_date, _prompt, _response];
        return EntryData;
    }
    public string GetEntryStringCommaSeperated()
    {
        string EntryData = _date += _prompt += _response;
        return EntryData;
    }
}