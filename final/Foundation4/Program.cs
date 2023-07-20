using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events= new List<Event>();

        Running running= new Running("03 July, 2023", 15, 2);
        Cycling cycling= new Cycling("07 July, 2023", 30, 15);
        Swimming swimming= new Swimming("09 July, 2023", 30, 30);

        events.Add(running);
        events.Add(cycling);
        events.Add(swimming);
        foreach (Event i in events)
        {
            i.GetSummery();
        }
    }
}