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
        Console.Write("Enter filename to save journal (e.g., journal.csv): ");
        string filename = Console.ReadLine();

    try
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("\"Date\",\"Prompt\",\"Entry\""); // CSV Header

            foreach (var entry in entries)
            {
                string[] parts = entry.Split(new[] { "\n" }, StringSplitOptions.None);

                string prompt = "", content = "", date = "";

                foreach (string line in parts)
                {
                    if (line.StartsWith("Prompt: "))
                        prompt = line.Substring(8);
                    else if (line.StartsWith("Entry: "))
                    {
                        string full = line.Substring(7);
                        date = full.Substring(0, full.IndexOf(' '));
                        content = full.Substring(full.IndexOf(' ') + 1);
                    }
                }

                writer.WriteLine($"{EscapeForCsv(date)},{EscapeForCsv(prompt)},{EscapeForCsv(content)}");
            }
        }

        Console.WriteLine($"Journal saved to {filename}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error saving file: " + ex.Message);
    }
    }

    private static string EscapeForCsv(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "\"\"";

        // Escape quotes by doubling them, and wrap in quotes
        string escaped = input.Replace("\"", "\"\"");
        return $"\"{escaped}\"";
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