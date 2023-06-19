using System;

public class PromptGenerator
{
    public List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "List 10 things that inspire or motivate you.",
            "What aspects of your life are you most grateful for?",
            "What place makes you feel most peaceful? Describe that place using all five senses.",
            "What three things would you share with your teenage self? What three questions would you want to ask an older version of yourself?",
            "Identify one area where you would like to improve. Then, list three specific actions you can take to create that change.", 
            "List three important goals. How do they match up to your goals from 5 years ago?",
            "What helps you stay focused and motivated when you feel discouraged?"
        };
    }
    public string GetRandomPrompt()
    {
        string randomPrompt = "";
        int randomIndex = new Random().Next(prompts.Count);
        randomPrompt = prompts[randomIndex];
        return randomPrompt;
    }
}