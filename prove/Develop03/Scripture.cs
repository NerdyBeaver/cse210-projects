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
        int hiddenCount = 0;
        int visibleWords = 0;
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                visibleWords++;
            }
        }

        if (visibleWords < wordsToHide)
        {
            wordsToHide = visibleWords;
        }
        
        while (hiddenCount < wordsToHide)
        {
            int index = random.Next(_words.Count()); // Picks a random index

            if (_words[index].GetIsHidden() == false)
            {
                _words[index].Hide(); // Hides the word at the random index
                hiddenCount++;
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