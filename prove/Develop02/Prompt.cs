using System;
using System.IO;
public class Prompt
{
    public static string RandomPrompt(string filepath)
    {
        string[] lines = File.ReadAllLines(filepath);
        
        if (lines.Length == 0)
            {
                return null;
            }

        Random rand = new Random();
        int randomIndex = rand.Next(0, lines.Length);

        return lines[randomIndex];
    }

}