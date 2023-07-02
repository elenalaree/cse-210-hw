
using System.Diagnostics;

class ListingActivity : Activity
{
    Random _random= new Random();
    List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _count;
    public ListingActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int _interval = GetDuration() - 5;
        Console.WriteLine("Type as many answers as you can from the following prompt.");
        GetListFromUser(_interval);
        Console.WriteLine($"You listed {_count} things.");
        Thread.Sleep(5000);
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        int _index = _random.Next(_prompts.Count);
        string _prompt = _prompts[_index];
        Console.WriteLine(_prompt);
        
    }

    public void GetListFromUser(int _interval_timer)
    {
        List<string> _answers = new List<string>();
        Console.WriteLine("");
        GetRandomPrompt();
        ShowCountDown(5);
        Console.WriteLine("");
        int _interval = _interval_timer;
        Stopwatch _stopwatch = Stopwatch.StartNew();
        _stopwatch.Start();
        while (_stopwatch.ElapsedMilliseconds / 1000 < _interval)
        {
            Console.Write(">");
            string _answer = Console.ReadLine();
            _answers.Add(_answer);
            
        }
        _count = _answers.Count;
    }
}