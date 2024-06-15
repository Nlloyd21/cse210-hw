using System;
using System.Threading;

public class Activity
{
    // Attributes
    private string _name;
    private string _description;
    private int _duration;

    // Constructor
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 15;
    }

    // Setters
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Getters
    public int GetDuration()
    {
        return _duration;
    }

    // Methods
    public void ShowDetails()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
    }

    public void AskDuration()
    {
        Console.WriteLine($"\nHow long in seconds would you like to complete the {_name}?");
        string durationString = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationString));
    }

    public void RunActivity()
    {
        Console.Clear();
        ShowDetails();
        AskDuration();
        GetReady();
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!!");
        GenerateSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        GenerateSpinner(5);
    }

    public void GenerateSpinner(int totalSeconds)
    {
        int spinnerPosition = 25;
        int spinWait = 500;

        spinnerPosition = Console.CursorLeft;
        DateTime futureTime = GetFutureTime(5);

        while (DateTime.Now < futureTime)
        {
            char[] spinChars = new char[] { '|', '/', '-', '\\' };
            foreach (char spinChar in spinChars)
            {
                Console.CursorLeft = spinnerPosition;
                Console.Write(spinChar);
                Thread.Sleep(spinWait);
            }
        }
        Console.CursorLeft = spinnerPosition;
        Console.Write(" ");
    }

    public void GenerateCountdownTimer(int totalSeconds)
    {
        int timerPosition = 25;
        int timerWait = 1000;

        timerPosition = Console.CursorLeft;

        for (int i = 0; i <= totalSeconds; i++)
        {
            Console.CursorLeft = timerPosition;
            Console.Write(totalSeconds - i);
            Thread.Sleep(timerWait);
        }
        Console.CursorLeft = timerPosition;
        Console.Write(" ");
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        GenerateSpinner(5);
    }

    public DateTime GetFutureTime(int duration)
    {
        return DateTime.Now.AddSeconds(duration);
    }

    public DateTime GetCurrentTime()
    {
        return DateTime.Now;
    }
}

