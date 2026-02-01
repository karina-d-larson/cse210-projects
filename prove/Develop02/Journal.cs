using System; 
using System.IO; 
using System.Collections.Generic;

public class Journal
{
    Dictionary<string, Entry> _entries = new Dictionary<string, Entry>();

    public void LoadFile(string filepath)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filepath);

        for (int i = 0; i < lines.Length; i += 4)
        {
            string date = lines[i];
            string prompt = lines[i + 1];
            string response = lines[i + 2];

            Entry entry = new Entry();
            entry._date = date;
            entry._prompt = prompt;
            entry._response = response;

            _entries.Add(date, entry);
        }
    }

    public void SaveFile(string filepath)
    {
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            foreach (Entry entry in _entries.Values)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._prompt);
                writer.WriteLine(entry._response);
                writer.WriteLine("===END-OF-ENTRY===");
            }
        }
    }

    public void Display()
    {
        foreach (Entry entry in _entries.Values)
        {
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._response);
            Console.WriteLine("------------------------");
        }
    }

    public void WriteEntry()
    {
        string today = DateTime.Today.ToString("MM-dd-yyyy");

        if (_entries.ContainsKey(today))
        {
            EditEntry(today); // pass today explicitly
        }
        else
        {
            // Create new entry
            Entry entry = new Entry();

            Console.WriteLine(entry._prompt);
            Console.Write("Response: ");
            entry._response = Console.ReadLine();

            _entries.Add(today, entry);
        }
    }

    public void EditEntry(string date)
    {
        if (_entries.ContainsKey(date))
        {
            Console.WriteLine(_entries[date]._prompt);
            Console.WriteLine("Existing entry:");
            Console.WriteLine(_entries[date]._response);

            Console.Write("Add to response: ");
            string newText = Console.ReadLine();
            _entries[date]._response += "   Added edit: " + newText;
        }
        else
        {
            Console.WriteLine("No entry found for that date. Creating a new one.");
            
            Entry entry = new Entry();
            entry._date = date;

            Console.WriteLine(entry._prompt);
            Console.Write("Response: ");
            entry._response = Console.ReadLine();

            _entries.Add(date, entry);
        }
    }


}