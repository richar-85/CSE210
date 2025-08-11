using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private HashSet<int> _milestones = new HashSet<int>(); // Use in CheckMilestons method 
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            DisplayPlayerInfo(); // Show score here
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            Console.WriteLine();

            if (input == "1")
            {
                CreateGoal();
            }
            else if (input == "2")
            {
                ListGoalDetails();
            }
            else if (input == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                SaveGoals(filename);
            }
            else if (input == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                LoadGoals(filename);
            }
            else if (input == "5")
            {
                RecordEvent();
            }
            else if (input == "6")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Goals Completed: {_goals.Count(g => g.IsComplete())}/{_goals.Count}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goal Names:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {

            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (type == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (type == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal added!");
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Select goal number to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];

            int pointsEarned = goal.RecordEvent();

            _score += pointsEarned;


            if (pointsEarned > 0)
            {
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {pointsEarned} points.");

                CheckMilestones(); // Use in CheckMilestone method
            }

            else
            {
                Console.WriteLine("No points awarded.");
            }
            DisplayPlayerInfo();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void SaveGoals(string filename)
    {

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goal saved to {filename}");
    }

    public void LoadGoals(string filename)
    {

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]), int.Parse(parts[5])));
            }
            else
            {
                Console.WriteLine($"Unknown goal type: {type}");
            }
        }
        Console.WriteLine("Progress loaded.");
    }

    // Added CheckMilestones method
    public void CheckMilestones()
    {
        if (_score >= 1000 && !_milestones.Contains(1000))
        {
            _milestones.Add(1000);
            Console.WriteLine("\n🎉🎉🎉 AMAZING! You've reached 1000 points!\n");
        }
        else if (_score >= 500 && !_milestones.Contains(500))
        {
            _milestones.Add(500);
            Console.WriteLine("\n✨✨✨ Great Job! You've reached 500 points!\n");
        }
        else if (_score >= 100 && !_milestones.Contains(100))
        {
            _milestones.Add(100);
            Console.WriteLine("\n🔥🔥🔥 Keep it up! You've reached 100 points!");
        }
    }
    
}