public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string address, string eventType, string speakerName, int capacity) : base(title, description, date, time, address, eventType)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public Lecture() : base()
    {

    }

    public void DisplayLectureFullDetails()
    {
        DisplayFullDetails();
        Console.WriteLine($"Speaker: {_speakerName}.");
        Console.WriteLine($"Capacity: {_capacity}.");
    }
}