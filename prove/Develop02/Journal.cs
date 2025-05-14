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
        if (_filename == "") //Displays all entries in _entries
        {
            foreach (Entry listed_entry in _entries)
            {
                Console.WriteLine(listed_entry);
            }
        }

        else //Displays the saved journal file
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }

   public void LoadFromFile() //Included because this is an option needed on the menu.
                       //Simply changes _filename to the user's input so the 
                       //file is displayed rather than just the recently typed
                       //entries that have not been saved yet.
    {
        Console.WriteLine("What is the filename?");

        _filename = Console.ReadLine();
    }

    public void SaveToFile() //Saves the journal entries to a file with user-specified name
    {
        Console.WriteLine("What is the filename?"); 
        _filename = Console.ReadLine(); //Stores the input as the filename
        
        using (StreamWriter outputFile = new StreamWriter(_filename)) //Uses the included SteamWriter function to write to the file
        {
            foreach (Entry listed_entry in _entries) //Goes through each entry in _entries and prints the journal entry 
            {
                outputFile.WriteLine($"Date: {listed_entry._date} — Prompt: {listed_entry.prompt}");
                outputFile.WriteLine($"{listed_entry._entry}");
                outputFile.WriteLine("");
            }
            
        }
    }

}