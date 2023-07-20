using System;

public class Cycling : Event
{
    private double _speed;
    public Cycling(string date, double time, double speed) : base(date, time)
    {
        _speed = speed;
        
    }
    public override double  GetDistance()
    {
        double distance = _speed * _time / 60;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double _distance = GetDistance();
        double pace = _time / _distance;
        return pace;
    }


}