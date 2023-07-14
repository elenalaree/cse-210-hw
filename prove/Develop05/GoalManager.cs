using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO; 

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

        int userMenuInput = 0;
        while (userMenuInput != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
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
                    ListGoalDetails();
                    Thread.Sleep(2000);
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("See you Next time!");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        string _allPoints = "You have {0} points.";
        Console.WriteLine(_allPoints, _score);
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
        Console.WriteLine();
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
            ChecklistGoal _checklistGoal = _goals[_modChoice] as ChecklistGoal;
            int addBonus = _checklistGoal.GetBonus();
            _score += addBonus;
        }
        Thread.Sleep(3000);

    }
    public void RecreateGoal(string goalType, string goal_line){
        string[] split = goal_line.Split(',');
        if(goalType == "SimpleGoal")
        {
            SimpleGoal _simpleGoal = new SimpleGoal(split[0], split[1], split[2]);
            if(split[3] == "True")
            {
                _simpleGoal.IsComplete();
            }
            _goals.Add(_simpleGoal);
        }
        else if(goalType == "EternalGoal")
        {
            EternalGoal _eternalGoal = new EternalGoal(split[0], split[1], split[2]);
            _goals.Add(_eternalGoal);
        }
        else if(goalType == "ChecklistGoal")
        {
            int bonus = int.Parse(split[3]);
            int target = int.Parse(split[4]);
            int complete = int.Parse(split[5]);

            ChecklistGoal _checklistGoal = new ChecklistGoal(split[0], split[1], split[2], target, bonus);
            _checklistGoal._amountComplete = complete;
            _goals.Add(_checklistGoal);
        }

    }
    public void SaveGoals()
    {
        string _goalFile = "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(_goalFile))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal_line in _goals)
            {
                outputFile.WriteLine(goal_line.GetStringRepresentation());
            }
        };

    }
    public void LoadGoals()
    {
        string _goalFile = "goals.txt";
        string[] lines = File.ReadAllLines(_goalFile);

        foreach (string line in lines)
        {
            string[] split = line.Split(':');
            if (split.Length > 1){
                RecreateGoal(split[0], split[1]);
            }
            else{
                _score = int.Parse(split[0]);
            }
            
        }
    }
}