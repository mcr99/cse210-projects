using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public List<Goal> _goals;
    public int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        LoadGoals();

        while (true)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine(" ");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                CreateGoal();
                break;
                case "2":
                ListGoalDetails();
                break;
                case "3":
                SaveGoals();
                break;
                case "4":
                LoadGoals();
                break;
                case "5":
                RecordEvent();
                break;
                case "6":
                    return;
                default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }
    }

    public void DisplayPlayerInfo() 
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal._shortName);
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            var goal = _goals[i];
            string status = goal.IsComplete() ?"[x]" : "[ ]";
            string details = goal.GetDetailsString();
            if (goal is ChecklistGoal checklistGoal)
            {
                details += $" -- currently completed: {checklistGoal._amountCompleted}/{checklistGoal._target}";
            }

            Console.WriteLine($"{i + 1}. {status} {goal._shortName} ({goal._description})");
        }

    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (1: Simple, 2: Eternal, 3: Checklist): ");
        var goalType = Console.ReadLine();

        Console.WriteLine("Enter goal name: ");
        var name = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        var description = Console.ReadLine();

        Console.WriteLine("Enter goal points: ");
        var points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine("Enter target number: ");
                var target = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points: ");
                var bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;

                default: 
                Console.WriteLine("Invalid goal type. ");
                break;

        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter goal name: ");
        var name = Console.ReadLine();

        foreach (var goal in _goals)
        {
            if (goal._shortName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                _score += goal.RecordEvent();
                return;
            }
        }
        Console.WriteLine("Goal not found. ");
    }

    public void SaveGoals()
    {
        using (var writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goal saved successfully. ");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found");
            return;
        }

        using (var reader = new StreamReader("goals.txt"))
        {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                var goalType = parts[0];
                var name = parts[1];
                var description = parts[2];
                var points = int.Parse(parts[3]);

                Goal goal = null;
                switch (goalType)
                {
                    case "SimpleGoal": 
                    goal = new SimpleGoal(name, description, points) {_isComplete = bool.Parse(parts[4])};
                    break;
                    case "EternalGoal":
                    goal = new EternalGoal(name, description, points);
                    break;
                    case "ChecklistGoal":
                    var target = int.Parse(parts[4]);
                    var bonus = int.Parse(parts[5]);
                    var amountCompleted = int.Parse(parts[6]);
                    goal = new ChecklistGoal(name, description, points, target, bonus) {_amountCompleted = amountCompleted};
                    break;
                }

                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully. ");
        }
    }

}