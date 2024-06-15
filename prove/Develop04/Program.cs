using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        void DisplayLog()
        {
            Console.WriteLine("Activity Log - Current session");
            Console.WriteLine($"Breathing Activity: {breathingLog}");
            Console.WriteLine($"Reflecting Log: {reflectingLog}");
            Console.WriteLine($"Listing Log: {listingLog}");

        }

        while (input != "4")
        {
            Console.Clear();
            DisplayLog();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity:");
            Console.WriteLine("3. Start Listing Activity:");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please select one of the menu options");

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    breathingActivity.PromptBreathing();
                    breathingActivity.EndActivity();

                    breathingLog++;
                    break;

                case "2":
                    ReflectionActivity reflectingActivity = new ReflectionActivity();
                    reflectingActivity.RunActivity();
                    reflectingActivity.PromptReflecting();
                    reflectingActivity.EndActivity();

                    reflectingLog++;
                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    listingActivity.PromptListing();
                    listingActivity.EndActivity();

                    listingLog++;
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please enter the number of the menu option. ");
                    break;
            }
            
        }
        Environment.Exit(0);
        
    }
}