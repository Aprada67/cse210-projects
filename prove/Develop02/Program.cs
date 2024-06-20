using System;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator myPrompt = new PromptGenerator();
        Entry myEntry = new Entry();

        Console.WriteLine("Welcome to the Journal Program");

        int userSelection = -1;
        string userEntry = "";

        while (userSelection != 5)
        {
            myJournal.DisplayAll();
            string valueFromUser = Console.ReadLine();
            userSelection = int.Parse(valueFromUser);
            Console.WriteLine();

            // If user selection is 1 call method GetRandomPromt
            if (userSelection == 1)
            {
                string randomPrompt =  myPrompt.GetRandomPrompt();
                Console.WriteLine(randomPrompt);

                // Date
                DateTime date = DateTime.Today;
                string formatedDate = date.ToString("dd-MM-yyyy");

                // User entry text
                userEntry = Console.ReadLine();

                myEntry._date = formatedDate;
                myEntry._promptText = randomPrompt;
                myEntry._entryText = userEntry;

                // Call AddEntry method
                myJournal.AddEntry(myEntry);
            }
            else if (userSelection == 2)
            {   
                //myJournal.InitializeEntries();
                foreach(Entry entry in myJournal._entries) {
                    entry.Display();
                }

            }
        }
    }
}