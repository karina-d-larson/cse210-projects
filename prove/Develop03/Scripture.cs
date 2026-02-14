using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new();

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine();

        foreach (Word word in _words)
        {
            // If this word is a verse number, start a new line
            if (!word.CanHide())
            {
                Console.WriteLine();
            }

            Console.Write(word.GetDisplay() + " ");
        }

        Console.WriteLine();
    }


    public void HideRandomWords(int count)
    {
        List<Word> availableWords = new();

        foreach (Word word in _words)
        {
            if (word.IsVisible() && word.CanHide())
            {
                availableWords.Add(word);
            }
        }

        int hides = Math.Min(count, availableWords.Count);

        for (int i = 0; i < hides; i++)
        {
            int index = _random.Next(availableWords.Count);
            availableWords[index].Hide();
            availableWords.RemoveAt(index);
        }
    }


    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (word.CanHide() && word.IsVisible())
            {
                return false;
            }
        }
        return true;
    }

}
