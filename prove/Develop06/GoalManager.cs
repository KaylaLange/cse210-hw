using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private int _score;
    private List<Goal> _goals;
    private int _totalEvents;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _totalEvents = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (userChoice == 1)
            {
                CreateGoal();
            }
            else if (userChoice == 2)
            {
                ListGoalDetails();
            }
            else if (userChoice == 3)
            {
                SaveGoals();
            }
            else if (userChoice == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                LoadGoals(filename);
            }
            else if  (userChoice == 5)
            {
                RecordEvent();
            }
            else if (userChoice == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please type a number from the menu. ");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        
    }

    public void ListGoalNames()
    {
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        int number = 1;

        foreach (var goal in _goals)
        {
            string detailString = goal.GetStringRepresentation();
            string[] parts = detailString.Split(':');
            string name = parts[1].Split('|')[0].Trim();
            Console.WriteLine($"{number}. {name}");
            number++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int goalNumber = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goalNumber}. {goal.GetDetailString()}");
            goalNumber++;
        }
    }

    public void CreateGoal()
    {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            int goalChoice = int.Parse(Console.ReadLine());

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

        if (goalChoice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalChoice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalChoice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            int amountCompleted = 0;
            bool isComplete = false;
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted, isComplete));
        }
                
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int selection = int.Parse(Console.ReadLine());

        if (selection > 0 && selection <= _goals.Count)
        {
            Goal selectedGoal = _goals[selection - 1];

            if (selectedGoal is SimpleGoal simpleGoal)
            {
                simpleGoal.RecordEvent();
                _score += simpleGoal.GetPoints();
            }
            else if (selectedGoal is EternalGoal eternalGoal)
            {
                eternalGoal.RecordEvent();
                _score += eternalGoal.GetPoints();
            }
            else if (selectedGoal is ChecklistGoal checklistGoal)
            {
                checklistGoal.RecordEvent();
                _score += checklistGoal.GetPoints();
            }

            _totalEvents++;
            if (_totalEvents >= 10)
            {
                LevelUp();
            }
            Console.WriteLine($"You now have {_score} points and have recorded {_totalEvents} events.");
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }

    public void LevelUp()
    {
        Console.WriteLine();
        Console.WriteLine("Hooray! You've completed at least 10 goals and have leveled up! You are an official Goal-Crushing Gryffindor!");
        
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        var filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename)) 
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");

            if (parts[0] == "SimpleGoal")
            {
                string[] goalDetails = parts[1].Split('|');
                string name = goalDetails[0].Trim();
                string description = goalDetails[1].Trim();
                int points = int.Parse(goalDetails[2].Trim());
                bool iscomplete = bool.Parse(goalDetails[3].Trim());
                SimpleGoal goal = new SimpleGoal(name, description, points);
                goal.SetIsComplete(iscomplete);
                _goals.Add(goal);
            }

            else if (parts[0] == "EternalGoal")
            {
                string[] goalDetails = parts[1].Split('|');
                string name = goalDetails[0].Trim();
                string description = goalDetails[1].Trim();
                int points = int.Parse(goalDetails[2].Trim());
                _goals.Add(new EternalGoal(name, description, points));
            }

            else if (parts[0] == "ChecklistGoal")
            {
                string[] goalDetails = parts[1].Split('|');
                string name = goalDetails[0].Trim();
                string description = goalDetails[1].Trim();
                int points = int.Parse(goalDetails[2].Trim());
                int target = int.Parse(goalDetails[3].Trim());
                int bonus = int.Parse(goalDetails[4].Trim());
                int amountCompleted = int.Parse(goalDetails[5].Trim());
                bool isComplete = bool.Parse(goalDetails[6].Trim());
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted, isComplete);
                goal.SetIsComplete(isComplete);
                _goals.Add(goal);
            } 
        }
    }
}

