using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Compute the sum

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Compute the average

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        // Find the largest

        int max = 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine($"The largest number is: {max}");

        // Find the samallest

        int min = 999999999;

        foreach (int number in numbers)
        {
            if (number < min && number > 0)
            {
                min = number;
            }
        }

        Console.WriteLine($"The smallest number is: {min}");

        // Sort the list

        numbers.Sort();

        string sortedList = string.Join(", ", numbers);

        Console.WriteLine($"Sorted list: {sortedList}");
    }
}