using System;

public abstract class Event
{
    public string _date;
    public double _time;

    public Event(string date, double time)
    {
        _date = date;
        _time = time;
    }

    public abstract double  GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public void GetSummery()
    {
        double _distance = Math.Round(GetDistance(), 2);
        double _speed =  Math.Round(GetSpeed(), 2);
        double _pace =  Math.Round(GetPace(), 2);

        Console.WriteLine($"{_date} {this.GetType().Name} ({_time} min): Distance: {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile");
    }

}
