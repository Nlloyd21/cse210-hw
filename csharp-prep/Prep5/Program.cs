using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResults(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        int number;
        bool isValidNumber = false;

        do
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();

            isValidNumber = int.TryParse(input, out number);

            if (!isValidNumber)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (!isValidNumber);

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
