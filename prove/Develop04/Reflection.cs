using System;

class ReflectionActivity : Activity
{
    private RandomPrompt _promptGenerator;
    private RandomPrompt _questionGenerator;

    public ReflectionActivity() 
        : base("Reflection Activity",
              "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _promptGenerator = new RandomPrompt("reflection_prompts.txt");
        _questionGenerator = new RandomPrompt("reflection_questions.txt");
    }

    protected override bool DoActivity()
    {

        // Show one main prompt
        string prompt = _promptGenerator.GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();


        Console.WriteLine();
        Console.WriteLine("Now reflect on the following questions:");
        ShowSpinner(3);
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        bool askedAtLeastOne = false;

        while (DateTime.Now < endTime)
        {
            string question = _questionGenerator.GetRandomPrompt();

            Console.WriteLine();
            Console.Write($"> {question} ");
            ShowSpinner(5);

            askedAtLeastOne = true;
        }

        return askedAtLeastOne;
    }
}