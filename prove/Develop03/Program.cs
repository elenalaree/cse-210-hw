using System;

class Program
{
    static void Main(string[] args)
    {
        string _userInput = "";
        Reference   reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (_userInput != "quit")
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to remove words, type 'show' to see more words, or type quit to finish. ");
            _userInput = Console.ReadLine();
            if (scripture.IsCompletelyHidden() == true)
            {
                Thread.Sleep(5000);
                _userInput = "quit";
            }
            else if (_userInput == "show")
            {
                scripture.ShowRandomWords();
                scripture.GetDisplayText();
            }
            else
            {
            scripture.HideRandomWords();
            scripture.GetDisplayText();
            }
            
            Console.Clear();
        }
    }
}