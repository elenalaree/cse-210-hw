using System;

public abstract class Goal
{
    public string _shortName;
    public string _description;
    public string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description; 
        _points = points;
    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract void GetDetailsString();

    public abstract string GetStringRepresentation();
}