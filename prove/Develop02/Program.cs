using System;

class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();
        string userChoice = "";

        while (userChoice != "6")
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Edit Today’s Entry");
            Console.WriteLine("3. Display All Entries");
            Console.WriteLine("4. Load File");
            Console.WriteLine("5. Save File");
            Console.WriteLine("6. Quit");
            Console.Write("Type the number for your selection: ");
            userChoice = Console.ReadLine();
            Console.WriteLine();

            if (userChoice == "1")
            {

                currentJournal.WriteEntry();
            }
            else if (userChoice == "2")
            {
                Console.Write("Enter date to edit (MM-dd-yyyy): ");
                string date = Console.ReadLine();
                currentJournal.EditEntry(date);
            }
            else if (userChoice == "3")
            {
                currentJournal.Display();
            }
            else if (userChoice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                currentJournal.LoadFile(filename);
            }
            else if (userChoice == "5")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                currentJournal.SaveFile(filename);
            }
            else if (userChoice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
