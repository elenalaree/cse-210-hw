using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(6);
        Fraction f2 = new Fraction(2, 3);
        Fraction f3 = new Fraction();
        Fraction f4 = new Fraction(5, 8);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}