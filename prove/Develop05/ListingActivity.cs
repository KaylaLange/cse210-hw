using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _listingPrompts;

    public ListingActivity(int count, List<string> listingPrompts, int duration) : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _count = count;
        _listingPrompts = listingPrompts;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        string listingPrompts = GetRandomPrompt();
        Console.WriteLine($"--- {listingPrompts} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(0);

        Console.WriteLine();
        List<string> userList = GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {userList.Count} items!");

        DisplayEndingMessage();

        ShowSpinner(0);
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_listingPrompts.Count);
        return _listingPrompts[randomIndex];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            userList.Add(userInput);
        }

        return userList;
    }
}