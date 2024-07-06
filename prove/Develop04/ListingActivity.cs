public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public ListingActivity() : base()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you to reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _prompts = new List<string>
        {
            "What are some goals you have achieved recently?",
            "How have you shown kindness to others recently?",
            "What are some lessons you've learned this year?",
            "Who has had a positive impact on your life recently?",
            "What are some challenges you have overcome?",
            "How do you practice self-care?",
            "What are some memorable experiences you've had this month?",
            "Who do you look up to and why?",
            "What are some things you are grateful for today?",
            "How have you grown as a person in the last year?",
        };
 
    }


    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();

        Console.Clear();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        List<string> answers = new List<string>();

        while (DateTime.Now < endTime)
        {
            GetListFromUser(answers);
            
            if (DateTime.Now >= endTime)
            break;
        }

        if (answers.Count != 1)
        {
            Console.WriteLine($"You listed {answers.Count} Items!\n");
        }
        else
        {
            Console.WriteLine($"You listed {answers.Count} Item!\n");
        }

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        string randomPrompt = _prompts[GenerateRandomIndex(_prompts)];
        Console.WriteLine($" --- {randomPrompt} ---");
    }

    public void GetListFromUser(List<string> list)
    {
        Console.Write("> ");
        string answer = Console.ReadLine();
        list.Add(answer);
    }

}