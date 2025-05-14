using System;

public class Entry
{
    string _entryTitle;
    string _entry;

    void WriteEntryTitle()
    {
        Console.WriteLine("Enter the date. Optional enter time and short title.");
        string _entryTitle = Console.ReadLine();
    }

    void WriteEntry()
    {
        _entry = Console.ReadLine();
    }

}