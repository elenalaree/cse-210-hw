using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.Write(number);
        int guess = 0;
        int count = 0;
        while (number != guess)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count++;
            Console.WriteLine($"You have guessed {count} times");
            if (number < guess)
            {
                Console.WriteLine("Guess lower.");
            }
            else if( number > guess)
            {
                Console.WriteLine("Guess higher.");
            }
            else
            {
            Console.WriteLine("You guessed it!");
            Console.WriteLine("Do you want to guess again? ");
            string answer = Console.ReadLine();
            if(answer == "yes")
            {
                number = randomGenerator.Next(1, 101);
            }
            else{
                Console.WriteLine("Thanks for playing!");
            }
            }
        }
    }
}