using System.Diagnostics;

public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {

        _amountComplete +=1;
    }
    public int GetBonus(){
        return _bonus;
    }
    public override bool IsComplete()
    {
        if (_amountComplete == _target){
            return true;
        }
        return false;
    }

    public override void GetDetailsString()
    {
            string checkMe = " ";
        if (IsComplete())
        {
            checkMe = "x";
        }
        string sentence = ". [{0}] {1}({2}) -- Currently completed {3}/{4}";
        Console.WriteLine(sentence, checkMe, _shortName, _description, _amountComplete, _target);
    }

    public override  string GetStringRepresentation()
    {
        return "";
    }
}