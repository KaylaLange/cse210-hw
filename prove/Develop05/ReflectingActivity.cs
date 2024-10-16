using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(List<string> prompts, List<string> questions, int duration) : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        DisplayPrompt();
    
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(0);
        Console.WriteLine();

        Console.Clear();
        DisplayQuestions();

        Console.WriteLine();
        DisplayEndingMessage();

        ShowSpinner(0);
        Console.Clear();        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        return _questions[randomIndex];
    }

    public void DisplayPrompt()
    {
        string prompts = GetRandomPrompt();
        Console.WriteLine($"--- {prompts} ---");
        Console.WriteLine();
    }

    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            string questions = GetRandomQuestion();
            Console.WriteLine();
            Console.Write($"> {questions} ");
            ShowSpinner(0);
            
        }
    }
}