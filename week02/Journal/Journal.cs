
using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToCsvString());
            }
        }

        Console.WriteLine("Journal saved successfully.\n");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist.\n");
            return;
        }

        string[] lines = File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = ParseCsvLine(line);

            if (parts.Length >= 4)
            {
                Entry entry = new Entry();

                entry._date = parts[0];
                entry._mood = parts[1];
                entry._promptText = parts[2];
                entry._entryText = parts[3];

                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully.\n");
    }

    private string[] ParseCsvLine(string line)
    {
        line = line.Replace("\"", "");
        return line.Split(",");
    }

    public void SearchEntries(string keyword)
    {
        bool found = false;

        foreach (Entry entry in _entries)
        {
            if (entry._entryText.ToLower().Contains(keyword.ToLower()) ||
                entry._promptText.ToLower().Contains(keyword.ToLower()) ||
                entry._mood.ToLower().Contains(keyword.ToLower()))
            {
                entry.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching entries found\n");
        }
    }
}