using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter;

        Console.Write("What is your Grade %? ");
        string grade = Console.ReadLine();

        float gradeFloat = float.Parse(grade);

        if (gradeFloat >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeFloat >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeFloat >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeFloat >= 60){
            gradeLetter = "D";
        }
        else{
            gradeLetter = "F";
        }

        Console.WriteLine($"Your letter grade is {gradeLetter}");

        if (gradeFloat >= 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("Let's not procrastinate next time");
        }

        
    }
}