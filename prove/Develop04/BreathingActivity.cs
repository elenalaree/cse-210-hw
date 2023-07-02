using System.Data;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        this.SetActivityName("Breathing Activity");
        this.SetDescription("This activity will help you relax.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int _interval = GetDuration() / 6;
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Breath in...");
            Console.WriteLine(_interval);
            ShowCountDown(_interval);
            Console.WriteLine("Breath out...");
            Console.WriteLine(_interval);
            ShowCountDown(_interval);
        }
    }
}