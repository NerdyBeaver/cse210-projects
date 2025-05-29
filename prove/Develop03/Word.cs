using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
    public string GetRenderedText()
    {
        if (_isHidden)
        {
            string renderedText = "";
            for (int i = 0; i < _text.Count(); i++) //Return an underscore for each letter in the hidden word
            {
                renderedText = renderedText += "_"; 
            }
            return renderedText;
        }

        else
        {
            return _text;
        }
    }
}