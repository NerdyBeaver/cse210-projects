using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.IO.Enumeration;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    string _filename = "";

    public void AddEntry()
    {
        Entry entry = new Entry(); //Creates new entry object

        entry.WriteEntry();  //Calls the function that allows user to enter entry

        _entries.Add(entry); //Adds the entry to the _entries list.
    }

    public void Display()
    {
        foreach (Entry listed_entry in _entries) //Goes through each entry in _entries and prints the journal entry 
        {
            Console.WriteLine($"Date: {listed_entry._weekday}, {listed_entry._date} — Time: {listed_entry._time} — Prompt: {listed_entry.prompt}");
            Console.WriteLine($"{listed_entry._entry}");
            Console.WriteLine("");
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename?");

        _filename = Console.ReadLine();


        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            Entry file_entry = new Entry();
            file_entry._weekday = parts[0];
            file_entry._date = parts[1];
            file_entry._time = parts[2];
            file_entry.prompt = parts[3];
            file_entry._entry = parts[4];

            _entries.Add(file_entry);
        }
    }

    public void SaveToFile() //Saves the journal entries to a file with user-specified name
    {
        Console.WriteLine("What is the filename?");
        _filename = Console.ReadLine(); //Stores the input as the filename

        using (StreamWriter outputFile = new StreamWriter(_filename)) //Uses the included SteamWriter function to write to the file
        {
            foreach (Entry listed_entry in _entries) //Goes through each entry in _entries and prints the journal entry 
            {
                outputFile.WriteLine($"{listed_entry._weekday}~|~{listed_entry._date}~|~{listed_entry._time}~|~{listed_entry.prompt}~|~{listed_entry._entry}");
            }

        }


        using (StreamWriter outputFile = new StreamWriter("allEntries.txt", true)) //Uses the included SteamWriter function to append all entries to a file for streak tracking
        {
            foreach (Entry listed_entry in _entries) //Goes through each entry in _entries and prints the journal entry 
            {
                outputFile.WriteLine($"{listed_entry._weekday}~|~{listed_entry._date}~|~{listed_entry._time}~|~{listed_entry.prompt}~|~{listed_entry._entry}");
            }

        }
    }

    public (int streak, int largest_streak) StreakTracker() //Calculates the streak for how many days in a row the user has journaled.
    {
        int streak = 1;

        int i = 0;

        List<Entry> streak_entries = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines("allEntries.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            Entry file_entry = new Entry();
            file_entry._weekday = parts[0];
            file_entry._date = parts[1];
            file_entry._time = parts[2];
            file_entry.prompt = parts[3];
            file_entry._entry = parts[4];

            streak_entries.Add(file_entry);
        }

        i = streak_entries.Count() - 1;

        DateTime lastEntryDate = DateTime.Parse(streak_entries[i]._date);

        while (i > 0)
        {
            DateTime previousDate = DateTime.Parse(streak_entries[i - 1]._date);

            if (lastEntryDate == previousDate.AddDays(1)) //Checks to make sure the dates are consecutive
            {
                streak++; //Increases the streak
                lastEntryDate = previousDate; //Moves the 'lastEntryDate' backward to the day before that entry was written
            }
            i--; //Decrements the index so the previousDate is now the previous journal entry's date
        }        
        
        using (StreamWriter outputFile = new StreamWriter("streaks.txt", true)) //Appends streak to a file with the list of streaks in it.
            {
                outputFile.WriteLine(streak);
            }


        int largest_streak = 0;

        string[] streaks = System.IO.File.ReadAllLines("streaks.txt");  //Reads all streaks and tells user what the largest one they have had is.
        foreach (string listed_streak in streaks)
        {
            if (int.Parse(listed_streak) > largest_streak)
            {
                largest_streak = int.Parse(listed_streak);
            }
        }

        return (streak, largest_streak);
    }   

}

