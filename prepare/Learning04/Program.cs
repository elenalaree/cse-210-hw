using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Adam Driver", "Fractions");
        Console.WriteLine(a1.GetSummery());
        MathAssignment m1 = new MathAssignment("Robby Johnson", "History", "7.4", "8-9");
        Console.WriteLine(m1.GetSummery());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w3 = new WritingAssignment("Jean Morris", "Japanese History", "Rise and Fall of the Samurai");
        Console.WriteLine(w3.GetSummery());
        Console.WriteLine(w3.GetWritingInformation());
    }
}