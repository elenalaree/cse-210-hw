using System;

public class Lectures : Event
{
    private int _maxCapacity;
    private string _speaker; 

    public Lectures(string eventTitle, string description, string date, string time, Address address, int maxCapacity, string speaker) : base(eventTitle, description, date, time, address)
    {
        _maxCapacity = maxCapacity;
        _speaker = speaker;
    }

    public void FullDetails()
    {
        string _eventTitle = GetEventTitle();
        string _description = GetDescription();
        string _date = GetDate();
        string _time = GetTime();
        Address _address = GetAddress();
        string _venue = _address.ReturnString();
        Console.WriteLine($"Lecture Event: {_eventTitle}. {_description} To be held on {_date} from {_time}. \n   Location: {_venue} Attendance Limited to: {_maxCapacity}. The speaker will be {_speaker}.");

    }

    public void ShortDescription()
    {
        string _eventTitle = GetEventTitle();
        string _date = GetDate();
        Console.WriteLine($"Lecture Event: {_eventTitle} --- {_date}");

    }
    
    
    
    }