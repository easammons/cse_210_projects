using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = PromptUserName();
        int favNum = PromptUserNumber();

        int numSquare = SquareNumber(favNum);
        DisplayResult(userName, numSquare);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    static String PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? : ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int favNum)
    {
        int square = favNum * favNum;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}