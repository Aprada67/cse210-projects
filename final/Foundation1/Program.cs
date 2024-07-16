using System;

class Program
{
    static void Main(string[] args)
    {
        var comment1 = new List<Comments>
        {
            new Comments("Robert", "Like if you are listening this song in 2024"),
            new Comments("Cristina", "Amazing 😍"),
            new Comments("Jeff", "It is music to my ears!!"),
        };

        Video video1 = new Video("Dex Arson & Incandescent - Of Light And Fire", "Dex Arson", 307, comment1);

        var comment2 = new List<Comments>
        {
            new Comments("NoCopyrigthSounds", "Do you feel your bones start to shake? Do you feel the earthquake?  0:34 🔥"),
            new Comments("Jonathan", "ROY KNOX continues to make good stuff! Was not expecting that 3rd drop to be the heaviest!"),
            new Comments("JesusPerez", "Soon enough, we'll hear this in gaming montages."),
        };

        Video video2 = new Video("ROY KNOX - Earthquake | Drumstep | NCS - Copyright Free Music", "NoCopyrigthSounds", 178, comment2);

        var comment3 = new List<Comments>
        {
            new Comments("SolenceOfficial", "Thanks for all these amazing comments!! Take care everyone and wash your hands!! <3"),
            new Comments("Emryth", "Solence is way too underrated."),
            new Comments("FrostPlayer", "After two years, I still love listening to it"),
        };

        Video video3 = new Video("Solence - Blackout (Official Lyric Video)", "SolenceOfficial", 200, comment3);

        var videos = new List<Video> { video1, video2, video3};

        int i = 1;

        foreach(Video video in videos)
        {
            Console.WriteLine($"Video {i}");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAutor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments:");

            foreach(Comments comments in video.GetComments())
            {
                Console.WriteLine($"    {comments.CreateComment()}\n");
            }

            i++;
        }
    }
}