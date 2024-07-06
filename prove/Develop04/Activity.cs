public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Constructors
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public Activity()
    {
        _name = "Unknown Activity";
        _description = "No description";
        _duration = 20;
    }

    // Getters and Setters
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    // Functionality
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();

        Console.WriteLine(GetDescription());
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        string userDuration = Console.ReadLine();
        Console.WriteLine();
        int duration = int.Parse(userDuration);
        SetDuration(duration);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);

        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);

        Console.Clear();

    }

    public void ShowSpinner (int seconds)
    {
        List<string> animationString = new List<string> {"|", "/", "-", "\\"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GenerateRandomIndex(List<string> list)
    {
        Random random = new Random();
        int index = random.Next(list.Count);
        return index;
    }

}