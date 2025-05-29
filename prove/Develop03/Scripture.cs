using System;

public class Scripture
{
    private Reference _reference = new Reference("Isaiah", 3, "5");
    private List<Word> _words = new List<Word>();

    public void HideRandomWords()
    {
        Random random = new Random();

        int wordsToHide = 3; // Number of words to hide each time
        int count = _words.Count;

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(count);    // Picks a random index
            _words[index].Hide();               // Hides the word at the random index
        }
    }
    public string GetRenderedText()
    {
        string result = _reference.ToString() + " - ";

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