using System;
using System.Collections.Generic;
using System.IO;

public class Menu
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public void Run()
    {
        int choice = 0;

        while (choice != 6)
        {
            DisplayScore();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                DisplayGoals();
            }
            else if (choice == 3)
            {
                DisplayGoals();
                Console.Write("Which goal did you complete? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                RecordEvent(index);
            }
            else if (choice == 4)
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();

                Save(file);
            }
            else if (choice == 5)
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();

                Load(file);
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select type: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Goal name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            AddGoal(new SimpleGoal(name, desc, points));
        }

        else if (type == 2)
        {
            AddGoal(new EternalGoal(name, desc, points));
        }

        else if (type == 3)
        {
            Console.Write("Times needed to complete: ");
            int max = int.Parse(Console.ReadLine());

            Console.Write("Bonus points when finished: ");
            int bonus = int.Parse(Console.ReadLine());

            AddGoal(new ChecklistGoal(name, desc, points, max, bonus));
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine("Your new goal has been added");
    }

    private int GetLevel()
    {
        return (_totalPoints / 500) + 1;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nScore: {_totalPoints}");
        Console.WriteLine($"Level: {GetLevel()}");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].DisplayGoal();
        }
    }


    public void RecordEvent(int index)
    {
        Goal goal = _goals[index];

        if (!goal.IsComplete())
        {
            goal.CompleteGoal();
            _totalPoints += goal.GetPoints();

            Console.WriteLine($"You earned {goal.GetPoints()} points!");
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public void Save(string filename)
    {
        List<string> lines = new List<string>();

        // Save score first
        lines.Add(_totalPoints.ToString());

        // Save each goal
        foreach (Goal goal in _goals)
        {
            lines.Add(goal.Delimited());
        }

        File.WriteAllLines(filename, lines);

        Console.WriteLine("Goals saved successfully.");
    }

    public void Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        // Get the total points from file
        _totalPoints = int.Parse(lines[0]);

        // Get the goals from the file
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "Simple")
            {
                string name = data[0];
                string desc = data[1];
                int points = int.Parse(data[2]);
                bool isComplete = bool.Parse(data[3]);

                SimpleGoal goal = new SimpleGoal(name, desc, points);

                if (isComplete)
                {
                    goal.CompleteGoal();
                }

                _goals.Add(goal);
            }

            else if (type == "Eternal")
            {
                string name = data[0];
                string desc = data[1];
                int points = int.Parse(data[2]);

                EternalGoal goal = new EternalGoal(name, desc, points);
                _goals.Add(goal);
            }

            else if (type == "Checklist")
            {
                string name = data[0];
                string desc = data[1];
                int points = int.Parse(data[2]);
                int completeNum = int.Parse(data[3]);
                int maxNum = int.Parse(data[4]);
                int bonus = int.Parse(data[5]);

                ChecklistGoal goal = new ChecklistGoal(name, desc, points, maxNum, bonus);

                for (int j = 0; j < completeNum; j++)
                {
                    goal.CompleteGoal();
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}