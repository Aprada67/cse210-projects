using System;

class Program
{
    static void Main(string[] args)
    {
        Library myLibrary = new Library();

        myLibrary.AddScripture(new Reference("1 Nephi", 3, 7), "This verse highlights faith and obedience. Nephi demonstrates his willingness to follow the Lord's commandments, trusting that God will prepare the way for them to be fulfilled.");
        myLibrary.AddScripture(new Reference("Mosiah", 4, 9), "This verse emphasizes the importance of faith in God and His omnipotence and omniscience. It is a call to trust in God even when we do not understand all His works.");
        myLibrary.AddScripture(new Reference("Doctrine and Covenants", 1, 37, 38), "Here, the Lord declares the importance of His commandments and prophecies, assuring the faithful that His words will be fulfilled. It also underscores that the voice of His servants is as valid as His own voice.");
        myLibrary.AddScripture(new Reference("Moses", 1, 39), "This verse expresses God's ultimate purpose: the immortality and eternal life of man. It is fundamental to understanding the plan of salvation according to LDS doctrine.");
        myLibrary.AddScripture(new Reference("John", 3, 16), "A key verse for all Christians, it highlights God's love and the sacrifice of Jesus Christ, offering the promise of eternal life to all who believe in Him.");

        Scripture scripture = myLibrary.SelectRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");

            // Programs ends when all of the words are completely hidden
            if (scripture.IsCompletlyHidden())
            {
                break;
            }

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}