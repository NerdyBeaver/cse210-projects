using System;
using System.Collections.Generic;   
using System.IO;
using System.IO.Enumeration;


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
            Console.WriteLine($"Date: {listed_entry._date} — Time: {listed_entry._time} — Prompt: {listed_entry.prompt}");
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
                file_entry._date = parts[0];
                file_entry._time = parts[1];
                file_entry.prompt = parts[2];
                file_entry._entry = parts[3];

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
                outputFile.WriteLine($"{listed_entry._date}~|~{listed_entry._time}~|~{listed_entry.prompt}~|~{listed_entry._entry}");
            }
            
        }
    }

}