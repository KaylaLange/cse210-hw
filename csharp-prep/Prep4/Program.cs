using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number;

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        double avg;
        if (numbers.Count > 0)
        {
            avg = (double)sum / numbers.Count;
        }
        else
        {
            avg = 0;
        }

        int smallestPositiveNum = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositiveNum)
            {
                smallestPositiveNum = num;
            }
        }

        int largestNumber = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNum}");
        Console.WriteLine($"The sorted list is: ");

        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            int sortedNum = numbers[i];
            Console.WriteLine(sortedNum);
        }
    }
}