using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int faveNumber = PromptUserNumber();
        int squared = SquareNumber(faveNumber);
        DisplayResult(name, squared);
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
        Console.Write("Please enter your favorite number: ");
        int faveNumber = int.Parse(Console.ReadLine());
        return faveNumber;
    }

    static int SquareNumber(int faveNumber)
    {
        int squared = faveNumber * faveNumber;
        return squared;
    }

    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }    
}