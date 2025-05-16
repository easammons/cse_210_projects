using System;
using System.Runtime.InteropServices;


class Entry
{
    private static List<string> entries = new List<string>();
    public static string GetDate()
    {
        string currentDate = DateTime.Now.ToString("MMMM dd - ");
        //Console.WriteLine("The current date is: " + currentDate);
        return (currentDate);

    }

    public static void SaveEntry(string prompt, string entry)
    {
        string fullEntry = $"Prompt: {prompt}\nEntry: {entry}\n";
        entries.Add(fullEntry);
        return;
    }

    public static void LoadEntries()
    {
        Console.WriteLine("=== All Journal Entries ===");
        foreach (var e in entries)
        {
            Console.WriteLine(e);
            Console.WriteLine("--------------------------");
        }

    }

     public static void SaveToFile()
    {
        Console.Write("Enter filename to save journal (e.g., journal.txt): ");
        string filename = Console.ReadLine();

        try
        {
            File.WriteAllLines(filename, entries);
            Console.WriteLine($"Journal saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving file: " + ex.Message);
        }
    }
    
    public static void LoadFromFile()
    {
        Console.Write("Enter filename to load journal (e.g., journal.txt): ");
        string filename = Console.ReadLine();

        try
        {
            if (File.Exists(filename))
            {
                entries.Clear();
                string[] fileEntries = File.ReadAllLines(filename);
                entries.AddRange(fileEntries);
                Console.WriteLine("Journal loaded from file.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading file: " + ex.Message);
        }
    }
}