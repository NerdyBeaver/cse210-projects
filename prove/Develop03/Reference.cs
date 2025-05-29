using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string book, int chapter, string start)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = null;
    }

    public Reference(string book, int chapter, string start, string end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }

    public string GetDisplayText()
    {
        if (_endVerse == null)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }

        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}
