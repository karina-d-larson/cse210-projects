using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points)
    {
    }

    public override void CompleteGoal()
    {
        // Eternal goals never complete
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string Delimited()
    {
        return $"Eternal:{_goalName},{_description},{_pointValue}";
    }
}