using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Sandbox World!");

        Console.WriteLine("Input your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Your first name is: {firstName}");

        Console.WriteLine("Input your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your full name is: {firstName} {lastName}");

        int x = 10;
        if (x == 10)
        {
            Console.WriteLine("x is 10");
        }
    }
}