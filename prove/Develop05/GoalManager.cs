using System.Diagnostics;

public class GoalManager
{
    List<Goal> _goals = new();
    int _score;

    public GoalManager()
    {

    }
    List<string> menu = new List<string>
        {
            "Menu Options:",
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"
        };

    List<string> goal_menu = new List<string>
        {
            "Types of Goals are:",
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
        };
    public void Start()
    {
        string _allPoints = "You have {0} points.";
        Console.WriteLine(_allPoints, _score);
        Console.WriteLine();
        int userMenuInput = 0;
        while (userMenuInput != 6)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.WriteLine("Select a choice from the menu: ");
            userMenuInput = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (userMenuInput)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:

                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine(_score);
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goals are:");
        int count = 1;
        foreach (Goal goal_line in _goals)
        {
            Console.Write(count);
            goal_line.GetDetailsString();
            count++;
        }
    }
    public void CreateGoal()
    {
        foreach (string goal_option in goal_menu)
        {
            Console.WriteLine(goal_option);
        }
        Console.WriteLine("Select a choice from the menu: ");
        int userGoalInput = int.Parse(Console.ReadLine());
        switch (userGoalInput)
        {
            case 1:
                Console.WriteLine("What is the name of your goal? ");
                string _shortName = Console.ReadLine();
                Console.WriteLine("What is a short description of this goal? ");
                string _description = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth? ");
                string _points = Console.ReadLine();

                SimpleGoal _simpleGoal = new SimpleGoal(_shortName, _description, _points);
                _goals.Add(_simpleGoal);
                break;
            case 2:
                Console.WriteLine("What is the name of your goal? ");
                _shortName = Console.ReadLine();
                Console.WriteLine("What is a short description of this goal? ");
                _description = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth? ");
                _points = Console.ReadLine();
                EternalGoal _eternalGoal = new EternalGoal(_shortName, _description, _points);
                _goals.Add(_eternalGoal);
                break;
            case 3:
                Console.WriteLine("What is the name of your goal? ");
                _shortName = Console.ReadLine();
                Console.WriteLine("What is a short description of this goal? ");
                _description = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth? ");
                _points = Console.ReadLine();
                Console.WriteLine("What is your target number to complete? ");
                int _target = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points is the bonus goal worth? ");
                int _bonus = int.Parse(Console.ReadLine());
                ChecklistGoal _checklistGoal = new ChecklistGoal(_shortName, _description, _points, _target, _bonus);
                _goals.Add(_checklistGoal);
                break;
        }
    }
    public void RecordEvent()
    {
        ListGoalDetails();

        Console.WriteLine("Which Goal have you done?");
        int choice = int.Parse(Console.ReadLine());
        int _modChoice = choice - 1;
        
        _goals[_modChoice].RecordEvent();
        int _awarded = int.Parse(_goals[_modChoice]._points);
        _score += _awarded;
        string _goal = _goals[_modChoice].ToString();
        if( _goal == "ChecklistGoal"){
            if(_goals[_modChoice].IsComplete()){
                _score += _goals[_modChoice].GetBonus();
            }
        }
        string _allPoints = "You now have {0} points.";
        Thread.Sleep(5000);

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }
}