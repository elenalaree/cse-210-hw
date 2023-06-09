using System;

public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string _file)
    {   
        List<string> records = new List<string>();
            foreach (Entry entry in entries)
            {
                string entryAsCSV = $"{entry.date} | {entry.promptText} | {entry.entryText} | {entry.mood}";
                records.Add(entryAsCSV);
            }

            File.WriteAllLines(_file, records);

    }



    public void LoadFromFile(string _file)
    {
        List<string> records = File.ReadAllLines(_file).ToList();
        foreach(string record in records)
        {
            string[] splitString = record.Split('|');
            Entry entry = new Entry(splitString[0], splitString[1], splitString[2], splitString[3]);

            entries.Add(entry);
        }
    }
}