// Added a levelUp method that keeps track of how many events the user enters and allows the user to level up
// when they've entered at least 10 events.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

    }
}