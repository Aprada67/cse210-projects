using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();

        Cycling cycling = new Cycling();
        cycling.SetDate();
        cycling.SetLength(60);
        cycling.SetSpeed(20);
        activities.Add(cycling);

        Running running = new Running();
        running.SetDate();
        running.SetLength(90);
        running.SetDistance(20);
        activities.Add(running);

        Swimming swimming = new Swimming();
        swimming.SetDate();
        swimming.SetLength(45);
        swimming.SetLaps(20);
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.DisplaySummary());
        }
    }
}