using System.Diagnostics;

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
        string sentence = ". [ ] {1}({2})";
        Console.WriteLine(sentence, _shortName, _description);
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}