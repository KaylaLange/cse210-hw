using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("You don't have any entries in your journal.");
            return;
        }
        for (int i = 0; i < _entries.Count; i++)
        {
            Entry entry = _entries[i];
            Console.WriteLine($"Date: {entry._date} | Prompt: {entry._promptText} | My Response: {entry._entryText} | Where I was when this happened: {entry._userLocation} | What I was doing: {entry._userActivity}");
        }   
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename)) 
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._userLocation}|{entry._userActivity}");       
            }

        }
    }
    
    public void LoadFromFile(string file)
    {
        _entries.Clear(); //added this because duplicate entries were being displayed after saving and selecting load, display
        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[2];
            string _userLocation = parts[3];
            string _userActivity = parts[4];

            Entry entry = new Entry()
            {
                _date = _date,
                _promptText = _promptText,
                _entryText = _entryText,
                _userLocation = _userLocation,
                _userActivity = _userActivity
            };
            
            _entries.Add(entry);
        }
    }
}