using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);


        DisplayResult(userName, squaredNumber, birthYear);
        
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string promptNumber = Console.ReadLine();
        int number = int.Parse(promptNumber);
        return number;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birthyear: ");
        string promptbirth = Console.ReadLine();
        birthYear = int.Parse(promptbirth);
    }
    static int SquareNumber(int number)
    {
        int outputNumber = number*number;
        return outputNumber;
    }

    static void DisplayResult(string name, int sqnumber, int birthyear)
    {
        Console.WriteLine($"{name}, the square of your number is {sqnumber}");
        Console.WriteLine($"{name}, you will turn {DateTime.Now.Year-birthyear} this year.");
    }
    
}
