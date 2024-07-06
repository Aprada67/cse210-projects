public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration) { }

    public BreathingActivity() : base()
    {
        SetName("BreathingActivity");
        SetDescription("This activity will help you to relax by walking through your breathing  in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine();

        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Now hold your breath...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Breath out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}