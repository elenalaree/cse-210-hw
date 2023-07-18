using System;

class Program
{
    static void Main(string[] args)
    {
        Address _venue1 = new Address("2443 Solomon Way", "Del Rio", "Texas", "USA");
        Lectures _lectureEvent = new Lectures("Grow Seminar", "An event where business people learn important stuff", "March 22, 2024", "9AM-12pm", _venue1, 600, "Stephanie Dupre" );
        _lectureEvent.StandardMessage();
        _lectureEvent.FullDetails();
        _lectureEvent.ShortDescription();
        Console.WriteLine();

        Address _venue2 = new Address("456 Lovers Lane", "Salem", "Oregon", "USA");
        string _rsvpEmail = "emily@gmail.com";
        Receptions _receptionEvent = new Receptions("Wedding Reception", "The wedding reception for Emily and Ian.", "Aug 25, 2023", "6pm-10pm", _venue2, _rsvpEmail);
        _receptionEvent.StandardMessage();
        _receptionEvent.FullDetails();
        _receptionEvent.ShortDescription();
        Console.WriteLine();

        Address _venue3 = new Address("1403 Angie Drive", "Houston", "Texas", "USA");
        string _weather = "Sunny with a chance of Clouds";
        Outdoor _outdoorEvent = new Outdoor("Frisbee Competition", "An event to compete for the Golded Frisbee.", "October 7th, 2023", "9AM-12pm", _venue3, _weather );
        _outdoorEvent.StandardMessage();
        _outdoorEvent.FullDetails();
        _outdoorEvent.ShortDescription();
    }
}