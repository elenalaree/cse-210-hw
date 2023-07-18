using System;

class Receptions : Event
{
    private string _rsvp;

    public Receptions(string eventTitle, string description, string date, string time, Address address, string rsvp)  : base(eventTitle, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public void FullDetails()
    {
        string _eventTitle = GetEventTitle();
        string _description = GetDescription();
        string _date = GetDate();
        string _time = GetTime();
        Address _address = GetAddress();
    string _venue = _address.ReturnString();

        Console.WriteLine($"Reception Event: {_eventTitle}. {_description} To be held on {_date} from {_time}. \n   Location: {_venue} Please rsvp to: {_rsvp}");
    }

    public void ShortDescription()
    {
        string _eventTitle = GetEventTitle();
        string _date = GetDate();
        Console.WriteLine($"Reception Event: {_eventTitle} --- {_date}");

    }
    
    }