using System.Collections.Generic;
using System;


class ReflectingActivity : Activity
{
    Random random= new Random();
    List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
};
    List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity()
    {
        this.SetActivityName("Reflecting Activity");
        this.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        int interval = GetDuration() / 6;
        ShowCountDown(interval);
        for (int i = 0; i <= 2; i++)
        {
            DisplayQuestion();
            ShowSpinner(interval);
        }
    }

    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        int index = random.Next(_questions.Count); 
        string question = _questions[index];
        return question;
    }

    public void DisplayPrompt()
    {
        string promptMe = GetRandomPrompt();
        Console.WriteLine(promptMe);
    }

    public void DisplayQuestion()
    {
        List<string> used = new List<string>();
        string questMe = GetRandomQuestion();
        bool usedBox = used.Contains(questMe);
        if (usedBox == false){
            
        Console.WriteLine(questMe);

        }

    }
}