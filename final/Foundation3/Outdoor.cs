public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string address, string eventType, string weather) : base(title, description, date, time, address, eventType)
    {
        _weather = weather;
    }

    public Outdoor() : base()
    {

    }

    public void DisplayOutdoorFullDetails()
    {
        DisplayFullDetails();
        Console.WriteLine($"Weather: {_weather}.");
    }
}