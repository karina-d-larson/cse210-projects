using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = LoadRandomScripture("scriptures.txt");

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words hidden. Program ending.");
                break;
            }

            Console.Write("\nPress Enter to continue or type 'quit': ");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit"){ //I do not care enough to handle non quite answers
                break;
            }

            scripture.HideRandomWords(3); 
        }

    }

    static Scripture LoadRandomScripture(string fileName)
    {
        List<string> lines = new List<string>(File.ReadAllLines(fileName));
        List<List<string>> scriptureBlocks = new();
        List<string> currentBlock = new();

        foreach (string line in lines)
        {
            if (line == "------END------")
            {
                scriptureBlocks.Add(new List<string>(currentBlock));
                currentBlock.Clear();
            }
            else
            {
                currentBlock.Add(line);
            }
        }

        Random rand = new Random();
        List<string> chosen = scriptureBlocks[rand.Next(scriptureBlocks.Count)];

        // First line = reference
        string[] refParts = chosen[0].Split(',');
        Reference reference = new Reference(refParts[0], int.Parse(refParts[1]), refParts[2]);

        // Remaining lines = verses
        List<Word> words = new();

        for (int i = 1; i < chosen.Count; i++)
        {
            string verseLine = chosen[i];
            int firstSpace = verseLine.IndexOf(' ');
            string verseNumber = verseLine.Substring(0, firstSpace);
            words.Add(new Word(verseNumber, false)); // verse number never hidden

            string[] verseWords = verseLine.Substring(firstSpace + 1).Split(' ');
            foreach (string w in verseWords)
            {
                words.Add(new Word(w));
            }
        }

        return new Scripture(reference, words);
    }
}
