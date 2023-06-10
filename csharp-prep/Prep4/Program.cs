using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers. Press 0 when finished." );
        int answer = -1;
        while(answer != 0)
        {
            Console.Write("Enter number: ") ;
            answer = int.Parse(Console.ReadLine()) ;
            numbers.Add(answer);
        }
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
        double sum1 = numbers.Sum() ;
        double average = sum1 / (numbers.Count() - 1) ;
        int largest = numbers.Max();
        Console.WriteLine($"The Sum of the number is: {sum1}") ;
        Console.WriteLine($"The Average of the number is: {average}") ;
        Console.WriteLine($"The Largest number is: {largest}") ;
    }
}