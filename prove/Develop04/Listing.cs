using System;

public class ListingActivity: Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are some personal strengths?", 
        "Who are your favorite super heros?",
        "Name all the books in the Book of Mormon",
        "Who are some of your best friends?",
        "Name as many roller coasters as you can",
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("In this activity, you will be given a prompt. List how many things you can think of depending on what the prompt says.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public void PromptListing()
    {   
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        GenerateCountdownTimer(5);
        Console.WriteLine();

        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }
}