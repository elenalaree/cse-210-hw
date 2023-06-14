using System;

class Program
{
    static void Main(string[] args)
    {
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();

        int square = SquareNumber(favNumber);

        DisplayResult(userName, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.Write($"{name}, the square of your favorite number is {square}.");
    }
    
}