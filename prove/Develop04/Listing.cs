using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private RandomPrompt _promptGenerator;

    public ListingActivity()
        : base("Listing Activity",
              "This activity will help you reflect by listing positive things in your life.")
    {
        _promptGenerator = new RandomPrompt("listing_prompts.txt");
    }

    protected override bool DoActivity()
    {
        DateTime endTime = GetEndTime();
        List<string> responses = new List<string>();

        string prompt = _promptGenerator.GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {responses.Count} items.");

        return responses.Count > 0;
    }
}