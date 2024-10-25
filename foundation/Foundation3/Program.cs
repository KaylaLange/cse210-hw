using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now, 45, 5.0),
            new Cycling(DateTime.Now, 30, 15.0),
            new Swimming(DateTime.Now, 30, 20)
        };

        Console.WriteLine();
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}