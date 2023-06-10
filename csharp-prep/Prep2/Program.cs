using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string modifier = "";
        Console.WriteLine("What is your grade? ");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";

        }
        else if (grade >= 70)
        {
            letter = "C";

        }
        else if (grade >= 60)
        {
            letter = "D";

        }
        else
        {
            letter = "F";
        }

        if (grade % 10 >= 7)
        {
            if(grade >= 95)
            {
                modifier = "";
            }
            else if(grade >= 55 && grade < 60)
            {
                modifier = "";
            }
            else
            {
            modifier = "+";
            }
        }
        else if (grade % 10 < 3)
        {
            if(grade < 55)
            {
                modifier = "";
            }
            else
            {
            modifier = "-";
            }
        }
        else
        {
            modifier = "";
        }

        Console.WriteLine($"Your grade: {letter}{modifier}!");

        if (letter == "A" || letter == "B" || letter == "C" )
        {
            Console.Write("You passed!");
        }
        else
        {
            Console.Write("You didn't pass!");
        }
    }
}