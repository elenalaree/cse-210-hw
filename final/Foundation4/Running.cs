using System;

public class Running : Event
{
    private double _distance;
    public Running(string date, double time, double distance): base(date, time)
    
    {
        _distance = distance;

    }
    public override double  GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (_distance / _time) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = (_time / _distance);
        return pace;
    }

}