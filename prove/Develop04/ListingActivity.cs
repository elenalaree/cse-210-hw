
using System.Diagnostics;

class ListingActivity : Activity
{
    Random random= new Random();
    List<string> prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int count;
    public ListingActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int interval = GetDuration() - 5;
        Console.WriteLine("Type as many answers as you can from the following prompt.");
        GetListFromUser(interval);
        Console.WriteLine($"You listed {count} things.");
        Thread.Sleep(5000);
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        Console.WriteLine(prompt);
        
    }

    public void GetListFromUser(int interval_timer)
    {
        List<string> answers = new List<string>();
        Console.WriteLine("");
        GetRandomPrompt();
        ShowCountDown(5);
        Console.WriteLine("");
        int interval = interval_timer;
        Stopwatch stopwatch = Stopwatch.StartNew();
        stopwatch.Start();
        while (stopwatch.ElapsedMilliseconds / 1000 < interval)
        {
            Console.Write(">");
            string answer = Console.ReadLine();
            answers.Add(answer);
            
        }
        count = answers.Count;
    }
}