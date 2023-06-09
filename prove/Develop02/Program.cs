using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator= new PromptGenerator();
        Journal         journal= new Journal();  
        int             menuUserInput = 0;
        List<string>    menu = new List<String>
        {
            "Please select an option from the following:",
            "1.Write",
            "2.Display",
            "3.Load",
            "4.Save",
            "5.Quit",
            "What would you like to do?"
        };

        Console.WriteLine("Welcome to the Journal Program!");

        while (menuUserInput != 5)
        {
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            };
            menuUserInput = int.Parse(Console.ReadLine());

            switch (menuUserInput)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    Console.WriteLine("What is your mood today using an emoji or single word? ");
                    string myMood = Console.ReadLine();
                    string date = DateTime.Now.Date.ToString("MMM dd, yyyy");

                    Entry entry = new Entry(date, prompt, response, myMood);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                Console.WriteLine("Name of file to load:");
                    string fileNameLoad = Console.ReadLine();
                    journal.LoadFromFile(fileNameLoad);
                    break;
                case 4:
                    Console.WriteLine("Name of file to save?");
                    string fileNameSave = Console.ReadLine();
                    journal.SaveToFile(fileNameSave);
                    break;
            }
        }
    }
}