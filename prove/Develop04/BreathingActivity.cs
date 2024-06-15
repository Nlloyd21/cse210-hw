using System;

class BreathingActivity : Activity
{
    //constructor
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you focus on your breathing, by walking you some slowly breathing exercises.");
    }

    public void PromptBreathing()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        Console.WriteLine();
        Console.WriteLine("Breath in...");
        GenerateCountdownTimer(5);
        Console.WriteLine();
        Console.WriteLine("Breath Out");
        GenerateCountdownTimer(5);
        Console.WriteLine();

        while (currentTime <=futureTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            GenerateCountdownTimer(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            GenerateCountdownTimer(6);
            currentTime = DateTime.Now;
        }    
    }






}