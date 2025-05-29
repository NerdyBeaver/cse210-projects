using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        /*Split the scripture into words, create Word object for each word
        and add it to the list */
        _reference = reference;

        string[] words = text.Split(' '); // Splits text into individual words

        foreach (string word in words)
        {
            Word newWord = new Word(word); // Creatse a Word object for each word
            _words.Add(newWord);
        }
    }
    public void HideRandomWords()
    {
        Random random = new Random();

        int wordsToHide = 3; // Number of words to hide each time
        int count = _words.Count;

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(count); // Picks a random index

            if (_words[index].GetIsHidden() == false)
            {
                _words[index].Hide(); // Hides the word at the random index
            }

            else
            {
                wordsToHide++; //If word was already hidden, adds 1 to wordsToHide, repeats loop again so always hides 3 words.
            }

        }
    }
    public string GetRenderedText()
    {
        string result = _reference.GetDisplayText() + " - ";

        for (int i = 0; i < _words.Count; i++)
        {
            result = result + _words[i].GetRenderedText() + " ";
        }

    return result;
    }
    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].GetIsHidden() == false)
            {
                return false;
            }
        }
        return true;

    }
}