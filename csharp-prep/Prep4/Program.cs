using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string Answer = Console.ReadLine();
            int AnswerInt = int.Parse(Answer);

            if (AnswerInt != 0)
            {
                numbers.Add(AnswerInt);
            }
            else
            {
                run = false;
            } 
        }while (run==true);

        float sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = sum/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

        // for (int i = 0; i < numbers.Count; i++)
        // {
        //     Console.WriteLine(numbers[i]);
        // }
        // used for testing
    }
}