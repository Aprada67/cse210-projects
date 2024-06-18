using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Warehouse Operator";
        job1._company = "DHL";
        job1._startYear = 2018;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Content Moderator";
        job2._company = "Accenture";
        job2._startYear = 2020;
        job2._endYear = 2024;
        
        Resume myResume = new Resume();
        myResume._name = "Alberto Prada";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}