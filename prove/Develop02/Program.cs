using System;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Journal CurrentJournal = null; 
        bool InMenu = true;
        Console.WriteLine("Welcome to the journal writer!");
        while (InMenu)
        {
            int selection = 0;
            Console.WriteLine();
            Console.WriteLine("Your Menu Options are: ");
            Console.WriteLine($"1 - Load a journal.");
            Console.WriteLine($"2 - Write a new journal.");
            if (CurrentJournal != null)
            {
                Console.WriteLine($"3 - Save the current journal.");
                Console.WriteLine($"4 - Write a journal entry.");
                Console.WriteLine($"5 - Read all the entries.");
            }
            Console.WriteLine($"6 - Quit.");
            Console.Write($"Enter the only number of your selection: ");
            selection = int.Parse(Console.ReadLine());
            try
            {
                switch (selection)
                {
                    case 1:
                        CurrentJournal = LoadJournal();
                        break;
                    case 2:
                        CurrentJournal = NewJournal();
                        break;
                    case 3:
                        CurrentJournal.save();
                        break;
                    case 4:
                        CurrentJournal.AddEntry();
                        break;
                    case 5:
                        CurrentJournal.DisplayEntries();
                        break;
                    case 6:
                        InMenu = false;
                        break;
                }
            }
            catch
            {
                
            }
        }
    }

    public static Journal NewJournal()
    {
        Console.Write("What is the name of the Journal?: ");
        string JournalName = Console.ReadLine();
        while (true)
        {
            Console.Write("What is the file path of the new Journal? (ending with .txt): ");
            string FilePath = Console.ReadLine();
            FilePath = "Journals/" + FilePath;
            if (Path.Exists(FilePath))
            {
                Console.WriteLine("That File path already exists, please write a new file path");
            }
            else
            {
                List<Entry> Entries = new List<Entry>();
                Journal journal = new Journal(Entries,FilePath,JournalName);
                return journal;
            }
        }
    }
    public static Journal LoadJournal()
    {
        Console.Write("What is the name of the file?: ");
        string FilePath = "Journals/" + Console.ReadLine();
        try
        {
            string JournalName = File.ReadLines($"{FilePath}").First();
            string[] lines = File.ReadLines($"{FilePath}").Skip(1).ToArray();
            List<Entry> entries = new List<Entry>();
            foreach (string line in lines)
            {
                string[] values = line.Split(",");
                Entry entry = new Entry(values[0], values[1], values[2]);
                entries.Add(entry);
            }
            Journal journal = new Journal(entries,FilePath,JournalName);
            return journal;
        }
        catch
        {
            Console.WriteLine("Invalid File Path");
            return null;
        }
    }
}