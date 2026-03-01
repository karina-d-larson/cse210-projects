using System;

class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base(
            "Breathing Activity",
            "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing."
        )
    {
    }

    protected override bool DoActivity()
    {
        int totalDuration = GetDuration();

        int inhaleTime = 3;
        int holdTime = 2;
        int exhaleTime = 5; 

        int cycleLength = inhaleTime + holdTime + exhaleTime;

        int numberOfCycles = totalDuration / cycleLength;

        if (numberOfCycles < 1)
            return false;

        for (int i = 0; i < numberOfCycles; i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown(inhaleTime);

            Console.Write("Hold... ");
            ShowCountdown(holdTime);

            Console.Write("Breathe out... ");
            ShowCountdown(exhaleTime);

            Console.WriteLine();
        }

        return true;
    }
}