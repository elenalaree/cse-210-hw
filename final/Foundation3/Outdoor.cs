using System;

class Outdoor : Event
{
    private string _weather;

    public Outdoor(string eventTitle, string description, string date, string time, Address address, string weather)  : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public void FullDetails()
    {
        string _eventTitle = GetEventTitle();
        string _description = GetDescription();
        string _date = GetDate();
        string _time = GetTime();
        Address _address = GetAddress();
        string _venue = _address.ReturnString();

        Console.WriteLine($"Outdoor Event: {_eventTitle}. {_description} To be held on {_date} from {_time}. \n   Location: {_venue}. Forecast: {_weather}");

    }

    public void ShortDescription()
    {
        string _eventTitle = GetEventTitle();
        string _date = GetDate();
        Console.WriteLine($"Outdoor Event: {_eventTitle} --- {_date}");

    }

    }