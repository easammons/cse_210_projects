using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            if (num == 0)
            {
                break;
            }

            numbers.Add(num);
        }


        int sum = numbers.Sum();
        Console.WriteLine($"\nThe sum of the numbers is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"\nThe average of the numbers is: {average}");

        int mini = numbers.Min();
        int maxi = numbers.Max();

        Console.WriteLine($"\nThe minimum is: {mini}");
        Console.WriteLine($"\nThe maximum is: {maxi}");

     }
}