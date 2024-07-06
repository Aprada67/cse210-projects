using System;

class Program
{
    static void Main(string[] args)
    {   
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        int selection = 0;

        Console.Clear();

        while (selection != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            try
            {
                selection = int.Parse(input);

                if (selection < 1 || selection > 4)
                {
                    Console.WriteLine("Invalid selection. Please enter a number between 1 and 4.");
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch(selection)
                {
                    case 1:
                    breathing.Run();
                    break;

                    case 2:
                    reflecting.Run();
                    break;

                    case 3:
                    listing.Run();
                    break;

                    case 4:
                    Console.WriteLine("\nGood bye!!\n");
                    break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.WriteLine("Press any key to try again...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}