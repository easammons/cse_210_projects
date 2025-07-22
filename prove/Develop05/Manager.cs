class GoalManager
{
    private List<Goal> goals = new();
    private int score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int pts = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, desc, pts));
                break;
            case "2":
                goals.Add(new EternalGoal(name, desc, pts));
                break;
            case "3":
                Console.Write("How many times to complete: ");
                int times = int.Parse(Console.ReadLine());
                Console.Write("Bonus on completion: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, pts, times, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }

        if (goals.Count == 0) return;

        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            int earned = goals[index].RecordEvent();
            Console.WriteLine($"You earned {earned} points!");
            score += earned;
        }
    }

    public void ShowGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var g in goals)
    {
        if (g is ChecklistGoal checklist)
        {
            Console.ForegroundColor = checklist.IsComplete() ? ConsoleColor.Green : ConsoleColor.Cyan;
        }
        else if (g is EternalGoal)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
            Console.ForegroundColor = g.IsComplete() ? ConsoleColor.Green : ConsoleColor.White;
        }

        Console.WriteLine(g.GetStatus());
        Console.ResetColor();
    }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void Save(string filename)
    {
        using StreamWriter writer = new(filename);
        writer.WriteLine(score);
        foreach (var g in goals)
        {
            writer.WriteLine(g.Serialize());
        }
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            Goal g = parts[0] switch
            {
                "Simple" => new SimpleGoal("", "", 0),
                "Eternal" => new EternalGoal("", "", 0),
                "Checklist" => new ChecklistGoal("", "", 0, 0, 0),
                _ => null
            };

            if (g != null)
            {
                g.Deserialize(lines[i]);
                goals.Add(g);
            }
        }
    }
}