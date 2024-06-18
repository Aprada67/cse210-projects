using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate throught the list of jobs
        foreach (Job job in _jobs)
        {
            // Call method Display in Job class
            job.Display();
        }
    }
}