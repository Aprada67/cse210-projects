public class Reception : Event
{
    public string _email;

    public Reception(string title, string description, string date, string time, string address, string eventType, string email) : base (title, description, date, time, address, eventType)
    {
        _email = email;
    }

    public Reception() : base()
    {

    }

    public void DisplayReceptionFullDetails()
    {
        DisplayFullDetails();
        Console.WriteLine($"RSVP E-mail: {_email}.");
    }
}