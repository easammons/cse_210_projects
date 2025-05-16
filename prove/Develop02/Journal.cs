using System;

class Journal
{
    public static string Prompt()
    {
        Random rnd = new Random();
        List<String> prompts = new List<string>();

        prompts.Add("What did you not expect to happen today? ");
        prompts.Add("Did you learn anything new today? ");
        prompts.Add("Did you reach out to other people today? ");
        prompts.Add("Are there any good habits you are keeping up today?");
        prompts.Add("Did you see any interesting plants or animals?");
        prompts.Add("What was the weather like today? How did it make you feel?");
        prompts.Add("Did find a new appreciation for something today?");
        prompts.Add("What are you grateful for?");

        int r = rnd.Next(prompts.Count);
        //Console.Write((string)prompts[r]);

        return (prompts[r]);
    }

    public static string WriteEntry(string[] args)
    {

        string txt = string.Join(" ", args);
        string date = Entry.GetDate();
        string entry = $"{date} - {txt}";
        return (entry);
    }


    
}