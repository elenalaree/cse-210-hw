using System;

public class Swimming : Event
{
    private double _laps;
    public Swimming(string date, double time, double laps): base(date, time)
    {
        _laps = laps;
    }
    public override  double  GetDistance()
    {
        double _distance =( _laps * 50 ) / 1760;
        return _distance;
    }

    public override double GetSpeed()
    {
        double _distance = GetDistance();
        double _speed = (_distance / _time ) * 60;
        return _speed;
    }

    public override double GetPace()
    {
        double _pace = GetSpeed();
        return _pace;
    }


}