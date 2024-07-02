using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Alberto Prada", "Chemical");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        MathAssignment a2 = new MathAssignment("Alberto Prada", "Math", "Multiplication", "8 x 9 = ?");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment a3 = new WritingAssignment("Alberto Prada", "Venezuelan History", "The Battle of Carabobo");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWrittingInformation());
        Console.WriteLine();
    }
}