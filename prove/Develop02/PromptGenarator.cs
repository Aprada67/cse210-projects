public class PromptGenerator
{
    public List<string> _prompts = new List<string>
        {
            "How was your day?",
            "Tell a history of how you overcame an obstacle.",
            "What is your favorite movie and why?",
            "Tell one of your favorite childhood memories.",
            "If you could travel anywhere in the world, where would you go?"
        };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();

        int randomIndex = rnd.Next(_prompts.Count);

        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }
}