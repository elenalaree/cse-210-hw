using System.Diagnostics;

public class Activity
{
    private string _description, _name;

    static int _spinnerCounter, _duration;

    public Activity()
    {
        _spinnerCounter = _duration = 0;
    }

    public void SetActivityName(string _activityName)
    {
        _name = _activityName;
    }

    public void SetDescription(string _descrip)
    {
        _description = _descrip;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, do you want your session?");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int _numSecondsToRun)
    {
        Stopwatch _stopwatch = Stopwatch.StartNew();
        _stopwatch.Start();

        while (_stopwatch.ElapsedMilliseconds / 1000 < _numSecondsToRun)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write(" ");
    }

    public void ShowCountDown(int _numSecondsToRun)
    {
        for(int i = _numSecondsToRun; i >= 1; i--)
        {
            Console.Write(string.Format("{0}", i));
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(1000);
        }
        Console.Write(" ");
    }
}