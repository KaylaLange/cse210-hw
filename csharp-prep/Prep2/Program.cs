using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();

        int percent = int.Parse(gradePercentage);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >=70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int dividend = percent;
        int divisor = 10;
        int remainder = dividend % divisor;

        string sign = "";

        if (remainder >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (remainder < 3 && letter != "F")
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. Let's look at your options!");
        }

    }

}