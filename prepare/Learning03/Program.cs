using System;

class Program
{
    static void Main(string[] args)
    {
        // Initializing
        Random random= new Random();
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);
        Fraction f5 = new Fraction();


        // fraction 1
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        //fraction 2
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        //fraction 3
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        //fraction 4
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        
        //Random fractions
        for (int i = 0; i < 20; i++)
        {
            int topValue = random.Next(1, 11);
            int bottomValue = random.Next(1, 11);
            f5.SetTop(topValue);
            f5.SetBottom(bottomValue);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {f5.GetFractionString()}");
            Console.WriteLine($" Number: {f5.GetDecimalValue()}");
        }
    }
}