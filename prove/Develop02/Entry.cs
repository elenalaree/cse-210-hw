
using System;

public class Entry{
    public string date;
    public string promptText;
    public string entryText;
    public string mood;

    public Entry(string _date, string _promptText, string _entryText, string _mood)
    {
        date        = _date;
        promptText  = _promptText;
        entryText   = _entryText;
        mood        = _mood;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {promptText} - Mood: {mood}");
        Console.WriteLine(entryText);
    }
}