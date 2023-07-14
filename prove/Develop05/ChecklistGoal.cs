using System;

public class ChecklistGoal : Goal
{
    public int _amountComplete;
    private int _target;
    private int _bonus;
    private string fireworks = 
    """
                                   .''.            
       .''.      .        *''*    :_\/_:     .     
      :_\/_:   _\(/_  .:.*_\/_*   : /\ :  .'.:.'.  
  .''.: /\ :   ./)\   ':'* /\ * :  '..'.  -=:o:=-  
 :_\/_:'.:::.    ' *''*   *''*.\'/.' _\(/_'.':'.'  
 : /\ : :::::     *_\/_*     -= o =-  /)\      '  *  
  '..'  ':::'     * /\ *     .'/.\'.   '           
* ,'           *   *..*         :   *          *               
            *           *                  
""";
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        string congratz = "Congratz! You earned {0} points!";
        Console.WriteLine(congratz, _points);
        _amountComplete +=1;
        if(IsComplete())
        {
            string celebrate = "Wow! You did it! You earned {0} points!";
            Console.WriteLine(fireworks);
            Console.WriteLine(celebrate, _bonus);
        }
    }

    public int GetBonus(){
        if(_amountComplete == _target){
        return _bonus;
        }
        return 0;
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
        string _stringRep = string.Format("ChecklistGoal:{0},{1},{2},{3},{4},{5}", _shortName, _description, _points, _bonus, _target, _amountComplete);
        return _stringRep;
    }
}