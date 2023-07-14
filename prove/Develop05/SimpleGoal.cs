using System;

class SimpleGoal : Goal
{
    public bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        IsComplete();
        string congratz = "Congratz! You earned {0} points!";
        Console.WriteLine(congratz, _points);
    }

    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }

    public override void GetDetailsString()
    {
        string checkMe = " ";
        if (_isComplete)
        {
            checkMe = "x";
        }
        
        string sentence = ". [{0}] {1}({2})";
        Console.WriteLine(sentence, checkMe, _shortName, _description);
    }
    public override string GetStringRepresentation()
    {
        string _stringRep = string.Format("SimpleGoal:{0},{1},{2},{3}", _shortName, _description, _points, _isComplete);
        return _stringRep;
    }
}