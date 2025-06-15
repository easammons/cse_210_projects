
public class Reflect : Activity
{
    public Reflect(string name, string description, int seconds)
        : base(name, description, seconds)
    {
        _greeting = "Welcome to the Reflecting Activity!";
        _desc = "This activity will help you reflect on times in your life when you have shown strenth and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _end = $"You have completed another {_duration} seconds of the reflecting activity!";
    }

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void StartActivity()
    {
        Console.WriteLine();
        DisplayGreeting();
        DisplayDescription();
        Console.Write("\nEnter the duration in seconds: ");

        if (int.TryParse(Console.ReadLine(), out int userSeconds))
        {
            _duration = userSeconds;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 30 seconds.");
            _duration = 30;
        }

        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000);

        ShowPrompt();
        ShowQuestionsWithTimer();
        Console.WriteLine();
        DisplayEnding();



    }

    private void ShowPrompt()
    {
        Console.Clear();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"> {prompt}");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue...");
        Console.ReadLine();
        Console.WriteLine("Now ponder on the following questions as they relate to this experience.");
        Thread.Sleep(2000);
    }
    
    private void ShowQuestionsWithTimer()
    {
        Random rand = new Random();
        List<string> usedQuestions = new List<string>();
        int elapsed = 0;
        int questionDelay = 5; // seconds per question

        while (elapsed + questionDelay <= _duration)
        {
            string question;

            // Avoid repeat questions
            do
            {
                question = _questions[rand.Next(_questions.Count)];
            } while (usedQuestions.Contains(question) && usedQuestions.Count < _questions.Count);

            usedQuestions.Add(question);

            Console.Clear();
            Console.WriteLine($"> {question}");
            ShowSpinner(questionDelay);

            elapsed += questionDelay;
        }
    }

    private void ShowSpinner(int durationInSeconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        double timeElapsed = 0;

        while (timeElapsed < durationInSeconds)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(250);
            Console.Write("\b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            timeElapsed += 0.25;
        }

        Console.WriteLine();
    }
}