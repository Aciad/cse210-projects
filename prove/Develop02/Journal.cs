

using System.Runtime.InteropServices.Swift;
using System;
using System.IO;
using System.Text;

class Journal
{
    //attributes
    public List<Entry> _Entries = new List<Entry>();
    public string _FilePath;
    public string _JournalName;

    public Journal(List<Entry> Entries, string FilePath, string JournalName)
    {
        _Entries = Entries;
        _FilePath = FilePath;
        _JournalName = JournalName;

    }
    //behaviors
    public void AddEntry()
    {
        Console.Write($"What is the current date? ");
        string date = Console.ReadLine();
        Console.Write($"What is the prompt for this journal entry?");
        string prompt = Console.ReadLine();
        Console.Write($"Write your journal entry: ");
        string response = Console.ReadLine();
        Entry entry = new Entry(date,prompt,response);
        _Entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _Entries)
        {
            foreach (string item in entry.GetEntryList())
            {
                Console.WriteLine($"{item}");
            }
        }
    }
    public void save()
    {
        var data = new List<string>();

        foreach (Entry entry in _Entries)
        {
            string EntryData = entry._date + "," + entry._prompt + "," + entry._response;
            data.Add(EntryData);
        }
        
        if (!File.Exists(_FilePath))
        {
            data.Insert(0,_JournalName);
            File.WriteAllLines(_FilePath, data, Encoding.UTF8);
        }
    }
}