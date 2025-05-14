using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _time;
    public string _entry;
    public string prompt; 
    public string WriteEntry()
    {
        DateTime currentTime = DateTime.Now;
        _date = currentTime.ToShortDateString();
        _time = currentTime.ToShortTimeString();
        
        Prompt _promptGenerator = new Prompt();
        prompt = _promptGenerator.DisplayRandomPrompt();

        _entry = Console.ReadLine();

        return _entry;
    }

    
    
    

}