using System;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }
    public override void RecordEvent()
    {
    
    }

    public override bool IsComplete()
    {
        return false;
    }

        public override void GetDetailsString()
    {  
        string sentence = ". [ ] {0}({1})";
        Console.WriteLine(sentence, _shortName, _description);
    }

    public override string GetStringRepresentation()
    {
        string _stringRep = string.Format("EternalGoal:{0},{1},{2}", _shortName, _description, _points);
        return _stringRep;
    }
}