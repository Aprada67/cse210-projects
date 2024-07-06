public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public ReflectingActivity() : base()
    {
        SetName("Reflecting Activity");
        SetDescription("This Activity will help you to reflec on times in your life when you have shown strenght and resilence. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _prompts = new List<string>
        {
            "Reflect on a time when you faced your fears.",
            "Recall a time when you showed bravery in a tough situation.",
            "Think of a time when you supported someone during a crisis.",
            "Consider a time when you sacrificed something for the benefit of others.",
            "Recall a situation where you realized your positive impact on someone else's life.",
            "Think of a time when you made a tough decision to help a friend.",
        };
        _questions = new List<string>
        {
            "What was the biggest challenge you faced during this experience?",
            "How did you overcome any obstacles you encountered?",
            "What advice would you give to someone in a similar situation?",
            "What were the key factors that contributed to your success?",
            "How did this experience change your perspective on similar situations?",
            "What would you do differently if you had the chance to do it again?",
            "What skills or qualities did you develop through this experience?",
            "How did you maintain motivation throughout the experience?"
        };
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();

        DisplayPrompt();
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they releated to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(10);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[GenerateRandomIndex(_prompts)];
    }

    public string GetRandomQuestion()
    {
        return _questions[GenerateRandomIndex(_prompts)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()}. ---");
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }

}