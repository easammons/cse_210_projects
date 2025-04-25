using System;

class Program
{
    static void Main(string[] args)
    {
       /* Console.WriteLine("Hello Prep2 World!"); */
       Console.Write("What is your grade? ");
       string gradeLine = Console.ReadLine();
       int grade = int.Parse(gradeLine);

        string letter = "";

       if (grade >= 90)
       {
        letter = "A";
       }
       else if (grade >= 80)
       {
        letter = "B";
       }
       else if (grade >= 70)
       {
        letter = "C";
       }
       else if (grade >= 60)
       {
        letter = "D";
       }
       else 
       {
        letter = "F";
       }

        Console.Write($"Your grade is a {letter}");

       if (grade >= 70)
       {
        Console.Write("Congratulations! You passed! ");
       }
       else
       {
        Console.Write("Sorry, you did not pass. Bet you will have much better luck next try.");
       }
    }
}