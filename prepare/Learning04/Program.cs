using System;

class Program
{
    static void Main(string[] args)
    {        
        Console.WriteLine(); //just making it easier to read outputs
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetOutput());
        Console.WriteLine();

        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetOutput());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetOutput());
        Console.WriteLine(a3.GetWritingInformation());
        Console.WriteLine();
    }
}