using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
       
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        // while (DateTime.Now < futureTime)
        // {
        //     Console.WriteLine();
        //     Console.Write("Breathe in...");
        //     ShowCountdown(0);
        //     Console.WriteLine();
        //     Console.Write("Now breathe out...");
        //     ShowCountdown(0);
        //     Console.WriteLine();
        // }

        // while (DateTime.Now < futureTime)
        // {
        //     Console.WriteLine();
        //     DelayedPrint("Breathe in...", 5000);
        //     DelayedPrint("Now breathe out...", 5000);
        // }

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            AnimateBreath("Breathe in...", true);
            AnimateBreath("Now Breathe out...", false);
        }

        DisplayEndingMessage();

        ShowSpinner(0);
        Console.Clear();
    
    }

    // private void DelayedPrint(string text, int duration)
    // {
    //     int delay = duration / text.Length;
    //     foreach (char c in text)
    //     {
    //         Console.Write(c);
    //         Thread.Sleep(delay);
    //     }
    // Console.WriteLine();
    // }
    private void AnimateBreath(string text, bool growing)
    {
        int steps = 20;
        int delay = 100;

        for (int i = 0; i <= steps; i++)
        {
            Console.Clear();
            int length = growing ? i : (steps - 1);
            string animation = new string(' ', length) + text;
            Console.WriteLine(animation);
            System.Threading.Thread.Sleep(delay);
        }
        if (!growing)
        {
            for (int i = steps; i >= 0; i--)
            {
                Console.Clear();
                int length = i;
                string animation = new string(' ', length) + text;
                Console.WriteLine(animation);
                System.Threading.Thread.Sleep(delay);
            }
        }
    }
        
}