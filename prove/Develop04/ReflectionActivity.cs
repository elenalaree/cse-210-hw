using System.IO;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using Microsoft.VisualBasic;

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

    List<string> _usedQuestions = new();
    List<string> _usedPrompts = new();
    public ReflectingActivity()
    {
        this.SetActivityName("Reflecting Activity");
        this.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        LoadFromFile("questions.csv", _usedQuestions);
        LoadFromFile("prompts.csv", _usedPrompts);
        DisplayStartingMessage();
        DisplayPrompt();
        ShowSpinner(5);
        int _interval = GetDuration();
        Stopwatch _stopwatch = Stopwatch.StartNew();
        _stopwatch.Start();
        while (_stopwatch.ElapsedMilliseconds / 1000 < _interval)
        {
                DisplayQuestion();
                ShowSpinner(5);
        }
        SaveToFile("questions.csv", _usedQuestions);
        SaveToFile("prompts.csv", _usedPrompts);
    }

    public string GetRandomPrompt()
    {
        string prompt;
        if(_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }
        do
        {
            int randIndex = random.Next(_prompts.Count);
                prompt = _prompts[randIndex];
        }
        while(_usedPrompts.Contains(prompt));
        _usedPrompts.Add(prompt);
        return prompt;
    }

    public string GetRandomQuestion()
    {
        string _question;
        if(_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
        }
        do
        {
            int randIndex = random.Next(_questions.Count);
                _question = _questions[randIndex];
        }
        while(_usedQuestions.Contains(_question));
        _usedQuestions.Add(_question);
        return _question;
    }

    public void DisplayPrompt()
    {
        string _promptMe = GetRandomPrompt();
        Console.WriteLine(_promptMe);
    }

    public void DisplayQuestion()
    {
        string _questMe = GetRandomQuestion();
        Console.WriteLine(_questMe);
    }
    public void SaveToFile(string _file, List<string> _usedDummy)
    {   
        List<string> records = new List<string>();
        foreach (string question in _usedDummy)
        {
            string entryAsCSV = $"{question}";
            records.Add(entryAsCSV);
        }
        using(StreamWriter writer = new StreamWriter(_file, false))
        {
            foreach (string record in records)
            {
            writer.WriteLine(record);
            }

        }

    }



    public void LoadFromFile(string _file, List<string> _usedDummy)
    {
        List<string> records = File.ReadAllLines(_file).ToList();
        foreach(string record in records)
        {
            string line = record;
            _usedDummy.Add(line);
        }
    }
}