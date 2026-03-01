using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void RunActivity()
    {
        StartActivity();

        bool didRun = DoActivity();

        if (didRun)
        {
            EndActivity();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Not enough time to perform a full activity.");
            Console.WriteLine("Please try again with a longer duration.");
            ShowSpinner(2);
        }
    }

    // Subclasses override this
    protected virtual bool DoActivity()
    {
        return true;
    }

    private void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        // Safe input handling
        while (true)
        {
            Console.Write("Enter duration in seconds: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out _duration) && _duration > 0)
            {
                break;
            }

            Console.WriteLine("Please enter a valid positive number.");
        }

        Console.WriteLine();
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);

        // Timer starts AFTER spinner
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    private void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    // Accessible to subclasses
    protected void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected DateTime GetEndTime()
    {
        return _endTime;
    }
}