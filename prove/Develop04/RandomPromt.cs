using System;
using System.Collections.Generic;
using System.IO;

class RandomPrompt
{
    private List<string> _prompts;
    private List<string> _usedPrompts;
    private Random _random;

    public RandomPrompt(string filePath)
    {
        _prompts = new List<string>();
        _usedPrompts = new List<string>();
        _random = new Random();

        LoadPrompts(filePath);
    }

    private void LoadPrompts(string filePath)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    _prompts.Add(line.Trim());
                }
            }
        }
        else
        {
            Console.WriteLine($"Error: File '{filePath}' not found.");
        }
    }

    public string GetRandomPrompt()
    {
        // If all prompts used, reset
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        string prompt;

        do
        {
            int index = _random.Next(_prompts.Count);
            prompt = _prompts[index];
        }
        while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);

        return prompt;
    }
}